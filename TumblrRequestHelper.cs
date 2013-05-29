using boardwalk.tumblr.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace boardwalk.tumblr
{
    public class TumblrRequestHelper
    {
        private const string TumblrAPI = "http://api.tumblr.com/v2/blog/{0}/posts?api_key={1}";

        public string BlogUrl { get; private set; }
        public string ConsumerKey { get; private set; }
        public bool TextOnly { get; private set; }

        public TumblrRequestHelper(string blogUrl, string consumerKey, bool textOnly)
        {
            this.BlogUrl = blogUrl;
            this.ConsumerKey = consumerKey;
            this.TextOnly = textOnly;
        }

        public TumblrResponse GetPosts()
        {
            string requestUrl = string.Format(TumblrAPI, this.BlogUrl, this.ConsumerKey);
            if (this.TextOnly)
            {
                requestUrl += "&filter=text";
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TumblrResponse));
            TumblrResponse tumblrResponse = (TumblrResponse)ser.ReadObject(resStream);
            return tumblrResponse;
        }
    }
}
