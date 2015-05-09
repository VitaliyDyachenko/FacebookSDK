using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX;
using IX.Http;
using IX.Http.OAuth;
using IX.Security;

namespace FacebookSDK
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A facebook client. </summary>
    ///
    /// <author>    Anwar Javed. </author>
    /// <date>  4:29 PM 06 May 2015. </date>
    ///-------------------------------------------------------------------------------------------------

    public partial class FacebookClient : OAuth2Client
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Initializes a new instance of the FacebookSDK.FacebookClient class. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  4:29 PM 06 May 2015. </date>
        ///
        /// <param name="appID">
        ///     Identifier for the application.
        /// </param>
        /// <param name="appSecret">
        ///     The application secret.
        /// </param>
        ///-------------------------------------------------------------------------------------------------

        public FacebookClient(string appID, string appSecret) : base(appID, appSecret)
        {
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Initializes a new instance of the FacebookSDK.FacebookClient class. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  4:29 PM 06 May 2015. </date>
        ///
        /// <param name="appID">
        ///     Identifier for the application.
        /// </param>
        /// <param name="appSecret">
        ///     The application secret.
        /// </param>
        /// <param name="credential">
        ///     The credential.
        /// </param>
        ///-------------------------------------------------------------------------------------------------

        public FacebookClient(string appID, string appSecret, OAuth2TokenCredential credential)
            : base(appID, appSecret, credential)
        {
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Initializes a new instance of the FacebookSDK.FacebookClient class. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  4:29 PM 06 May 2015. </date>
        ///
        /// <param name="appID">
        ///     Identifier for the application.
        /// </param>
        /// <param name="appSecret">
        ///     The application secret.
        /// </param>
        /// <param name="token">
        ///     The token.
        /// </param>
        ///-------------------------------------------------------------------------------------------------

        public FacebookClient(string appID, string appSecret, string token)
            : base(appID, appSecret, token)
        {
        }

        public override void OnInitRequest(IHttpRequest request)
        {
            if (this.EnableAppSecretProof)
            {
                var appsecretProof = Cryptography.CreateHMAC(HashMode.SHA256, this.Credential.Token, this.AppSecret);
                request.Parameter("appsecret_proof", appsecretProof);
            }

            if (this.Debug.HasValue)
            {
                var mode = this.Debug.ToDescription();
                request.Parameter("debug", mode);
            }

            base.OnInitRequest(request);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Gets or sets a value indicating whether the application secret proof is enabled.
        /// </summary>
        ///
        /// <value> true if enable application secret proof, false if not. </value>
        ///-------------------------------------------------------------------------------------------------

        public bool EnableAppSecretProof { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the debug Mode. </summary>
        ///
        /// <value> The debug mode. </value>
        ///-------------------------------------------------------------------------------------------------

        public DebugMode? Debug { get; set; }


        public override string BaseUrl
        {
            get { return "https://graph.facebook.com"; }
        }

        public override string Version
        {
            get { return "v2.3"; }
        }

        protected override string AuthorizationUrl
        {
            get { return "https://www.facebook.com/{0}/dialog/oauth".FormatString(this.Version); }
        }

        protected override string AccessTokenUrl
        {
            get { return BuildEndPointUrl("oauth/access_token"); }
        }

        protected override string RefreshTokenUrl
        {
            get { return BuildEndPointUrl("oauth/access_token"); }
        }

        protected override string RevokeTokenUrl
        {
            get { return BuildEndPointUrl("me/permissions"); }
        }
    }
}
