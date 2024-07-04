namespace SporSalonuYönetimSistemi
{
    partial class Giriş
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            panel1 = new Panel();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUserName = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxPassword);
            panel1.Controls.Add(txtBoxUserName);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(750, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 363);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(157, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 58;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 245);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 57;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 200);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 56;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(147, 242);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(150, 23);
            txtBoxPassword.TabIndex = 55;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.BackColor = SystemColors.Window;
            txtBoxUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUserName.Location = new Point(147, 197);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(150, 23);
            txtBoxUserName.TabIndex = 54;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(197, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // Giriş
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(735, 437);
            Controls.Add(panel1);
            MinimizeBox = false;
            Name = "Giriş";
            Text = "Giriş";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUserName;
        private PictureBox pictureBox2;
    }
}