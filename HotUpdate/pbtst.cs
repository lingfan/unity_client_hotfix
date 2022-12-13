using System;
using System.ComponentModel;
using ProtoBuf;

[ProtoContract]
public class Person {
    [ProtoMember(1)]
    public int Id {get;set;}
    [ProtoMember(2)]
    public string Name {get;set;}
    [ProtoMember(3)]
    public Address Address {get;set;}
}
[ProtoContract]
public class Address {
    [ProtoMember(1)]
    public string Line1 {get;set;}
    [ProtoMember(2)]
    public string Line2 {get;set;}
}

[ProtoContract]
public class C_USER_LOGIN
{
    [ProtoMember(1)]
    [DefaultValue("")]
    public string register_platform = "";

    [ProtoMember(2)]
    [DefaultValue("")]
    public string platform_value = "";

    [ProtoMember(3)]
    public uint user_id;

    [ProtoMember(4)]
    public uint server_id;

}


[ProtoContract]
public class S_USER_LOGIN
{
    [ProtoMember(1)]
    public bool is_succ;

    [ProtoMember(2)]
    [DefaultValue("")]
    public string err_mess = "";

    [ProtoMember(3)]
    public uint sync_time;

    [ProtoMember(4)]
    public uint last_login_time;

    [ProtoMember(5)]
    public uint last_logoff_time;

}
