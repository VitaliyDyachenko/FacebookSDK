using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSDK
{
    public class FriendsResponse : BaseResponse
    {
        [JsonProperty("data")]
        public User[] Friends { get; set; }

        [JsonProperty("summary")]
        public FriendsSummary Summary { get; set; }
    }
}
