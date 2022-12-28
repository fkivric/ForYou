using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForYou
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void stokAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokAçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Stok stok = new Frm_Stok();
            stok.MdiParent = this;
            stok.Show();
        }

        private void dilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renkAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RenkTipi stok = new Frm_RenkTipi();
            stok.MdiParent = this;
            stok.Show();
        }

        private void bedenAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BedenTipi stok = new Frm_BedenTipi();
            stok.MdiParent = this;
            stok.Show();
        }

        private void stokSınıfıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_StokSinifi stok = new Frm_StokSinifi();
            stok.MdiParent = this;
            stok.Show();
        }
    }
}
