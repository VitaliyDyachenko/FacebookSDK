using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSDK
{
    public class FriendsSummary
    {
        [JsonProperty("total_count")]
        public int TotalFriends { get; set; }
    }
}
