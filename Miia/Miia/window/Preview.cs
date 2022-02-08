using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public string watched = null;

        BackgroundWorker worker_builder = new BackgroundWorker();
        BackgroundWorker worker_starter = new BackgroundWorker();
        BackgroundWorker worker_updater = new BackgroundWorker();

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
            worker_starter.DoWork += new DoWorkEventHandler(start);
            worker_updater.DoWork += new DoWorkEventHandler(update_episodes);
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

            loader();
        }

        private string get_name(string path)
        {
            string[] splitted = path.Split('\\');

            return (splitted[splitted.Length - 1]);
        }

        private void loader()
        {
            List<string> cleanned = new List<string>();

            cleanned = Directory.GetDirectories($"{root}\\{movie.path}").ToList();
            for (int i = 0; i < cleanned.Count; i++)
            {
                cleanned[i] = get_name(cleanned[i]);
            }

            manager.combobox(combo_seasons, cleanned);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void start(object sender, EventArgs e)
        {
            object seasons = manager.get_combobox(combo_seasons);
            object episodes = manager.get_combobox(combo_episodes);
            string selected = $"{root}\\{movie.path}\\{seasons}\\{episodes}";

            if (seasons != null && episodes != null)
            {
                if (File.Exists(selected) == true)
                {
                    Process.Start(selected);
                    watched = $"{episodes}";
                }
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            button_play.Enabled = false;
            worker_starter.RunWorkerAsync();

            while (worker_starter.IsBusy == true)
            {
                Application.DoEvents();
            }

            if (watched != null)
                Close();
        }

        private void update_episodes(object sender, EventArgs e)
        {
            List<string> cleanned = new List<string>();
            object cbb = manager.get_combobox(combo_seasons);

            cleanned = Directory.GetFiles($"{root}\\{movie.path}\\{cbb}").ToList();
            for (int i = 0; i < cleanned.Count; i++)
            {
                cleanned[i] = get_name(cleanned[i]);
            }

            manager.combobox(combo_episodes, cleanned);
        }

        private void combo_seasons_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_seasons.SelectedItem != null)
            {
                worker_updater.RunWorkerAsync();

                while (worker_updater.IsBusy == true)
                {
                    Application.DoEvents();
                }
            }
        }
    }
}
