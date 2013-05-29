using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boardwalk.tumblr.Data
{
    public class Response
    {
        public Blog blog { get; set; }
        public List<Post> posts { get; set; }
        public int total_posts { get; set; }
    }
}
