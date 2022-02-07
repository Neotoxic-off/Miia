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
        private window.Settings window_settings = null;
        private events.Events events = new events.Events(view_content);

        private BackgroundWorker worker_loader = new BackgroundWorker();
        private BackgroundWorker worker_builder = new BackgroundWorker();
        private BackgroundWorker worker_saver = new BackgroundWorker();

        public Miia()
        {
            InitializeComponent();
            InitializeWorker();
        }

        private void InitializeWorker()
        {
            worker_loader.DoWork += new DoWorkEventHandler(events.loader);
            worker_saver.DoWork += new DoWorkEventHandler(events.saver);
            worker_builder.DoWork += new DoWorkEventHandler(events.builder);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_settings_Click(object sender, EventArgs e)
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
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            worker_builder.RunWorkerAsync();

            while (worker_builder.IsBusy == true)
            {
                Application.DoEvents();
            }
        }
    }
}
