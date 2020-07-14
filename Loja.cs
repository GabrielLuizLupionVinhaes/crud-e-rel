using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroCRUD
{
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jogosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRUDJoog jog = new CRUDJoog();
            jog.Show();
        }

        private void plataformaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRUDPlataforma pla = new CRUDPlataforma();
            pla.Show();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plataformaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
