namespace HOtellll
{
    partial class HotelForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label_guests = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.radioButton_zarezerv = new System.Windows.Forms.RadioButton();
            this.radioButton_svobodni = new System.Windows.Forms.RadioButton();
            this.radioButton_zanyat = new System.Windows.Forms.RadioButton();
            this.radioButton_vipiska = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.DataGridView_guests = new System.Windows.Forms.DataGridView();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cardButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.status_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_guests)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search.Location = new System.Drawing.Point(223, 3);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(764, 34);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.Click += new System.EventHandler(this.textBox_search_Click);
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            this.textBox_search.Enter += new System.EventHandler(this.textBox_search_Enter);
            this.textBox_search.Leave += new System.EventHandler(this.textBox_search_Leave);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_status.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(54, 16);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(85, 27);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Статус";
            this.label_status.Click += new System.EventHandler(this.label_status_Click);
            // 
            // label_guests
            // 
            this.label_guests.AutoSize = true;
            this.label_guests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_guests.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_guests.ForeColor = System.Drawing.Color.Red;
            this.label_guests.Location = new System.Drawing.Point(133, 16);
            this.label_guests.Name = "label_guests";
            this.label_guests.Size = new System.Drawing.Size(166, 27);
            this.label_guests.TabIndex = 3;
            this.label_guests.Text = "Список гостей";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_number.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number.ForeColor = System.Drawing.Color.Red;
            this.label_number.Location = new System.Drawing.Point(113, 16);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(113, 27);
            this.label_number.TabIndex = 4;
            this.label_number.Text = "Номер №";
            // 
            // radioButton_zarezerv
            // 
            this.radioButton_zarezerv.AutoSize = true;
            this.radioButton_zarezerv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_zarezerv.Location = new System.Drawing.Point(23, 63);
            this.radioButton_zarezerv.Name = "radioButton_zarezerv";
            this.radioButton_zarezerv.Size = new System.Drawing.Size(161, 24);
            this.radioButton_zarezerv.TabIndex = 5;
            this.radioButton_zarezerv.TabStop = true;
            this.radioButton_zarezerv.Text = "Зарезервировано";
            this.radioButton_zarezerv.UseVisualStyleBackColor = true;
            this.radioButton_zarezerv.CheckedChanged += new System.EventHandler(this.radioButton_zarezerv_CheckedChanged);
            // 
            // radioButton_svobodni
            // 
            this.radioButton_svobodni.AutoSize = true;
            this.radioButton_svobodni.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_svobodni.Location = new System.Drawing.Point(23, 103);
            this.radioButton_svobodni.Name = "radioButton_svobodni";
            this.radioButton_svobodni.Size = new System.Drawing.Size(116, 24);
            this.radioButton_svobodni.TabIndex = 6;
            this.radioButton_svobodni.TabStop = true;
            this.radioButton_svobodni.Text = "Свободные";
            this.radioButton_svobodni.UseVisualStyleBackColor = true;
            this.radioButton_svobodni.CheckedChanged += new System.EventHandler(this.radioButton_svobodni_CheckedChanged);
            // 
            // radioButton_zanyat
            // 
            this.radioButton_zanyat.AutoSize = true;
            this.radioButton_zanyat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_zanyat.Location = new System.Drawing.Point(23, 146);
            this.radioButton_zanyat.Name = "radioButton_zanyat";
            this.radioButton_zanyat.Size = new System.Drawing.Size(85, 24);
            this.radioButton_zanyat.TabIndex = 7;
            this.radioButton_zanyat.TabStop = true;
            this.radioButton_zanyat.Text = "Заняты";
            this.radioButton_zanyat.UseVisualStyleBackColor = true;
            this.radioButton_zanyat.CheckedChanged += new System.EventHandler(this.radioButton_zanyat_CheckedChanged);
            // 
            // radioButton_vipiska
            // 
            this.radioButton_vipiska.AutoSize = true;
            this.radioButton_vipiska.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_vipiska.Location = new System.Drawing.Point(23, 186);
            this.radioButton_vipiska.Name = "radioButton_vipiska";
            this.radioButton_vipiska.Size = new System.Drawing.Size(148, 24);
            this.radioButton_vipiska.TabIndex = 8;
            this.radioButton_vipiska.TabStop = true;
            this.radioButton_vipiska.Text = "Выписываются";
            this.radioButton_vipiska.UseVisualStyleBackColor = true;
            this.radioButton_vipiska.CheckedChanged += new System.EventHandler(this.radioButton_vipiska_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton_vipiska);
            this.panel1.Controls.Add(this.radioButton_zanyat);
            this.panel1.Controls.Add(this.radioButton_zarezerv);
            this.panel1.Controls.Add(this.radioButton_svobodni);
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 551);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Controls.Add(this.DataGridView_guests);
            this.panel2.Controls.Add(this.label_guests);
            this.panel2.Location = new System.Drawing.Point(223, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 551);
            this.panel2.TabIndex = 11;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(162, 357);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(113, 27);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Результат";
            // 
            // DataGridView_guests
            // 
            this.DataGridView_guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_guests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surname,
            this.name,
            this.fathername,
            this.status});
            this.DataGridView_guests.Location = new System.Drawing.Point(-1, 77);
            this.DataGridView_guests.Name = "DataGridView_guests";
            this.DataGridView_guests.RowHeadersWidth = 51;
            this.DataGridView_guests.RowTemplate.Height = 24;
            this.DataGridView_guests.Size = new System.Drawing.Size(499, 226);
            this.DataGridView_guests.TabIndex = 4;
            this.DataGridView_guests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_guests_CellContentClick);
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.surname.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // fathername
            // 
            this.fathername.HeaderText = "Отчество";
            this.fathername.MinimumWidth = 6;
            this.fathername.Name = "fathername";
            this.fathername.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cardButton);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textBox_fio);
            this.panel3.Controls.Add(this.status_textBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label_number);
            this.panel3.Location = new System.Drawing.Point(728, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 551);
            this.panel3.TabIndex = 12;
            // 
            // cardButton
            // 
            this.cardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardButton.Location = new System.Drawing.Point(303, 502);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(125, 44);
            this.cardButton.TabIndex = 11;
            this.cardButton.Text = "Просмотр карточки";
            this.cardButton.UseVisualStyleBackColor = true;
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(38, 434);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 58);
            this.panel5.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(1, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата выезда";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(38, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 58);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата заезда";
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(15, 297);
            this.textBox_fio.Multiline = true;
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(348, 47);
            this.textBox_fio.TabIndex = 8;
            this.textBox_fio.TextChanged += new System.EventHandler(this.textBox_fio_TextChanged);
            this.textBox_fio.Enter += new System.EventHandler(this.textBox_fio_Enter);
            this.textBox_fio.Leave += new System.EventHandler(this.textBox_fio_Leave);
            // 
            // status_textBox
            // 
            this.status_textBox.Location = new System.Drawing.Point(100, 239);
            this.status_textBox.Multiline = true;
            this.status_textBox.Name = "status_textBox";
            this.status_textBox.Size = new System.Drawing.Size(263, 34);
            this.status_textBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(6, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Статус";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(85, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 163);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(993, 3);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(83, 42);
            this.button_search.TabIndex = 13;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 616);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "HotelForm";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.HotelForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_guests)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_guests;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.RadioButton radioButton_zarezerv;
        private System.Windows.Forms.RadioButton radioButton_svobodni;
        private System.Windows.Forms.RadioButton radioButton_zanyat;
        private System.Windows.Forms.RadioButton radioButton_vipiska;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox status_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cardButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridView_guests;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label resultLabel;
    }
}

