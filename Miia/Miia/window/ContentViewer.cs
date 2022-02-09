using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace Miia.window
{
    public partial class ContentViewer : KryptonForm
    {
        public List<string> new_content = null;
        private string new_label = null;
        public bool refresh = false;

        private BackgroundWorker worker_builder = new BackgroundWorker();
        private component.Manager manager = new component.Manager();

        public ContentViewer(string type_data, List<string> content)
        {
            InitializeComponent();
            InitializeWorker();

            new_label = type_data;
            new_content = content;
        }

        private void InitializeWorker()
        {
            worker_builder.DoWork += new DoWorkEventHandler(build);
        }

        private void build(object sender, EventArgs e)
        {
            manager.label(label_type, new_label);
            manager.listview(list_content, null, null);
            manager.listview(list_content, null, new_content);
        }

        private void run_build()
        {
            worker_builder.RunWorkerAsync();

            while (worker_builder.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void ContentViewer_Load(object sender, EventArgs e)
        {
            run_build();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (list_content.SelectedItems.Count > 0)
            {
                refresh = true;
                new_content.Remove(list_content.SelectedItems[0].Text);
                run_build();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
