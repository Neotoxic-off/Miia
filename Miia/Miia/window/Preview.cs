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
        private Point offset;
        private bool mouse_down = false;

        private string root = null;
        private string default_name = null;
        public string watched = null;
        public bool finished = false;
        public bool refresh = false;

        private configuration.Configuration.Movie movie = null;
        private List<string> new_favorite = null;
        private List<string> new_queue = null;
        private List<string> new_extensions = null;
        private component.Manager manager = new component.Manager();
        private Popupok popupok = null;

        BackgroundWorker worker_builder = new BackgroundWorker();
        BackgroundWorker worker_starter = new BackgroundWorker();
        BackgroundWorker worker_updater = new BackgroundWorker();

        public Preview(List<string> extensions, List<string> favorite, List<string> queue, Image image, string herit_root, string herit_default_name, configuration.Configuration.Movie herit_movie)
        {
            InitializeComponent();
            InitializeWorker();

            preview_box.BackgroundImage = image;
            movie = herit_movie;
            default_name = herit_default_name;
            root = herit_root;
            new_favorite = favorite;
            new_queue = queue;
            new_extensions = extensions;
            finished = movie.completed;
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
            manager.check(check_complete, finished);
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

        private string remove_extension(string path)
        {
            string[] splitted = path.Split('.');

            return (splitted[splitted.Length - 2]);
        }

        private void loader()
        {
            List<string> cleanned = Directory.GetDirectories($"{root}\\{movie.path}").ToList();

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
            } else
            {
                button_play.Enabled = true;
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

        private bool is_valid(string name)
        {
            foreach (string extension in new_extensions)
            {
                if (name.EndsWith($".{extension}") == true)
                    return (true);
            }
            return (false);
        }

        private void update_episodes(object sender, EventArgs e)
        {
            string name = null;
            object cbb = manager.get_combobox(combo_seasons);
            List<string> cleanned = Directory.GetFiles($"{root}\\{movie.path}\\{cbb}").ToList();

            for (int i = 0; i < cleanned.Count; i++)
            {
                name = get_name(cleanned[i]);
                if (is_valid(name) == true)
                    cleanned[i] = name;
                else
                    cleanned[i] = string.Empty;
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

        private void button_star_Click(object sender, EventArgs e)
        {
            if (new_favorite.Contains(movie.name) == false)
            {
                new_favorite.Add(movie.name);
                popupok = new Popupok($"'{movie.name}' as been added to favorite list");
                refresh = true;
            }
            else
            {
                popupok = new Popupok($"'{movie.name}' as already been added to favorite list");
            }
            popupok.ShowDialog();
        }

        private void button_queue_Click(object sender, EventArgs e)
        {
            if (new_queue.Contains(movie.name) == false)
            {
                new_queue.Add(movie.name);
                popupok = new Popupok($"'{movie.name}' as been added to watching list");
                refresh = true;
            } else
            {
                popupok = new Popupok($"'{movie.name}' as already been added to watching list");
            }
            popupok.ShowDialog();
        }

        private void border_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouse_down = true;
        }

        private void border_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down == true)
            {
                Point pos = PointToScreen(e.Location);
                Location = new Point(pos.X - offset.X, pos.Y - offset.Y);
            }
        }

        private void border_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void check_complete_CheckedChanged(object sender, EventArgs e)
        {
            finished = check_complete.Checked;
        }
    }
}
