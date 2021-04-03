namespace WindowsFormsApp1
{
    partial class FormAddDoctor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb1_2 = new System.Windows.Forms.RadioButton();
            this.rb1_1 = new System.Windows.Forms.RadioButton();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_Year = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Position = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb2_2 = new System.Windows.Forms.RadioButton();
            this.rb2_1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb3_1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rb4_1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rb5_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb1_2);
            this.groupBox1.Controls.Add(this.rb1_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Понедельник";
            // 
            // rb1_2
            // 
            this.rb1_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rb1_2.AutoSize = true;
            this.rb1_2.Location = new System.Drawing.Point(71, 32);
            this.rb1_2.Name = "rb1_2";
            this.rb1_2.Size = new System.Drawing.Size(70, 21);
            this.rb1_2.TabIndex = 2;
            this.rb1_2.TabStop = true;
            this.rb1_2.Text = "Вечер";
            this.rb1_2.UseVisualStyleBackColor = true;
            // 
            // rb1_1
            // 
            this.rb1_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb1_1.AutoSize = true;
            this.rb1_1.Location = new System.Drawing.Point(6, 32);
            this.rb1_1.Name = "rb1_1";
            this.rb1_1.Size = new System.Drawing.Size(61, 21);
            this.rb1_1.TabIndex = 1;
            this.rb1_1.TabStop = true;
            this.rb1_1.Text = "Утро";
            this.rb1_1.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(12, 42);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(380, 22);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.Text = "Иван";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(327, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_LastName
            // 
            this.label_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(424, 13);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(70, 17);
            this.label_LastName.TabIndex = 5;
            this.label_LastName.Text = "Фамилия";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LastName.Location = new System.Drawing.Point(427, 42);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(363, 22);
            this.textBox_LastName.TabIndex = 4;
            this.textBox_LastName.Text = "Иванов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Год рождения";
            // 
            // maskedTextBox_Year
            // 
            this.maskedTextBox_Year.Location = new System.Drawing.Point(12, 108);
            this.maskedTextBox_Year.Mask = "0000";
            this.maskedTextBox_Year.Name = "maskedTextBox_Year";
            this.maskedTextBox_Year.Size = new System.Drawing.Size(380, 22);
            this.maskedTextBox_Year.TabIndex = 8;
            this.maskedTextBox_Year.Text = "1990";
            this.maskedTextBox_Year.ValidatingType = typeof(int);
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Items.AddRange(new object[] {
            "Мужской\t",
            "Женский"});
            this.comboBox_Sex.Location = new System.Drawing.Point(427, 108);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(361, 24);
            this.comboBox_Sex.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пол";
            // 
            // maskedTextBox_Phone
            // 
            this.maskedTextBox_Phone.Location = new System.Drawing.Point(12, 180);
            this.maskedTextBox_Phone.Mask = "000000";
            this.maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            this.maskedTextBox_Phone.Size = new System.Drawing.Size(380, 22);
            this.maskedTextBox_Phone.TabIndex = 12;
            this.maskedTextBox_Phone.Text = "556677";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Специальность";
            // 
            // comboBox_Position
            // 
            this.comboBox_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Position.FormattingEnabled = true;
            this.comboBox_Position.Items.AddRange(new object[] {
            "Терапевт",
            "Эндокринолог",
            "ЛОР",
            "Хирург"});
            this.comboBox_Position.Location = new System.Drawing.Point(427, 180);
            this.comboBox_Position.Name = "comboBox_Position";
            this.comboBox_Position.Size = new System.Drawing.Size(361, 24);
            this.comboBox_Position.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb2_2);
            this.groupBox2.Controls.Add(this.rb2_1);
            this.groupBox2.Location = new System.Drawing.Point(165, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вторник";
            // 
            // rb2_2
            // 
            this.rb2_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rb2_2.AutoSize = true;
            this.rb2_2.Location = new System.Drawing.Point(73, 32);
            this.rb2_2.Name = "rb2_2";
            this.rb2_2.Size = new System.Drawing.Size(70, 21);
            this.rb2_2.TabIndex = 2;
            this.rb2_2.Text = "Вечер";
            this.rb2_2.UseVisualStyleBackColor = true;
            // 
            // rb2_1
            // 
            this.rb2_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb2_1.AutoSize = true;
            this.rb2_1.Location = new System.Drawing.Point(6, 32);
            this.rb2_1.Name = "rb2_1";
            this.rb2_1.Size = new System.Drawing.Size(61, 21);
            this.rb2_1.TabIndex = 1;
            this.rb2_1.Text = "Утро";
            this.rb2_1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.rb3_1);
            this.groupBox3.Location = new System.Drawing.Point(320, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 59);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Среда";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(69, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Вечер";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rb3_1
            // 
            this.rb3_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb3_1.AutoSize = true;
            this.rb3_1.Location = new System.Drawing.Point(6, 32);
            this.rb3_1.Name = "rb3_1";
            this.rb3_1.Size = new System.Drawing.Size(61, 21);
            this.rb3_1.TabIndex = 1;
            this.rb3_1.Text = "Утро";
            this.rb3_1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.rb4_1);
            this.groupBox4.Location = new System.Drawing.Point(471, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 59);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Четверг";
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(89, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Вечер";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rb4_1
            // 
            this.rb4_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb4_1.AutoSize = true;
            this.rb4_1.Location = new System.Drawing.Point(6, 32);
            this.rb4_1.Name = "rb4_1";
            this.rb4_1.Size = new System.Drawing.Size(61, 21);
            this.rb4_1.TabIndex = 1;
            this.rb4_1.Text = "Утро";
            this.rb4_1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton5);
            this.groupBox5.Controls.Add(this.rb5_1);
            this.groupBox5.Location = new System.Drawing.Point(642, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 59);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Пятница";
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(70, 32);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(70, 21);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Вечер";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rb5_1
            // 
            this.rb5_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb5_1.AutoSize = true;
            this.rb5_1.Location = new System.Drawing.Point(6, 32);
            this.rb5_1.Name = "rb5_1";
            this.rb5_1.Size = new System.Drawing.Size(61, 21);
            this.rb5_1.TabIndex = 1;
            this.rb5_1.Text = "Утро";
            this.rb5_1.UseVisualStyleBackColor = true;
            // 
            // FormAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Position);
            this.Controls.Add(this.maskedTextBox_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Sex);
            this.Controls.Add(this.maskedTextBox_Year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddDoctor";
            this.Text = "Добавление врача";
            this.Load += new System.EventHandler(this.FormAddDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Sex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Position;
        private System.Windows.Forms.RadioButton rb1_2;
        private System.Windows.Forms.RadioButton rb1_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb2_2;
        private System.Windows.Forms.RadioButton rb2_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rb3_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rb4_1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rb5_1;
    }
}