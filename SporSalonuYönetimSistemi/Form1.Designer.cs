namespace SporSalonuYönetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            yeniÜyeToolStripMenuItem = new ToolStripMenuItem();
            yToolStripMenuItem = new ToolStripMenuItem();
            yeniPersonelToolStripMenuItem = new ToolStripMenuItem();
            ekipmanlarToolStripMenuItem = new ToolStripMenuItem();
            üyeAraToolStripMenuItem = new ToolStripMenuItem();
            üyeSilToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            kapatToolStripMenuItem = new ToolStripMenuItem();
            boksSalonuYönetimSistemiToolStripMenuItem = new ToolStripMenuItem();
            pilatesSalonuYönetimSistemiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, yToolStripMenuItem, yeniPersonelToolStripMenuItem, ekipmanlarToolStripMenuItem, üyeAraToolStripMenuItem, üyeSilToolStripMenuItem, boksSalonuYönetimSistemiToolStripMenuItem, pilatesSalonuYönetimSistemiToolStripMenuItem, çıkışYapToolStripMenuItem, kapatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1112, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.Transparent;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { yeniÜyeToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 54);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // yeniÜyeToolStripMenuItem
            // 
            yeniÜyeToolStripMenuItem.Name = "yeniÜyeToolStripMenuItem";
            yeniÜyeToolStripMenuItem.Size = new Size(122, 22);
            yeniÜyeToolStripMenuItem.Text = "Yeni Üye ";
            // 
            // yToolStripMenuItem
            // 
            yToolStripMenuItem.Image = (Image)resources.GetObject("yToolStripMenuItem.Image");
            yToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            yToolStripMenuItem.Name = "yToolStripMenuItem";
            yToolStripMenuItem.Size = new Size(112, 54);
            yToolStripMenuItem.Text = "Yeni Üye";
            yToolStripMenuItem.Click += yToolStripMenuItem_Click;
            // 
            // yeniPersonelToolStripMenuItem
            // 
            yeniPersonelToolStripMenuItem.Image = (Image)resources.GetObject("yeniPersonelToolStripMenuItem.Image");
            yeniPersonelToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            yeniPersonelToolStripMenuItem.Name = "yeniPersonelToolStripMenuItem";
            yeniPersonelToolStripMenuItem.Size = new Size(139, 54);
            yeniPersonelToolStripMenuItem.Text = "Yeni Personel";
            yeniPersonelToolStripMenuItem.Click += yeniPersonelToolStripMenuItem_Click;
            // 
            // ekipmanlarToolStripMenuItem
            // 
            ekipmanlarToolStripMenuItem.Image = (Image)resources.GetObject("ekipmanlarToolStripMenuItem.Image");
            ekipmanlarToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ekipmanlarToolStripMenuItem.Name = "ekipmanlarToolStripMenuItem";
            ekipmanlarToolStripMenuItem.Size = new Size(128, 54);
            ekipmanlarToolStripMenuItem.Text = "Ekipmanlar";
            ekipmanlarToolStripMenuItem.Click += ekipmanlarToolStripMenuItem_Click;
            // 
            // üyeAraToolStripMenuItem
            // 
            üyeAraToolStripMenuItem.Image = (Image)resources.GetObject("üyeAraToolStripMenuItem.Image");
            üyeAraToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            üyeAraToolStripMenuItem.Name = "üyeAraToolStripMenuItem";
            üyeAraToolStripMenuItem.Size = new Size(108, 54);
            üyeAraToolStripMenuItem.Text = "Üye Ara";
            üyeAraToolStripMenuItem.Click += üyeAraToolStripMenuItem_Click;
            // 
            // üyeSilToolStripMenuItem
            // 
            üyeSilToolStripMenuItem.Image = (Image)resources.GetObject("üyeSilToolStripMenuItem.Image");
            üyeSilToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            üyeSilToolStripMenuItem.Name = "üyeSilToolStripMenuItem";
            üyeSilToolStripMenuItem.Size = new Size(102, 54);
            üyeSilToolStripMenuItem.Text = "Üye Sil";
            üyeSilToolStripMenuItem.Click += üyeSilToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Image = (Image)resources.GetObject("çıkışYapToolStripMenuItem.Image");
            çıkışYapToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(116, 54);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // kapatToolStripMenuItem
            // 
            kapatToolStripMenuItem.Image = (Image)resources.GetObject("kapatToolStripMenuItem.Image");
            kapatToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            kapatToolStripMenuItem.Size = new Size(74, 54);
            kapatToolStripMenuItem.Text = "Kapat";
            kapatToolStripMenuItem.Click += kapatToolStripMenuItem_Click;
            // 
            // boksSalonuYönetimSistemiToolStripMenuItem
            // 
            boksSalonuYönetimSistemiToolStripMenuItem.Image = (Image)resources.GetObject("boksSalonuYönetimSistemiToolStripMenuItem.Image");
            boksSalonuYönetimSistemiToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            boksSalonuYönetimSistemiToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            boksSalonuYönetimSistemiToolStripMenuItem.Name = "boksSalonuYönetimSistemiToolStripMenuItem";
            boksSalonuYönetimSistemiToolStripMenuItem.Size = new Size(113, 54);
            boksSalonuYönetimSistemiToolStripMenuItem.Text = "Boks Salonu";
            boksSalonuYönetimSistemiToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            boksSalonuYönetimSistemiToolStripMenuItem.Click += boksSalonuYönetimSistemiToolStripMenuItem_Click;
            // 
            // pilatesSalonuYönetimSistemiToolStripMenuItem
            // 
            pilatesSalonuYönetimSistemiToolStripMenuItem.Image = (Image)resources.GetObject("pilatesSalonuYönetimSistemiToolStripMenuItem.Image");
            pilatesSalonuYönetimSistemiToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            pilatesSalonuYönetimSistemiToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            pilatesSalonuYönetimSistemiToolStripMenuItem.Name = "pilatesSalonuYönetimSistemiToolStripMenuItem";
            pilatesSalonuYönetimSistemiToolStripMenuItem.Size = new Size(122, 54);
            pilatesSalonuYönetimSistemiToolStripMenuItem.Text = "Pilates Salonu";
            pilatesSalonuYönetimSistemiToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            pilatesSalonuYönetimSistemiToolStripMenuItem.Click += pilatesSalonuYönetimSistemiToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1112, 540);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem yeniÜyeToolStripMenuItem;
        private ToolStripMenuItem yToolStripMenuItem;
        private ToolStripMenuItem yeniPersonelToolStripMenuItem;
        private ToolStripMenuItem ekipmanlarToolStripMenuItem;
        private ToolStripMenuItem üyeAraToolStripMenuItem;
        private ToolStripMenuItem üyeSilToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem kapatToolStripMenuItem;
        private ToolStripMenuItem boksSalonuYönetimSistemiToolStripMenuItem;
        private ToolStripMenuItem pilatesSalonuYönetimSistemiToolStripMenuItem;
    }
}
