using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miia.component
{
    public class Manager
    {
        public async void label(Control controller, string data)
        {
            controller.Invoke(new MethodInvoker(async delegate
            {
                controller.Text = data;
            }));
        }

        public async void listview(ListView controller, ImageList images, List<string> items)
        {
            controller.Invoke(new MethodInvoker(async delegate
            {
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        controller.Items.Add(items[i], i);
                    }
                } else
                {
                    controller.Items.Clear();
                }

                controller.LargeImageList = images;
            }));
        }
    }
}
