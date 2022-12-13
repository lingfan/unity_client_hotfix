using System;
using System.IO;
using System.Text;
using JamesFrowen.SimpleWeb;
using LitJson;
using UnityEngine;

public class wsclient : MonoBehaviour
{
    bool echo;
    private SimpleWebClient client;
    float keepAlive;

    private void Connect()
    {
        Debug.Log($"Connected1");

        var tcpConfig = new TcpConfig(noDelay:false, sendTimeout: 5000, receiveTimeout: 10000);
        client = SimpleWebClient.Create(ushort.MaxValue, 500, tcpConfig);

        client.onConnect += () =>
        {
            Debug.Log($"Connected to Server");
            C_USER_LOGIN msg = new C_USER_LOGIN();
            msg.server_id = 1;
            msg.user_id =  111;

           var data = BuildProtoBufRustServer(1003, msg);
            client.Send(data);
        };
        client.onDisconnect += () => Debug.Log($"Disconnected from Server");
        client.onData += OnData;
        client.onError += (exception) => Debug.Log($"Error because of Server, Error:{exception}");

        var builder = new UriBuilder
        {
            Scheme = "ws",
            Host = "82.157.123.54",
            Port = 9010,
        };
        builder.Path = "ajaxchattest";
        // client.Connect(builder.Uri);
        client.Connect(new Uri("ws://192.168.1.110:16801/"));

        //client.Connect(new Uri("ws://82.157.123.54:9010/ajaxchattest"));
    }
    private void Update()
    {
        client?.ProcessMessageQueue();
        if (keepAlive < Time.time)
        {
            // client?.Send(new ArraySegment<byte>(new byte[1] { 0 }));
            // keepAlive = Time.time + 1;
        }
    }
    private void OnDestroy()
    {
        client?.Disconnect();
    }

    void OnData(ArraySegment<byte> data)
    {
        Debug.Log($"Data from Server, length:{data.Count}");

        
        
        MemoryStream readStream2 = new MemoryStream(data.ToArray());
        BinaryReader bread = new BinaryReader(readStream2, Encoding.UTF8);
        uint protoId = bread.ReadUInt32();
        uint _len = bread.ReadUInt32();
        uint a = bread.ReadUInt32();
        uint b = bread.ReadUInt32();
        byte[] data1 = bread.ReadBytes((int) _len);

        Debug.Log("接受到服务端  pMsg protoId：[" + protoId + "] pMsg：" + _len);

        var result = ProtoDeSerialize<S_USER_LOGIN>(data1);
        Debug.Log("LoginResult " + result.last_login_time);
        Debug.Log("LoginResult " + JsonMapper.ToJson(result));

        if (echo)
        {
            if (client is WebSocketClientStandAlone standAlone)
                standAlone.Send(data);
            else
                client.Send(data);
        }
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Connect"))
        {
            Connect();
        }

        echo = GUILayout.Toggle(echo, "Echo");
    }
  
    public byte[] BuildProtoBufRustServer<T>(int protoId, T data) where T : class
    {
        MemoryStream DataStream = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(DataStream);
        var pdata = ProtoSerialize(data);

        writer.Write(protoId);
        writer.Write(pdata.Length+16);
        writer.Write(0);
        writer.Write(0);
        writer.Write(pdata);
        byte[] pMsg = DataStream.ToArray();
        return pMsg;
    }
    
    public static byte[] ProtoSerialize<T>(T obj) where T : class
    {
        try
        {
            using (var stream = new System.IO.MemoryStream())
            {
                ProtoBuf.Serializer.Serialize(stream, obj);
                return stream.ToArray();
            }
        }
        catch (IOException ex)
        {
            Debug.Log($"[StringifyHelper] 错误：{ex.Message}, {ex.Data["StackTrace"]}");
            return null;
        }
    }
    public static T ProtoDeSerialize<T>(byte[] msg) where T : class
    {
        try
        {
            return ProtoBuf.Serializer.Deserialize<T>(new MemoryStream(msg));
        }
        catch (IOException ex)
        {
            Debug.Log($"[StringifyHelper] 错误：{ex.Message}, {ex.Data["StackTrace"]}");
            return null;
        }
    }
}