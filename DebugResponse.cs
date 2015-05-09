using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSDK
{
    public class DebugResponse
    {
        [JsonProperty("messages")]
        public DebugMessage[] Messages { get; set; }
    }
}
