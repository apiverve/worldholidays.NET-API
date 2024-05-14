using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class holidays
{
    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("start")]
    public DateTime start { get; set; }

    [JsonProperty("end")]
    public DateTime end { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

}

public class data
{
    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("year")]
    public string year { get; set; }

    [JsonProperty("holidays")]
    public holidays[] holidays { get; set; }

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
