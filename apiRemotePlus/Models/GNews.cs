using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRemotePlus.Models
{
    public class GNews
    {
        public int totalArticles { get; set; }
        public List<article> articles { get; set; }
    }
}
