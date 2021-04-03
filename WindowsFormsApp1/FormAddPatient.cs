using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddPatient : Form
    {
        FormMain mainForm;

        public FormAddPatient(FormMain f)
        {
            InitializeComponent();
            this.CenterToScreen();
            mainForm = f;
        }

        // Реакция на нажатие кнопки добавить пациента
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool showErrors = true;

            // Добавляет запись в БД
            string name = textBox_Name.Text;
            if (showErrors && name == "")
            {
                MessageBox.Show(this, "Не введено имя", "Ошибка");
                return;
            }

            string lastName = textBox_LastName.Text;
            if (showErrors && lastName == "")
            {
                MessageBox.Show(this, "Не введена фамилия", "Ошибка");
                return;
            }

            int year = 0;
            if (showErrors && !int.TryParse(maskedTextBox_Year.Text, out year))
            {
                MessageBox.Show(this, "Не введен год рождения", "Ошибка");
                return;
            }

            int tel = 0;
            if (showErrors && !int.TryParse(maskedTextBox_Phone.Text, out tel))
            {
                MessageBox.Show(this, "Не введен номер телефона", "Ошибка");
                return;
            }

            string pol_s = comboBox_Sex.Text;
            if (showErrors && pol_s == "")
            {
                MessageBox.Show(this, "Не выбран пол", "Ошибка");
                return;
            }
            Pol pol = (Pol)Enum.Parse(typeof(Pol), pol_s.ToUpper());

            int polisNum = 0;
            if (showErrors && !int.TryParse(maskedTextBox_PolisNum.Text, out polisNum))
            {
                MessageBox.Show(this, "Не введен номер полиса", "Ошибка");
                return;
            }

            string diagnosis = textBox_Diagnosis.Text;


            mainForm.AddPatient(name, lastName, year, pol, tel, polisNum, diagnosis);

            this.Close();
        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
