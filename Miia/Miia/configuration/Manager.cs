using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Miia.configuration
{
    public class Manager
    {
        private string path = "configuration";

        public Configuration.Content load()
        {
            string file = "configuration.json";

            if (File.Exists($"{path}\\{file}") == true)
            {
                return (JsonConvert.DeserializeObject<Configuration.Content>(
                    File.ReadAllText($"{path}\\{file}")
                ));
            }

            return (null);
        }

        public void save(Configuration.Content data)
        {
            string file = "configuration.json";

            if (File.Exists($"{path}\\{file}") == true)
            {
                File.Delete($"{path}\\{file}");
            }
            File.WriteAllText($"{path}\\{file}", JsonConvert.SerializeObject(data));
        }
    }
}
