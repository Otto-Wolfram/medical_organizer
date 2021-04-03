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
    public partial class FormAddDoctor : Form
    {
        FormMain mainForm;

        public FormAddDoctor(FormMain f)
        {
            InitializeComponent();
            this.CenterToScreen();
            mainForm = f;
        }

        private void FormAddDoctor_Load(object sender, EventArgs e)
        {

        }

        // Реакция на нажатие кнопки добавить врача
        private void button1_Click(object sender, EventArgs e)
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
            
            string pos_s = comboBox_Position.Text;
            if (showErrors && pos_s == "")
            {
                MessageBox.Show(this, "Не выбрана специанльность", "Ошибка");
                return;
            }
            Position pos = (Position)Enum.Parse(typeof(Position), pos_s.ToUpper());

            string pol_s = comboBox_Sex.Text;
            if (showErrors && pol_s == "")
            {
                MessageBox.Show(this, "Не выбран пол", "Ошибка");
                return;
            }
            Pol pol = (Pol)Enum.Parse(typeof(Pol), pol_s.ToUpper());

            // расписание
            StringBuilder sched = new StringBuilder(5);
            var day1 = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (day1 != null)
            {
                if (day1.Name == "rb1_1")
                {
                    sched.Append('0');
                }
                else
                {
                    sched.Append('1');
                }
            }
            else
            {
                sched.Append('0');
            }
            var day2 = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (day2 != null)
            {
                if (day2.Name == "rb2_1")
                {
                    sched.Append('0');
                }
                else
                {
                    sched.Append('1');
                }
            }
            else
            {
                sched.Append('0');
            }
            var day3 = groupBox3.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (day3 != null)
            {
                if (day3.Name == "rb3_1")
                {
                    sched.Append('0');
                }
                else
                {
                    sched.Append('1');
                }
            }
            else
            {
                sched.Append('0');
            }
            var day4 = groupBox4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (day4 != null)
            {
                if (day4.Name == "rb4_1")
                {
                    sched.Append('0');
                }
                else
                {
                    sched.Append('1');
                }
            }
            else
            {
                sched.Append('0');
            }
            var day5 = groupBox5.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (day5 != null)
            {
                if (day5.Name == "rb5_1")
                {
                    sched.Append('0');
                }
                else
                {
                    sched.Append('1');
                }
            }
            else
            {
                sched.Append('0');
            }

            mainForm.AddDoctor(name, lastName, year, pol, tel, pos, sched.ToString());

            this.Close();
        }
    }
}
