using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boardwalk.tumblr.Data
{
    public class Blog
    {
        public string title { get; set; }
        public string name { get; set; }
        public int posts { get; set; }
        public string url { get; set; }
        public int updated { get; set; }
        public string description { get; set; }
        public bool ask { get; set; }
        public bool ask_anon { get; set; }
        public bool is_nsfw { get; set; }
        public bool share_likes { get; set; }
        public int likes { get; set; }
    }
}
