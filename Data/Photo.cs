using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boardwalk.tumblr.Data
{
    public class Photo
    {
        public string caption { get; set; }
        public List<AltSize> alt_sizes { get; set; }
        public OriginalSize original_size { get; set; }
    }
}
