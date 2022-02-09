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
            public string default_name { get; set; }
            public Splash splash_size { get; set; }
            public List<string> extensions { get; set; }
            public List<Movie> favorite { get; set; }
            public List<Movie> queue { get; set; }
            public List<Movie> library { get; set; }
        }

        public class Splash
        {
            public int width { get; set; }
            public int height { get; set; }
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
