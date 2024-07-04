namespace SporSalonuYönetimSistemi
{
    partial class yeniPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeniPersonel));
            btnReset = new Button();
            btnSave = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerJOINDate = new DateTimePicker();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtLname = new TextBox();
            txtFname = new TextBox();
            label8 = new Label();
            txtState = new TextBox();
            txtCity = new TextBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(322, 446);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(83, 38);
            btnReset.TabIndex = 46;
            btnReset.Text = "Sıfırla";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(217, 446);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 38);
            btnSave.TabIndex = 45;
            btnSave.Text = "Kaydet";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(339, 227);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 42;
            label7.Text = "Katılma Tarihi";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(383, 184);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 41;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleRight;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(69, 373);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 40;
            label5.Text = "Telefon";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(29, 317);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 39;
            label4.Text = "Doğum Tarihi";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(59, 275);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 38;
            label3.Text = "Cinsiyet";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(69, 231);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 37;
            label2.Text = "Soyad";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(85, 185);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 36;
            label1.Text = "Ad";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerJOINDate
            // 
            dateTimePickerJOINDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJOINDate.Location = new Point(476, 225);
            dateTimePickerJOINDate.Name = "dateTimePickerJOINDate";
            dateTimePickerJOINDate.Size = new Size(114, 23);
            dateTimePickerJOINDate.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(476, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 23);
            txtEmail.TabIndex = 31;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(157, 369);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(114, 23);
            txtMobile.TabIndex = 30;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(157, 317);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(114, 23);
            dateTimePickerDOB.TabIndex = 29;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(242, 275);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 19);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(157, 275);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(157, 227);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(114, 23);
            txtLname.TabIndex = 26;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(157, 185);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(114, 23);
            txtFname.TabIndex = 25;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(373, 284);
            label8.Name = "label8";
            label8.Size = new Size(85, 22);
            label8.TabIndex = 47;
            label8.Text = "Durum";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtState
            // 
            txtState.Location = new Point(476, 283);
            txtState.Name = "txtState";
            txtState.Size = new Size(114, 23);
            txtState.TabIndex = 48;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(476, 333);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(114, 23);
            txtCity.TabIndex = 49;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(383, 334);
            label9.Name = "label9";
            label9.Size = new Size(75, 22);
            label9.TabIndex = 50;
            label9.Text = "Şehir";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // yeniPersonel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(632, 492);
            Controls.Add(label9);
            Controls.Add(txtCity);
            Controls.Add(txtState);
            Controls.Add(label8);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerJOINDate);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "yeniPersonel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "yeniPersonel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReset;
        private Button btnSave;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerJOINDate;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private DateTimePicker dateTimePickerDOB;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtLname;
        private TextBox txtFname;
        private Label label8;
        private TextBox txtState;
        private TextBox txtCity;
        private Label label9;
        private PictureBox pictureBox1;
    }
}