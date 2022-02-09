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
    public partial class Popup : KryptonForm
    {
        public bool choice = false;

        private int content = 0;

        private BackgroundWorker worker_builder = new BackgroundWorker();

        public Popup(int renamed)
        {
            InitializeComponent();

            content = renamed;

            build();
        }

        private void build()
        {
            label_question.Text = $"{content} file will be renamed, do you want to continue ?";
        }

        private void button_yes_Click(object sender, System.EventArgs e)
        {
            choice = true;

            Close();
        }

        private void button_no_Click(object sender, System.EventArgs e)
        {
            choice = false;

            Close();
        }
    }
}
