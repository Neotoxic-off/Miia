using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Form;

namespace Miia.component
{
    public class Manager
    {
        private async void label(Control controller, string data)
        {
            controller.Invoke(new MethodInvoker(async delegate
            {
                controller.Text = data;
            }));
        }

        private async void listview(ListView controller, ImageList images, string[] items)
        {
            controller.Invoke(new MethodInvoker(async delegate
            {
                for (int i = 0; i < items.Count; i++) {
                    controller.items.Add(items[i], i);
                }

                controller.LargeImageList = images;
            }));
        }
    }
}
