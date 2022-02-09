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
    public partial class Popupok : KryptonForm
    {
        private string message = null;

        public Popupok(string data)
        {
            InitializeComponent();

            message = data;

            build();
        }

        private void build()
        {
            if (message != null)
            {
                label_question.Text = message;
            }
        }

        private void button_no_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
