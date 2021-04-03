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
    public partial class FormMeet : Form
    {
        FormMain mainForm;
        int id; // id пациента для которого проводится прием
        Patient currentPatient;
        Doctor currentDoc;
        DateTime currentDate = DateTime.Now;

        public FormMeet(FormMain f, int id)
        {
            InitializeComponent();
            this.CenterToScreen();
            mainForm = f;
            this.id = id;
        }

        private void FormMeet_Load(object sender, EventArgs e)
        {
            // получение пациента из БД
            using (UserContext db = new UserContext())
            {
                // Поиск пациента в БД
                Human item = db.Users
                .Where(o => o.Id == id)
                .FirstOrDefault();
                currentPatient = (Patient)item;
            }

            if (currentPatient != null)
            {
                label_NameTitle.Text = "Запись для пациента: " + currentPatient.GetLastName() + " " + currentPatient.GetName();
                foreach (var doctor in mainForm.GetDoctors())
                {
                    comboBox_Doctors.Items.Add($"{doctor.GetLastName()} {doctor.GetName()} ({doctor.GetPosition()})");
                }

                // формируем периоды
                DateTime startDateMain;
                DateTime currentDate = DateTime.Now;
                int currentDay = (int)currentDate.DayOfWeek;
                if (currentDay == 0) // перевод из американской системы
                {
                    currentDay = 7;
                }
                currentDay--;

                startDateMain = currentDate.AddDays(-currentDay); // получили начало текущей недели

                for (int i = 0; i < 6; i++) // запись на ближайшие 6 недель
                {
                    comboBox_period.Items.Add(startDateMain.ToString("dd/MM/yyyy") + " - " + startDateMain.AddDays(6).ToString("dd/MM/yyyy"));
                    startDateMain = startDateMain.AddDays(7);
                }
            }
            else
            {
                MessageBox.Show(this, $"Пациент с id:{id} не найден", "Ошибка");
            }
            
        }

        // Обновляет список всей недели
        void UpdateAll(DateTime fromDate)
        {
            if (currentDoc != null)
            {
                flowLayoutPanel_1.Controls.Clear();
                flowLayoutPanel_2.Controls.Clear();
                flowLayoutPanel_3.Controls.Clear();
                flowLayoutPanel_4.Controls.Clear();
                flowLayoutPanel_5.Controls.Clear();

                CreateButtons(currentDoc, 0, flowLayoutPanel_1, fromDate);
                CreateButtons(currentDoc, 1, flowLayoutPanel_2, fromDate);
                CreateButtons(currentDoc, 2, flowLayoutPanel_3, fromDate);
                CreateButtons(currentDoc, 3, flowLayoutPanel_4, fromDate);
                CreateButtons(currentDoc, 4, flowLayoutPanel_5, fromDate);
            }
  
        }

        // Когда выбрали доктора из раскрывающегося списка
        private void comboBox_Doctors_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            string selectedDoctorStr = (string)comboBox.SelectedItem;
            // вычленяем из полученой строки фамилию (она идет первой)
            string[] dived = selectedDoctorStr.Split(' ');
            //label_NameTitle.Text = dived[0];

            List<Doctor> findedDoc = mainForm.SearchDoctor(dived[0]);

            if (findedDoc.Count == 0)
            {
                MessageBox.Show(this, $"Доктор с Фамилией:{dived[0]} не найден", "Ошибка");
                Close();
            }

            // Формируем расписание на неделю у выбранного доктора
            Doctor doc = findedDoc[0];
            currentDoc = doc;

            UpdateAll(currentDate); 
        }

        void CreateButtons(Doctor doc, int day, FlowLayoutPanel flp, DateTime fromDate)
        {
            DateTime startDate;
            DateTime startDateMain;
            DateTime currentDate = fromDate;
            int currentDay = (int)currentDate.DayOfWeek;
            if (currentDay == 0) // перевод из американской системы
            {
                currentDay = 7;
            }
            currentDay--;

            startDateMain = currentDate.AddDays(-currentDay);
            //MessageBox.Show(startDate.ToString());

            if (doc.GetSched()[day] == '0') // утро
            {
                startDate = new DateTime(startDateMain.Year, startDateMain.Month, startDateMain.Day, 8, 0, 0);
                startDate = startDate.AddDays(day);
            }
            else // вечер
            {
                startDate = new DateTime(startDateMain.Year, startDateMain.Month, startDateMain.Day, 14, 0, 0);
                startDate = startDate.AddDays(day);
            }

            for (int i = 1; i <= 12; i++)
            {
                Button b = new Button();
                b.Size = new Size(135, 90);

                if (startDate <= DateTime.Now || !doc.IsAvalible(startDate) || !VisitManager.Source.CheckDocAvalible(doc, startDate) || !VisitManager.Source.CheckPatAvalible(currentPatient, startDate))
                {
                    b.Enabled = false;
                }
                else
                {
                    DateTime newDate = startDate;
                    b.Click += new System.EventHandler((sender2, e2) => this.AddMeet_Handler(sender2, e2, doc, currentPatient, newDate));
                }

                b.Text = $"{startDate.Hour:00}:{startDate.Minute:00}";
                startDate = startDate.AddMinutes(30);
                b.Text += $" - {startDate.Hour:00}:{startDate.Minute:00}";

                flp.Controls.Add(b);
            }
        }

        // обрабатывает событие записи на прием
        void AddMeet_Handler(object sender, EventArgs e, Doctor doc, Patient pat, DateTime dateMeet)
        {
            Button button = (Button)sender;

            //MessageBox.Show(this, doc.GetName() + dateMeet.ToString(), "Результат");
            string result = VisitManager.Source.AddVisit(doc, pat, dateMeet);
            MessageBox.Show(this, result, "Результат");

            button.Enabled = false;

            mainForm.UpdateVisits();
        }

        // Выбор периода из раскрывашки
        private void comboBox_period_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            string selected = (string)comboBox.SelectedItem;
            string dateStartStr = selected.Split(' ')[0];
            //MessageBox.Show(dateStartStr);

            DateTime dateStart = DateTime.Parse(selected.Split(' ')[0]);
            currentDate = dateStart;

            // обновляем список доступных записей для текущей недели
            UpdateAll(dateStart);
        }
    }
}
