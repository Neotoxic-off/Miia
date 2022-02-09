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
    public partial class Settings : KryptonForm
    {
        public configuration.Configuration.Content configuration = null;

        private Popup popup = null;
        private Popupok popupok = new Popupok(null);

        BackgroundWorker worker_cleanner = new BackgroundWorker();

        public Settings(configuration.Configuration.Content herit_configuration)
        {
            InitializeComponent();
            InitializeWorker();

            configuration = herit_configuration;
        }

        private void InitializeWorker()
        {
            worker_cleanner.DoWork += new DoWorkEventHandler(cleanner);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            label_version.Text = configuration.version;
            textBox_root.Text = $"{configuration.root}";
            foreach (string extension in configuration.extensions)
                rich_extensions.AppendText($"{extension}\n");
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            DialogResult result = browse_root.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox_root.Text = browse_root.SelectedPath;
                configuration.root = browse_root.SelectedPath;
            }
        }

        private string get_name(string path)
        {
            string[] splitted = path.Split('\\');

            return (splitted[splitted.Length - 1]);
        }

        private string get_serie(string path)
        {
            string[] splitted = path.Split('\\');

            return (splitted[splitted.Length - 3]);
        }

        private string get_extension(string path)
        {
            string[] splitted = path.Split('.');

            return (splitted[splitted.Length - 1]);
        }

        private string get_previous_name(string path)
        {
            string[] splitted = path.Split('\\');

            return (splitted[splitted.Length - 2]);
        }

        private void cleanner(object sender, EventArgs e)
        {
            string[] files = null;
            string name = null;
            string cleanned = null;
            string replaced = null;
            Dictionary<string, int> id = new Dictionary<string, int>();
            Dictionary<string, string> renamed = new Dictionary<string, string>();

            if (textBox_root.Text != string.Empty)
            {
                if (Directory.Exists(textBox_root.Text) == true)
                {
                    files = Directory.GetFiles(textBox_root.Text, "*", SearchOption.AllDirectories);

                    foreach (string file in files)
                    {
                        name = get_name(file);
                        cleanned = file.Replace(name, string.Empty);
                        if (id.ContainsKey(cleanned) == false)
                        {
                            id.Add(cleanned, 1);
                        } 
                        if (extension_exists(name) == true)
                        {
                            replaced = $"{file.Replace(name, $"{id[cleanned]}.{get_extension(name)}")}";
                            if (renamed.ContainsKey($"{file}") == false && replaced != file && File.Exists(replaced) == false)
                            {
                                renamed.Add($"{file}", replaced);
                                id[cleanned]++;
                            }
                        }
                    }
                    popup = new Popup(renamed.Count);
                    popup.ShowDialog();

                    if (renamed.Count > 0)
                    {
                        if (popup.choice == true)
                        {
                            foreach (var file in renamed)
                            {
                                File.Move(file.Key, file.Value);
                            }
                            popupok.ShowDialog();
                        }
                    }
                }
            }
            button_cleanner.Enabled = false;
        }

        private bool extension_exists(string file)
        {
            foreach (string extension in configuration.extensions)
            {
                if (file.EndsWith($".{extension}") == true)
                    return (true);
            }

            return (false);
        }

        private void button_cleanner_Click(object sender, EventArgs e)
        {
            button_cleanner.Enabled = false;

            if (configuration.root != null)
            {
                if (Directory.Exists(configuration.root) == true)
                {
                    worker_cleanner.RunWorkerAsync();
                    while (worker_cleanner.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                }
            }
            button_cleanner.Enabled = true;
        }
    }
}
