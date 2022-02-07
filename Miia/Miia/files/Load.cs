using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miia.files
{
    public class Load
    {
        public string[] get_directories(string path)
        {
            if (Directory.Exists(path) == true)
            {
                return (Directory.GetDirectories(path));
            }

            return (null);
        }

        public string[] get_files(string path)
        {
            if (Directory.Exists(path) == true)
            {
                return (Directory.GetFiles(path));
            }

            return (null);
        }
    }
}
