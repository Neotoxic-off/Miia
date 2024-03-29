﻿using System;
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

namespace Miia
{
    public partial class Miia : KryptonForm
    {
        private Point offset;
        private bool mouse_down = false;

        private configuration.Configuration.Content configuration = null;
        private configuration.Manager manager = new configuration.Manager();
        private component.Manager component_manager = new component.Manager();

        private files.Filer filer = new files.Filer();

        private window.Popupok popupok = null;
        private window.Settings window_settings = null;
        private window.Preview window_preview = null;
        private window.ContentViewer content_viewer = null;

        private BackgroundWorker worker_loader = new BackgroundWorker();
        private BackgroundWorker worker_builder = new BackgroundWorker();
        private BackgroundWorker worker_saver = new BackgroundWorker();
        private BackgroundWorker worker_ui = new BackgroundWorker();

        private Image no_splash = Image.FromFile("assets\\no_splash.png");

        public Miia()
        {
            InitializeComponent();
            InitializeWorker();
        }

        private void InitializeWorker()
        {
            worker_loader.DoWork += new DoWorkEventHandler(loader);
            worker_saver.DoWork += new DoWorkEventHandler(saver);
            worker_builder.DoWork += new DoWorkEventHandler(builder);
            worker_ui.DoWork += new DoWorkEventHandler(load_ui);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            
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

        private void Miia_Load(object sender, EventArgs e)
        {
            worker_loader.RunWorkerAsync();

            while (worker_loader.IsBusy == true)
            {
                Application.DoEvents();
            }

            worker_ui.RunWorkerAsync();

            while (worker_ui.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        public void reload()
        {
            worker_saver.RunWorkerAsync();

            while (worker_saver.IsBusy == true)
            {
                Application.DoEvents();
            }

            worker_loader.RunWorkerAsync();

            while (worker_loader.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        public void loader(object sender, EventArgs e)
        {
            configuration = manager.load();
        }

        public void saver(object sender, EventArgs e)
        {
            manager.save(configuration);
        }

        private configuration.Configuration.Movie movie(string name, string path)
        {
            configuration.Configuration.Movie movie = new configuration.Configuration.Movie();

            movie.name = name;
            movie.path = path;
            movie.splash = "splash.jpg";
            movie.read = "0";
            movie.completed = false;

            return (movie);
        }

        private string get_name(string path)
        {
            string[] splitted = path.Split('\\');

            return (splitted[splitted.Length - 1]);
        }

        private bool exists(string name)
        {
            foreach (configuration.Configuration.Movie movie_data in configuration.library)
            {
                if (movie_data.name == name)
                    return (true);
            }
            return (false);
        }

        public void builder(object sender, EventArgs e)
        {
            string[] directories = null;
            string cleanned = null;

            if (configuration.root != null)
            {
                directories = filer.get_directories(configuration.root);
                foreach (string directory in directories)
                {
                    cleanned = get_name(directory);
                    if (exists(cleanned) == false)
                    {
                        configuration.library.Add(
                            movie(
                                cleanned,
                                $"{directory.Replace($"{configuration.root}\\", string.Empty)}"
                            )
                        );
                    }
                }
            }
        }

        private void load_ui(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            ImageList images = new ImageList();
            images.ImageSize = new Size(configuration.splash_size.width, configuration.splash_size.height);
            string splash_path = null;

            component_manager.listview(view_content, null, null);
            foreach (configuration.Configuration.Movie movie in configuration.library)
            {
                if (movie.path != null)
                {
                    if (items.Contains(movie.path) == false)
                    {
                        splash_path = $"{configuration.root}\\{movie.path}\\{movie.splash}";
                        if (File.Exists(splash_path) == true)
                        {
                            images.Images.Add(
                                Image.FromFile(splash_path)
                            );
                        } else
                        {
                            images.Images.Add(no_splash);
                        }
                        items.Add(movie.path);
                    }
                }
            }
            component_manager.listview(view_content, images, items);
        }

        private configuration.Configuration.Movie get_movie(string name)
        {
            foreach (configuration.Configuration.Movie movie in configuration.library)
            {
                if (movie.name == name)
                    return (movie);
            }

            return (null);
        }

        private int get_movie_index(string name)
        {
            for (int i = 0; i < configuration.library.Count; i++)
            {
                if (configuration.library[i].name == name)
                    return (i);
            }

            return (-1);
        }

        private void view_content_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;
            bool reload_data = false;

            if (view_content.SelectedItems.Count > 0)
            {
                window_preview = new window.Preview(
                    configuration.extensions,
                    configuration.favorite,
                    configuration.queue,
                    view_content.LargeImageList.Images[view_content.SelectedIndices[0]],
                    configuration.root,
                    configuration.default_name,
                    get_movie(view_content.SelectedItems[0].Text)
                );
                window_preview.ShowDialog();
                index = get_movie_index(view_content.SelectedItems[0].Text);
                if (window_preview.watched != null)
                {
                    configuration.library[index].read = window_preview.watched;
                    reload_data = true;
                }
                if (window_preview.finished != configuration.library[index].completed)
                {
                    configuration.library[index].completed = window_preview.finished;
                    reload_data = true;
                }
                if (window_preview.refresh == true)
                    reload_data = true;
                if (reload_data == true)
                    reload();
            }
        }

        private void addListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = null;
            bool refresh = false;

            if (view_content.SelectedItems.Count > 0)
            {
                name = view_content.SelectedItems[0].Text;
                if (configuration.queue.Contains(name) == false)
                {
                    configuration.queue.Add(name);
                    popupok = new window.Popupok($"'{name}' as been added to favorite list");
                    refresh = true;
                }
                else
                {
                    popupok = new window.Popupok($"'{name}' as already been added to favorite list");
                }
                popupok.ShowDialog();
                if (refresh == true)
                    reload();
            }
        }

        private void addToFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = null;
            bool refresh = false;

            if (view_content.SelectedItems.Count > 0)
            {
                name = view_content.SelectedItems[0].Text;
                if (configuration.favorite.Contains(name) == false)
                {
                    configuration.queue.Add(name);
                    popupok = new window.Popupok($"'{name}' as been added to favorite list");
                    refresh = true;
                }
                else
                {
                    popupok = new window.Popupok($"'{name}' as already been added to favorite list");
                }
                popupok.ShowDialog();
                if (refresh == true)
                    reload();
            }
        }

        private void button_queue_Click_1(object sender, EventArgs e)
        {
            content_viewer = new window.ContentViewer("Watchlish", configuration.queue);
            content_viewer.ShowDialog();
            if (content_viewer.refresh == true)
            {
                configuration.queue = content_viewer.new_content;
                reload();
            }
        }

        private void button_reduce_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_settings_Click_1(object sender, EventArgs e)
        {
            window_settings = new window.Settings(configuration);
            window_settings.ShowDialog();

            configuration = window_settings.configuration;
            worker_saver.RunWorkerAsync();

            while (worker_saver.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void button_reload_Click_1(object sender, EventArgs e)
        {
            worker_builder.RunWorkerAsync();

            while (worker_builder.IsBusy == true)
            {
                Application.DoEvents();
            }
            reload();
            worker_ui.RunWorkerAsync();

            while (worker_ui.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void button_favorites_Click_1(object sender, EventArgs e)
        {
            content_viewer = new window.ContentViewer("Favorites", configuration.favorite);
            content_viewer.ShowDialog();
            if (content_viewer.refresh == true)
            {
                configuration.favorite = content_viewer.new_content;
                reload();
            }
        }

        private void setAsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = null;
            bool refresh = false;
            int id = 0;

            if (view_content.SelectedItems.Count > 0)
            {
                name = view_content.SelectedItems[0].Text;
                id = get_movie_index(name);
                if (configuration.library[id].completed == false)
                {
                    configuration.library[id].completed = true;
                    popupok = new window.Popupok($"'{name}' as been set to completed");
                    refresh = true;
                }
                else
                {
                    configuration.library[id].completed = false;
                    popupok = new window.Popupok($"'{name}' as been set to uncompleted");
                    refresh = true;
                }
                popupok.ShowDialog();
                if (refresh == true)
                    reload();
            }
        }
    }
}
