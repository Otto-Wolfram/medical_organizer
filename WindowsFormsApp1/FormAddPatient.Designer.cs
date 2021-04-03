namespace WindowsFormsApp1
{
    partial class FormAddPatient
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
            this.maskedTextBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_Year = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.maskedTextBox_PolisNum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Diagnosis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox_Phone
            // 
            this.maskedTextBox_Phone.Location = new System.Drawing.Point(11, 187);
            this.maskedTextBox_Phone.Mask = "000000";
            this.maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            this.maskedTextBox_Phone.Size = new System.Drawing.Size(380, 22);
            this.maskedTextBox_Phone.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Пол";
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Items.AddRange(new object[] {
            "Мужской\t",
            "Женский"});
            this.comboBox_Sex.Location = new System.Drawing.Point(426, 115);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(361, 24);
            this.comboBox_Sex.TabIndex = 19;
            // 
            // maskedTextBox_Year
            // 
            this.maskedTextBox_Year.Location = new System.Drawing.Point(11, 115);
            this.maskedTextBox_Year.Mask = "0000";
            this.maskedTextBox_Year.Name = "maskedTextBox_Year";
            this.maskedTextBox_Year.Size = new System.Drawing.Size(380, 22);
            this.maskedTextBox_Year.TabIndex = 18;
            this.maskedTextBox_Year.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Год рождения";
            // 
            // label_LastName
            // 
            this.label_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(423, 20);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(70, 17);
            this.label_LastName.TabIndex = 16;
            this.label_LastName.Text = "Фамилия";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LastName.Location = new System.Drawing.Point(426, 49);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(363, 22);
            this.textBox_LastName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(11, 49);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(380, 22);
            this.textBox_Name.TabIndex = 13;
            // 
            // maskedTextBox_PolisNum
            // 
            this.maskedTextBox_PolisNum.Location = new System.Drawing.Point(424, 187);
            this.maskedTextBox_PolisNum.Mask = "000000000";
            this.maskedTextBox_PolisNum.Name = "maskedTextBox_PolisNum";
            this.maskedTextBox_PolisNum.Size = new System.Drawing.Size(365, 22);
            this.maskedTextBox_PolisNum.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Номер полиса";
            // 
            // textBox_Diagnosis
            // 
            this.textBox_Diagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Diagnosis.Location = new System.Drawing.Point(7, 296);
            this.textBox_Diagnosis.Multiline = true;
            this.textBox_Diagnosis.Name = "textBox_Diagnosis";
            this.textBox_Diagnosis.Size = new System.Drawing.Size(778, 135);
            this.textBox_Diagnosis.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Предварительный диагноз (не обязательно)";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(315, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Diagnosis);
            this.Controls.Add(this.maskedTextBox_PolisNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Sex);
            this.Controls.Add(this.maskedTextBox_Year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.DoubleBuffered = true;
            this.Name = "FormAddPatient";
            this.Text = "Добавление пациента";
            this.Load += new System.EventHandler(this.FormAddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Sex;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PolisNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Diagnosis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}