using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX.Http.OAuth;
using Newtonsoft.Json;

namespace FacebookSDK
{
    public abstract class BaseResponse : OAuth2BaseResponse
    {
        [JsonProperty("__debug__")]
        public DebugResponse DebugInfo { get; set; }
    }
}
