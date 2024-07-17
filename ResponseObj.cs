using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class sOA
{
    [JsonProperty("nsname")]
    public string nsname { get; set; }

    [JsonProperty("hostmaster")]
    public string hostmaster { get; set; }

    [JsonProperty("serial")]
    public int serial { get; set; }

    [JsonProperty("refresh")]
    public int refresh { get; set; }

    [JsonProperty("retry")]
    public int retry { get; set; }

    [JsonProperty("expire")]
    public int expire { get; set; }

    [JsonProperty("minttl")]
    public int minttl { get; set; }

}

public class mX
{
    [JsonProperty("exchange")]
    public string exchange { get; set; }

    [JsonProperty("priority")]
    public int priority { get; set; }

}

public class records
{
    [JsonProperty("A")]
    public string[] a { get; set; }

    [JsonProperty("NS")]
    public string[] nS { get; set; }

    [JsonProperty("SOA")]
    public sOA sOA { get; set; }

    [JsonProperty("MX")]
    public mX[] mX { get; set; }

    [JsonProperty("TXT")]
    public string[][] tXT { get; set; }

}

public class data
{
    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("records")]
    public records records { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
