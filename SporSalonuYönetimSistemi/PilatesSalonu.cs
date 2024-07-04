using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuYönetimSistemi
{
    public partial class PilatesSalonu : Form
    {
        public PilatesSalonu()
        {
            InitializeComponent();
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniEğitmen ye = new YeniEğitmen();
            ye.Show();
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pilatesYeniÜye pyü = new pilatesYeniÜye();
            pyü.Show();
        }

        private void üyeAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pilatesÜyeAra püa = new pilatesÜyeAra();
            püa.Show();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pilatesÜyeSil püs = new pilatesÜyeSil();
            püs.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EğitmenAra ea = new EğitmenAra();
            ea.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EğitmenSil es = new EğitmenSil();
            es.Show();
        }

        private void topluDersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PilatesDersSaatleri pds = new PilatesDersSaatleri();
            pds.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama kapanacak. Onaylıyor musunuz?", "KAPAT", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Tekrar Hoşgeldiniz", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PilatesSalonu_Load(object sender, EventArgs e)
        {

        }
    }
}
