using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSDK
{
    public class ErrorInfo
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the error code for the error. </summary>
        ///
        /// <value> The error code for the error. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("code")]
        public int Code { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the  error message for the error.. </summary>
        ///
        /// <value> The  error message for the error.. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("message")]
        public string Message { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the error subcode for the error. </summary>
        ///
        /// <value> The error subcode for the error. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("subcode")]
        public int SubCode { get; set; }
    }
}
