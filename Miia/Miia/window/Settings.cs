using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Settings(configuration.Configuration.Content herit_configuration)
        {
            InitializeComponent();

            configuration = herit_configuration;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            label_version.Text = configuration.version;
            textBox_root.Text = $"{configuration.root}";
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
    }
}
