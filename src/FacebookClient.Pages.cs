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
        public IHttpResponse<PageResponse> GetPages()
        {
            return this.GetPagesRequest().Response<PageResponse>();
        }

        public async Task<IHttpResponse<PageResponse>> GetPagesAsync()
        {
            return await this.GetPagesRequest().ResponseAsync<PageResponse>();
        }

        private IHttpRequest GetPagesRequest()
        {
            return this.Get("me/accounts");
        }
    }
}
