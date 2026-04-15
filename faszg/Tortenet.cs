using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faszg
{
    public partial class Tortenet : Form
    {
        public Tortenet()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeSite Hsite = new HomeSite();
            this.Close();
        }

        private void történetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tortenet Tsite = new Tortenet();
            this.Close();
        }

        private void tanárokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bezárToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
