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
    public partial class Preview : KryptonForm
    {
        private string root = null;
        private configuration.Configuration.Movie movie = null;
        private component.Manager manager = new component.Manager();
        private string default_name = null;

        BackgroundWorker worker_builder = new BackgroundWorker();

        public Preview(Image image, string herit_root, string herit_default_name, configuration.Configuration.Movie herit_movie)
        {
            InitializeComponent();
            InitializeWorker();

            preview_box.BackgroundImage = image;
            movie = herit_movie;
            default_name = herit_default_name;
            root = herit_root;
        }

        private void InitializeWorker()
        {
            worker_builder.DoWork += new DoWorkEventHandler(build);
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            worker_builder.RunWorkerAsync();

            while (worker_builder.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void build(object sender, EventArgs e)
        {
            string[] folders = null;
            string[] files = null;
            string tmp = null;
            int counter = 0;

            manager.label(label_name, movie.name);
            manager.label(last_watched, movie.read);
            if (movie.path != null)
            {
                folders = Directory.GetDirectories($"{root}\\{movie.path}");
                counter = folders.Length;
                if (counter == 0)
                {
                    Directory.CreateDirectory($"{root}\\{movie.path}\\{default_name}");
                    files = Directory.GetFiles($"{root}\\{movie.path}");
                    foreach (string file_ in files)
                    {
                        tmp = file_.Replace($"{root}\\{movie.path}\\", string.Empty);
                        if (tmp != "splash.jpg")
                        {
                            File.Move($"{root}\\{movie.path}\\{tmp}", $"{root}\\{movie.path}\\{default_name}\\{tmp}");
                        }
                    }
                    counter++;
                }
                manager.label(label_seasons, $"{counter}");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
