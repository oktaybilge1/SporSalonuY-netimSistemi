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
    public partial class BoksSalonu : Form
    {
        public BoksSalonu()
        {
            InitializeComponent();
        }

        private void BoksSalonu_Load(object sender, EventArgs e)
        {

        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniAntrenör ya = new YeniAntrenör();
            ya.Show();

        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boksYeniüye byü = new boksYeniüye();
            byü.Show();
        }

        private void üyeAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boksÜyeAra büa = new boksÜyeAra();
            büa.Show();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boksÜyeSil büs = new boksÜyeSil();
            büs.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AntrenörAra aa = new AntrenörAra();
            aa.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AntrenörSil ass = new AntrenörSil();
            ass.Show();
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

        private void topluDersSaatleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoksDersSaatleri bds = new BoksDersSaatleri();
            bds.Show();
        }
    }
}
