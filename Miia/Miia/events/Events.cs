using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Form;

namespace Miia.events
{
    public class Events
    {
        private ListView view_content;
        private configuration.Manager manager = new configuration.Manager();
        private component.Manager component_manager = new component.Manager();
        private files.Filer filer = new files.Filer();
    
        public Events(ListView view)
        {
            view_content = view;
        }

        private void loader(object sender, EventArgs e)
        {
            configuration = manager.load();
            load_ui(configuration);
        }

        private void saver(object sender, EventArgs e)
        {
            manager.save(configuration);
        }

        private void loader(object sender, EventArgs e)
        {
            string[] directories = filer.get_directories(configuration.root);

            Console.WriteLine($"Total directories: {directories.Length}");

            foreach (string directory in directories) {
                Console.WriteLine(directory);
            }
        }

        private void load_ui(configuration.Configuration.Content configuration)
        {
            List<string> items = new List<string>();
            ImageList images = new ImageList();
            images.ImageSize = new Size(128, 192);

            foreach (configuration.Configuration.Movie movie in configuration.library) {
                if (movie.name != null) {
                    images.Images.Add(
                        Image.FromFile($"{configuration.root}\\{movie.path}\\{movie.splash}")
                    );
                    items.Add(movie.name);
                }
            }
            component_manager.listview(view_content, images, items);
        }
    }
}
