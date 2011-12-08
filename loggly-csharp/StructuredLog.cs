using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Loggly
{
    public enum StructuredLogLevel
    {
        info,
        debug,
        warn,
        fatal,
        error
    }

    public class StructuredLog
    {
        [JsonProperty("level")]
        public string Level { get; set; }
        [JsonProperty("machine")]
        public string MachineName { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        public override string ToString()
        {
            return "[" + Level.ToString() + "] - Machine: " + MachineName + " - " + Message;
        }

        public string ToJSON()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return json;
        }

    }
}
