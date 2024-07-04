namespace SporSalonuYönetimSistemi
{
    partial class yeniÜye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeniÜye));
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePickerDOB = new DateTimePicker();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            dateTimePickerJoinDate = new DateTimePicker();
            txtAddress = new RichTextBox();
            comboBoxMembership = new ComboBox();
            comboBoxGymTime = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(155, 152);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(114, 25);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(155, 198);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(114, 25);
            txtLastName.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(155, 246);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 21);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(240, 246);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 21);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(155, 288);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(114, 25);
            dateTimePickerDOB.TabIndex = 4;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(155, 340);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(114, 25);
            txtMobile.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(489, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 25);
            txtEmail.TabIndex = 6;
            // 
            // dateTimePickerJoinDate
            // 
            dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJoinDate.Location = new Point(489, 196);
            dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            dateTimePickerJoinDate.Size = new Size(114, 25);
            dateTimePickerJoinDate.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(489, 307);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(197, 131);
            txtAddress.TabIndex = 9;
            txtAddress.Text = "";
            // 
            // comboBoxMembership
            // 
            comboBoxMembership.FormattingEnabled = true;
            comboBoxMembership.Items.AddRange(new object[] { "1 Ay", "2 Ay", "3 Ay", "6 Ay", "12 Ay" });
            comboBoxMembership.Location = new Point(299, 463);
            comboBoxMembership.Name = "comboBoxMembership";
            comboBoxMembership.Size = new Size(138, 25);
            comboBoxMembership.TabIndex = 10;
            // 
            // comboBoxGymTime
            // 
            comboBoxGymTime.FormattingEnabled = true;
            comboBoxGymTime.Items.AddRange(new object[] { "08:00-09:00", "10:00-11:00", "13:00-14:00", "15:00-16:00", "17:00-18:00" });
            comboBoxGymTime.Location = new Point(489, 248);
            comboBoxGymTime.Name = "comboBoxGymTime";
            comboBoxGymTime.Size = new Size(138, 25);
            comboBoxGymTime.TabIndex = 11;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(83, 156);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 12;
            label1.Text = "Ad";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(67, 204);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 13;
            label2.Text = "Soyad";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(57, 246);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 14;
            label3.Text = "Cinsiyet";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(27, 288);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 15;
            label4.Text = "Doğum Tarihi";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(67, 344);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 16;
            label5.Text = "Telefon";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(396, 152);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 17;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(352, 198);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 18;
            label7.Text = "Katılma Tarihi";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(334, 246);
            label8.Name = "label8";
            label8.Size = new Size(141, 27);
            label8.TabIndex = 19;
            label8.Text = "Antrenman Vakti";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(400, 307);
            label9.Name = "label9";
            label9.Size = new Size(75, 37);
            label9.TabIndex = 20;
            label9.Text = "Adres";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(246, 508);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 38);
            btnSave.TabIndex = 21;
            btnSave.Text = "Kaydet";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(351, 508);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(83, 38);
            btnReset.TabIndex = 22;
            btnReset.Text = "Sıfırla";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(162, 458);
            label10.Name = "label10";
            label10.Size = new Size(131, 33);
            label10.TabIndex = 23;
            label10.Text = "Üyelik Süresi";
            label10.TextAlign = ContentAlignment.MiddleRight;
            label10.Click += label10_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(201, -25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 265);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // yeniÜye
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(722, 558);
            Controls.Add(label10);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxGymTime);
            Controls.Add(comboBoxMembership);
            Controls.Add(txtAddress);
            Controls.Add(dateTimePickerJoinDate);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "yeniÜye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "yeniÜye";
            Load += yeniÜye_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePickerDOB;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private DateTimePicker dateTimePickerJoinDate;
        private RichTextBox txtAddress;
        private ComboBox comboBoxMembership;
        private ComboBox comboBoxGymTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSave;
        private Button btnReset;
        private Label label10;
        private PictureBox pictureBox2;
    }
}