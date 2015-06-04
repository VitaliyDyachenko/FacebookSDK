using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX;
using IX.Http.Converters;
using Newtonsoft.Json;

namespace FacebookSDK
{
    public class TokenInfo
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the ID of the application this access token is for. </summary>
        ///
        /// <value> The ID of the application this access token is for. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("app_id")]
        public string AppID { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the Name of the application this access token is for. </summary>
        ///
        /// <value> The Name of the application this access token is for. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("application")]
        public string Application { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Any error that a request to the graph api would return due to the access token.
        /// </summary>
        ///
        /// <value> The error. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("error")]
        public ErrorInfo Error { get; set; }


        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter), DateTimeMode.Milliseconds)]
        public DateTime? ExpiresAt { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets Whether the access token is still valid or not. </summary>
        ///
        /// <value> Whether the access token is still valid or not. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Timestamp when this access token was issued. </summary>
        ///
        /// <value> Timestamp when this access token was issued. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("issued_at")]
        [JsonConverter(typeof(UnixDateTimeConverter), DateTimeMode.Milliseconds)]
        public DateTime? IssuedAt { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     General metadata associated with the access token. Can contain data like 'sso',
        ///     'auth_type', 'auth_nonce'.
        /// </summary>
        ///
        /// <value>
        ///     General metadata associated with the access token. Can contain data like 'sso',
        ///     'auth_type', 'auth_nonce'.
        /// </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("metadata")]
        public dynamic Metadata { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The ID of the user this access token is for. </summary>
        ///
        /// <value> The ID of the user this access token is for. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("user_id")]
        public string UserID { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   List of permissions that the user has granted for the app in this access token. </summary>
        ///
        /// <value> List of permissions that the user has granted for the app in this access token. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   For impersonated access tokens, the ID of the page this token contains. </summary>
        ///
        /// <value> For impersonated access tokens, the ID of the page this token contains. </value>
        ///-------------------------------------------------------------------------------------------------

        [JsonProperty("profile_id")]
        public string ProfileID { get; set; }
    }
}
