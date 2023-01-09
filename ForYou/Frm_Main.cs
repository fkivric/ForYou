using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForYou
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "tr_TR")
            {
                this.Text = "Foryou" + " --  TÜRKÇE";
            }
            else
            {
                this.Text = "Foryou" + " --  اللغة العربية";
            }
        }

        private void stokAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokAçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Stok stok = new frm_Stok();
            stok.MdiParent = this;
            stok.Show();
        }

        private void dilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            {
                case "tr-TR": Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-AR"); break;
                case "ar-AR": Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR"); break;
            }
            this.Controls.Clear();
            InitializeComponent();
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "tr_TR")
            {
                this.Text = "Foryou" + " --  TÜRKÇE"; 
            }
            else
            {
                this.Text = "Foryou" + " --  اللغة العربية";
            }

        }

        private void renkAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RenkTipi stok = new Frm_RenkTipi();
            stok.MdiParent = this;
            stok.Show();
        }

        private void bedenAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BedenTipi stok = new frm_BedenTipi();
            stok.MdiParent = this;
            stok.Show();
        }

        private void stokSınıfıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_StokSinifi stok = new frm_StokSinifi();
            stok.MdiParent = this;
            stok.Show();
        }
    }
}
