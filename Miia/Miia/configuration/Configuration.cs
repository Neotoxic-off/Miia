using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miia.configuration
{
    public class Configuration
    {
        public class Content
        {
            public string version { get; set; }
            public string root { get; set; }
            public List<Movie> movies { get; set; }
        }

        public class Movie
        {
            public string name { get; set; }
            public string path { get; set; }
            public string splash { get; set; }
            public string read { get; set; }
        }
    }
}
