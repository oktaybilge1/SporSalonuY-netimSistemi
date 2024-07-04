namespace SporSalonuYönetimSistemi
{
    partial class Ekipmanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekipmanlar));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEquipName = new TextBox();
            textBox2 = new TextBox();
            txtMusclesUsed = new TextBox();
            dateTimePickerDeliveryDate = new DateTimePicker();
            txtCost = new TextBox();
            txtDescription = new RichTextBox();
            btnSave = new Button();
            btnReset = new Button();
            btnViewEq = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 95);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Ekipman İsmi";
            // 
            // label2
            // 
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 139);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 1;
            label2.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 293);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 2;
            label3.Text = "Çalışan Kaslar";
            // 
            // label4
            // 
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(48, 338);
            label4.Name = "label4";
            label4.Size = new Size(115, 27);
            label4.TabIndex = 3;
            label4.Text = "Teslim Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(95, 386);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Maliyet";
            label5.Click += label5_Click;
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(186, 93);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(200, 23);
            txtEquipName.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // txtMusclesUsed
            // 
            txtMusclesUsed.Location = new Point(186, 291);
            txtMusclesUsed.Name = "txtMusclesUsed";
            txtMusclesUsed.Size = new Size(200, 23);
            txtMusclesUsed.TabIndex = 7;
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDeliveryDate.Location = new Point(186, 334);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(200, 23);
            dateTimePickerDeliveryDate.TabIndex = 8;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(186, 384);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(100, 23);
            txtCost.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(186, 139);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(241, 117);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(192, 435);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(286, 435);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 12;
            btnReset.Text = "Sıfırla";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnViewEq
            // 
            btnViewEq.Location = new Point(380, 435);
            btnViewEq.Name = "btnViewEq";
            btnViewEq.Size = new Size(75, 23);
            btnViewEq.TabIndex = 13;
            btnViewEq.Text = "Ekipmanlar";
            btnViewEq.UseVisualStyleBackColor = true;
            btnViewEq.Click += btnViewEq_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(372, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // Ekipmanlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(632, 492);
            Controls.Add(btnViewEq);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtCost);
            Controls.Add(dateTimePickerDeliveryDate);
            Controls.Add(txtMusclesUsed);
            Controls.Add(textBox2);
            Controls.Add(txtEquipName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Ekipmanlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ekipmanlar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEquipName;
        private TextBox textBox2;
        private TextBox txtMusclesUsed;
        private DateTimePicker dateTimePickerDeliveryDate;
        private TextBox txtCost;
        private RichTextBox txtDescription;
        private Button btnSave;
        private Button btnReset;
        private Button btnViewEq;
        private PictureBox pictureBox1;
    }
}