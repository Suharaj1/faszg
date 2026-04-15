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
    public partial class HomeSite : Form
    {
        public HomeSite()
        {
            InitializeComponent();
        }

        private void bezárToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void történetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tortenet tSite = new Tortenet();
            this.Close();

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeSite HSIte = new HomeSite();
            this.Close();
        }

        private void tanárokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
