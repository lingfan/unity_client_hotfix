using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using JamesFrowen.SimpleWeb;
using LitJson;
using ProtoBuf;
using UnityEngine;

public class CreateByCode : MonoBehaviour
{
    void Start()
    {
        
        Debug.Log("更新一下");

        Debug.Log("这个脚本是通过代码AddComponent直接创建的");
        
        var person = new Person {
            Id = 12345, Name = "Fred",
            Address = new Address {
                Line1 = "Flat 1",
                Line2 = "The Meadows"
            }
        };
        Debug.Log("OLD:"+person.Id);

        var bytes = PBSerialize(person);

        var newPerson = PBDeSerialize(bytes);
        Debug.Log("New:"+newPerson.Id);

        string jsonStr = JsonMapper.ToJson(newPerson);
        Debug.Log("jsonStr:"+jsonStr);

        Person jsonPerson = JsonMapper.ToObject<Person>(jsonStr);
        Debug.Log("jsonPerson:"+jsonPerson.Id);

        
        string json = @"
            {
                ""Name""     : ""Thomas More"",
                ""Age""      : 57,
                ""Birthday"" : ""02/07/1478 00:00:00""
            }";

        Person1 thomas = JsonMapper.ToObject<Person1>(json);

        Debug.Log("thomas:"+thomas.Birthday);
        
        
       
        
    }
    
    public static byte[] PBSerialize(Person person )
    {
        using (MemoryStream memoryStream = new MemoryStream())
        {
            ProtoBuf.Serializer.Serialize(memoryStream, person);
            return memoryStream.ToArray();
        }
    }
    
    public static Person PBDeSerialize(byte[] data)
    {
        using (MemoryStream ms = new MemoryStream(data))
        {
            return ProtoBuf.Serializer.Deserialize<Person>(ms);
        }
    }
    
    
}
public class Person1
{
    // C# 3.0 auto-implemented properties
    public string   Name     { get; set; }
    public int      Age      { get; set; }
    public DateTime Birthday { get; set; }
}