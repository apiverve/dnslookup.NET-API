using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// SOA data
    /// </summary>
    public class SOA
    {
        [JsonProperty("nsname")]
        public string Nsname { get; set; }

        [JsonProperty("hostmaster")]
        public string Hostmaster { get; set; }

        [JsonProperty("serial")]
        public int Serial { get; set; }

        [JsonProperty("refresh")]
        public int Refresh { get; set; }

        [JsonProperty("retry")]
        public int Retry { get; set; }

        [JsonProperty("expire")]
        public int Expire { get; set; }

        [JsonProperty("minttl")]
        public int Minttl { get; set; }

    }
    /// <summary>
    /// MX data
    /// </summary>
    public class MX
    {
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

    }
    /// <summary>
    /// Records data
    /// </summary>
    public class Records
    {
        [JsonProperty("A")]
        public string[] A { get; set; }

        [JsonProperty("NS")]
        public string[] NS { get; set; }

        [JsonProperty("SOA")]
        public SOA SOA { get; set; }

        [JsonProperty("MX")]
        public MX[] MX { get; set; }

        [JsonProperty("TXT")]
        public string[][] TXT { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("records")]
        public Records Records { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
