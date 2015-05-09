using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX;
using IX.Http;
using IX.Http.OAuth;

namespace FacebookSDK
{
    /// <content>   A facebook client. </content>
    partial class FacebookClient
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets authorization URL. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  2:30 PM 07 May 2015. </date>
        ///
        /// <param name="redirectUrl">
        ///     URL of the redirect.
        /// </param>
        /// <param name="state">
        ///     The state.
        /// </param>
        /// <param name="permission">
        ///     A variable-length parameters list containing permission.
        /// </param>
        ///
        /// <returns>   The authorization URL. </returns>
        ///-------------------------------------------------------------------------------------------------

        public string GetAuthorizationUrl(string redirectUrl, string state = null, params PermissionTypes[] permission)
        {
            string scopes = null;

            if (permission != null && permission.Length > 0)
            {
                scopes = permission.ToConcatenatedString(x => x.ToDescription(), ",");
            }

            return base.GetAuthorizationUrl(redirectUrl, scopes, state);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets authorization URL. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  2:30 PM 07 May 2015. </date>
        ///
        /// <param name="redirectUrl">
        ///     URL of the redirect.
        /// </param>
        /// <param name="permission">
        ///     A variable-length parameters list containing permission.
        /// </param>
        ///
        /// <returns>   The authorization URL. </returns>
        ///-------------------------------------------------------------------------------------------------

        public string GetAuthorizationUrl(string redirectUrl, params PermissionTypes[] permission)
        {
            return this.GetAuthorizationUrl(redirectUrl, null, permission);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets access token. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  2:41 PM 07 May 2015. </date>
        ///
        /// <param name="code">
        ///     The code.
        /// </param>
        /// <param name="redirectUrl">
        ///     URL of the redirect.
        /// </param>
        ///
        /// <returns>   The access token. </returns>
        ///-------------------------------------------------------------------------------------------------

        public IHttpResponse<OAuth2TokenCredential> GetAccessToken(string code, string redirectUrl)
        {
            return base.GetAccessToken<OAuth2TokenCredential>(code, redirectUrl);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets access token asynchronous. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  4:34 PM 07 May 2015. </date>
        ///
        /// <param name="code">
        ///     The code.
        /// </param>
        /// <param name="redirectUrl">
        ///     URL of the redirect.
        /// </param>
        ///
        /// <returns>   The access token asynchronous. </returns>
        ///-------------------------------------------------------------------------------------------------

        public async Task<IHttpResponse<OAuth2TokenCredential>> GetAccessTokenAsync(string code, string redirectUrl)
        {
            return await base.GetAccessTokenAsync<OAuth2TokenCredential>(code, redirectUrl);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets extended access token. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  4:34 PM 07 May 2015. </date>
        ///
        /// <returns>   The extended access token. </returns>
        ///-------------------------------------------------------------------------------------------------

        public IHttpResponse<OAuth2TokenCredential> GetExtendedAccessToken()
        {
            return base.GetRefreshToken<OAuth2TokenCredential>(OAuth2GrantType.FacebookExchangeToken);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets extended access token asynchronous. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  4:34 PM 07 May 2015. </date>
        ///
        /// <returns>   The extended access token asynchronous. </returns>
        ///-------------------------------------------------------------------------------------------------

        public async Task<IHttpResponse<OAuth2TokenCredential>> GetExtendedAccessTokenAsync()
        {
            return await base.GetRefreshTokenAsync<OAuth2TokenCredential>(OAuth2GrantType.FacebookExchangeToken);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Revoke token. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  4:38 PM 07 May 2015. </date>
        ///
        /// <returns>   An IHttpResponse&lt;bool&gt; </returns>
        ///-------------------------------------------------------------------------------------------------

        public IHttpResponse<bool> RevokeToken()
        {
            var request = this.Delete(this.RevokeTokenUrl);

            var response = request.Response<bool>();

            if (response.Completed && response.Body)
            {
                this.Credential = null;
            }

            return response;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Revoke token asynchronous. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  4:38 PM 07 May 2015. </date>
        ///
        /// <returns>   A Task&lt;IHttpResponse&lt;bool&gt;&gt; </returns>
        ///-------------------------------------------------------------------------------------------------

        public async Task<IHttpResponse<bool>> RevokeTokenAsync()
        {
            var request = this.Delete(this.RevokeTokenUrl);

            var response = await request.ResponseAsync<bool>();

            if (response.Completed && response.Body)
            {
                this.Credential = null;
            }

            return response;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     This endpoint returns metadata about a given access token. This includes data such as the
        ///     user for which the token was issued, whether the token is still valid, when it expires,
        ///     and what permissions the app has for the given user.
        /// </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  5:08 PM 07 May 2015. </date>
        ///
        /// <returns>   An IHttpResponse&lt;DebugTokenResponse&gt; </returns>
        ///-------------------------------------------------------------------------------------------------

        public IHttpResponse<DebugTokenResponse> DebugToken()
        {
            return this.GetDebugTokenRequest().Response<DebugTokenResponse>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     This endpoint returns metadata about a given access token. This includes data such as the
        ///     user for which the token was issued, whether the token is still valid, when it expires,
        ///     and what permissions the app has for the given user.
        /// </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  5:08 PM 07 May 2015. </date>
        ///
        /// <returns>   An IHttpResponse&lt;DebugTokenResponse&gt; </returns>
        ///-------------------------------------------------------------------------------------------------

        public async Task<IHttpResponse<DebugTokenResponse>> DebugTokenAsync()
        {
            return await GetDebugTokenRequest().ResponseAsync<DebugTokenResponse>();
        }

        private IHttpRequest GetDebugTokenRequest()
        {
            return this.Get("debug_token").Parameter("input_token", this.Credential.Token);
        }
    }
}
