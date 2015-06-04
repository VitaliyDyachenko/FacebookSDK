using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX.Http;

namespace FacebookSDK
{
    partial class FacebookClient
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets friend count Only. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  7:35 PM 07 May 2015. </date>
        ///
        /// <returns>   The friend count. </returns>
        ///-------------------------------------------------------------------------------------------------

        public IHttpResponse<FriendsResponse> GetFriendCount()
        {
            return this.GetFriendCountRequest().Response<FriendsResponse>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets friend count asynchronous. </summary>
        ///
        /// <author>    Anwar Javed. </author>
        /// <date>  7:36 PM 07 May 2015. </date>
        ///
        /// <returns>   The friend count asynchronous. </returns>
        ///-------------------------------------------------------------------------------------------------

        public async Task<IHttpResponse<FriendsResponse>> GetFriendCountAsync()
        {
            return await this.GetFriendCountRequest().ResponseAsync<FriendsResponse>();
        }

        private IHttpRequest GetFriendCountRequest()
        {
            return this.Get("me/friends").Parameter("limit", 0);
        }
    }
}
