using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX;
using IX.Http;
using IX.Http.OAuth;
using Newtonsoft.Json;

namespace FacebookSDK
{
    partial class FacebookClient
    {
        public IHttpResponse<string> Publish(Post post, Privacy privacy = null)
        {
            return this.GetPublishRequest(post, privacy).Response<string>();
        }

        public async Task<IHttpResponse<string>> PublishAsync(Post post, Privacy privacy = null)
        {
            return await this.GetPublishRequest(post, privacy).ResponseAsync<string>();
        }

        private IHttpRequest GetPublishRequest(Post post, Privacy privacy = null)
        {
            if (post == null) throw new ArgumentNullException("post");

            var request = this.Post("me/feed")
                .Body("message", post.Message)
                .Body("link", post.Link)
                .Body("picture", post.Picture)
                .Body("name", post.Title)
                .Body("caption", post.Caption)
                .Body("description", post.Description);

            if (privacy != null)
            {
                if (privacy.Type.HasValue)
                {
                    if (privacy.Type.Value == PrivacyType.Custom)
                    {
                        request.Body("privacy", JsonConvert.SerializeObject(new
                        {
                            value = privacy.Type.Value.ToDescription(),
                            allow =
                                privacy.Allow != null && privacy.Allow.Length > 0
                                    ? privacy.Allow.ToConcatenatedString(",")
                                    : null,
                            deny =
                                privacy.Deny != null && privacy.Deny.Length > 0
                                    ? privacy.Deny.ToConcatenatedString(",")
                                    : null
                        }, Formatting.None));
                    }
                    else
                    {
                        request.Body("privacy", JsonConvert.SerializeObject(new
                        {
                            value = privacy.Type.Value.ToDescription(),
                        }, Formatting.None));
                    }
                }
            }


            return request;
        }
    }
}
