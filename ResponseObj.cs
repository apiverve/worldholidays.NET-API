using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Holidays data
    /// </summary>
    public class Holidays
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("holidays")]
        public Holidays[] Holidays { get; set; }

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
