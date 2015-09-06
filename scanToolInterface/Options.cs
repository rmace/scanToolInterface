using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scanToolInterface
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectConfigFile_Click(object sender, EventArgs e)
        {
            DialogResult result = configFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtConfigFile.Text = configFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
