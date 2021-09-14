using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wdHodinkee.Models
{
    public class article
    {
        public string title { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public string url { get; set; }
        public string image { get; set; }
        public string publishedAt { get; set; }
        public attrSource source { get; set; }
    }
}
