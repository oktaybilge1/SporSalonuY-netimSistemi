namespace SporSalonuYönetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\bilge\OneDrive\Masaüstü\İKONLARIM\img3.jpg");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\bilge\OneDrive\Masaüstü\İKONLARIM\img2.jpg");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\bilge\OneDrive\Masaüstü\İKONLARIM\img3.jpg");
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniÜye nm = new yeniÜye();
            nm.Show();
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniPersonel ns = new yeniPersonel();
            ns.Show();
        }

        private void ekipmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekipmanlar eq = new Ekipmanlar();
            eq.Show();
        }

        private void üyeAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜyeArama sm = new ÜyeArama();
            sm.Show();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜyeSilme dm = new ÜyeSilme();
            dm.Show();
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

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapılıyor! Onaylıyor musunuz?", "ÇIKIŞ YAP", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Giriş lg = new Giriş();
                lg.Show();
            }
        }

        private void boksSalonuYönetimSistemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoksSalonu bs = new BoksSalonu();
            bs.Show();
        }

        private void pilatesSalonuYönetimSistemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PilatesSalonu ps = new PilatesSalonu();
            ps.Show();
        }
    }
}
