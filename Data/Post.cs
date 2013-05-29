using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boardwalk.tumblr.Data
{
    public class Post
    {
        public string blog_name { get; set; }
        public object id { get; set; }
        public string post_url { get; set; }
        public string slug { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public int timestamp { get; set; }
        public string state { get; set; }
        public string format { get; set; }
        public string reblog_key { get; set; }
        public List<object> tags { get; set; }
        public string short_url { get; set; }
        public List<object> highlighted { get; set; }
        public int note_count { get; set; }
        public string caption { get; set; }
        public string link_url { get; set; }
        public string image_permalink { get; set; }
        public List<Photo> photos { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string source_url { get; set; }
        public string source_title { get; set; }
        public string body { get; set; }
        public string text { get; set; }
        public string source { get; set; }
    }
}
