namespace HOtellll
{
    partial class GuestCardForm
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
            this.label_guestCard = new System.Windows.Forms.Label();
            this.fioTextbox = new System.Windows.Forms.TextBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.salaryComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_guestCard
            // 
            this.label_guestCard.AutoSize = true;
            this.label_guestCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_guestCard.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_guestCard.ForeColor = System.Drawing.Color.Red;
            this.label_guestCard.Location = new System.Drawing.Point(167, 49);
            this.label_guestCard.Name = "label_guestCard";
            this.label_guestCard.Size = new System.Drawing.Size(196, 35);
            this.label_guestCard.TabIndex = 0;
            this.label_guestCard.Text = "Карточка гостя";
            // 
            // fioTextbox
            // 
            this.fioTextbox.Location = new System.Drawing.Point(128, 140);
            this.fioTextbox.Multiline = true;
            this.fioTextbox.Name = "fioTextbox";
            this.fioTextbox.Size = new System.Drawing.Size(266, 45);
            this.fioTextbox.TabIndex = 1;
            this.fioTextbox.MouseEnter += new System.EventHandler(this.fioTextbox_MouseEnter);
            this.fioTextbox.MouseLeave += new System.EventHandler(this.fioTextbox_MouseLeave);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(128, 214);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(266, 37);
            this.dataTextBox.TabIndex = 2;
            this.dataTextBox.MouseEnter += new System.EventHandler(this.dataTextBox_MouseEnter);
            this.dataTextBox.MouseLeave += new System.EventHandler(this.dataTextBox_MouseLeave);
            // 
            // salaryComboBox
            // 
            this.salaryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryComboBox.FormattingEnabled = true;
            this.salaryComboBox.Items.AddRange(new object[] {
            "1000",
            "7000",
            "28000",
            "56000",
            "112000"});
            this.salaryComboBox.Location = new System.Drawing.Point(296, 340);
            this.salaryComboBox.Name = "salaryComboBox";
            this.salaryComboBox.Size = new System.Drawing.Size(25, 24);
            this.salaryComboBox.TabIndex = 4;
            this.salaryComboBox.SelectedIndexChanged += new System.EventHandler(this.salaryComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(189, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оплата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(292, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество дней";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(128, 495);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(260, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Путешествую с животными";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // GuestCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 680);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.salaryComboBox);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.fioTextbox);
            this.Controls.Add(this.label_guestCard);
            this.Name = "GuestCardForm";
            this.Text = "Карточка гостя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_guestCard;
        private System.Windows.Forms.TextBox fioTextbox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.ComboBox salaryComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}