using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSDK
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Represent debug message. </summary>
    ///
    /// <author>    Anwar Javed. </author>
    /// <date>  7:00 PM 06 May 2015. </date>
    ///-------------------------------------------------------------------------------------------------

    public class DebugMessage
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the message. </summary>
        ///
        /// <value> The message. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("message")]
        public string Message { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the  Message severity. </summary>
        ///
        /// <value> The type. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("type")]
        public string Type { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the link URL with related info. </summary>
        ///
        /// <value> The link URL with related info. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
