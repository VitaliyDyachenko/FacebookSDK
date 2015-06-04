using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX;

namespace FacebookSDK
{
    public enum PrivacyType
    {
        [Description("SELF")]
        Self,

        [Description("ALL_FRIENDS")]
        Friends,

        [Description("FRIENDS_OF_FRIENDS")]
        FriendsOfFriends,

        [Description("EVERYONE")]
        Everyone,

        [Description("CUSTOM")]
        Custom
    }
}
