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
                controller.Enabled = false;
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
                controller.Enabled = true;
            }));
        }

        public async void combobox(ComboBox controller, List<string> items)
        {
            controller.Invoke(new MethodInvoker(async delegate
            {
                controller.Enabled = false;
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        controller.Items.Add(items[i]);
                    }
                }
                else
                {
                    controller.Items.Clear();
                }
                controller.Enabled = true;
            }));
        }

        public object get_combobox(ComboBox controller)
        {
            object result = null;

            controller.Invoke(new MethodInvoker(delegate
            {
                result = controller.SelectedItem;
            }));

            return (result);
        }
    }
}
