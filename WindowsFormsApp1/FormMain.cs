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
    public enum Days { Понедельник, Вторник, Среда, Четверг, Пятница }

    public partial class FormMain : Form
    {
        static List<Doctor> doctors = new List<Doctor>();
        static List<Patient> patients = new List<Patient>();

        public FormMain()
        {
            InitializeComponent();
            this.CenterToScreen();
            //this.WindowState = FormWindowState.Maximized;
        }

        // Открывает окно с вводом данных о враче
        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new FormAddDoctor(this);
            newForm.ShowDialog();
        }

        // Открывает окно с вводом данных о новом пациенте
        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new FormAddPatient(this);
            newForm.ShowDialog();
        }

        // Обрабатывает событие удаления
        void Delete_Handler(object sender, EventArgs e, int id)
        {
            
            using (UserContext db = new UserContext())
            {
                // Удаление из БД
                Human what = db.Users
                .Where(o => o.Id == id)
                .FirstOrDefault();

                db.Users.Remove(what);
                db.SaveChanges();

                if (what is Doctor)
                {
                    UpdateDoctorsListPanel();
                }
                else
                {
                    UpdatePatientsListPanel();
                }
                

                var itemToRemove = doctors.SingleOrDefault(r => r.Id == id);
                if (itemToRemove != null)
                {
                    doctors.Remove(itemToRemove);

                }
                else
                {
                    var itemToRemove2 = patients.SingleOrDefault(r => r.Id == id);
                    if (itemToRemove2 != null)
                    {
                        patients.Remove(itemToRemove2);

                    }
                }
            }
        }

        void MeetDelete_Handler(object sender, EventArgs e, int id)
        {
            VisitManager.Source.DeleteVisit(id);
            UpdateVisits();
        }

        // Обрабатывает событие показа расписания
        void ShowSched_Handler(object sender, EventArgs e, int id)
        {
            MessageBox.Show(this, this.GetDoctorSched(id), "Информация о сменах");
        }

        // Обрабатывает событие кнопки "записаться на прием"
        void Meet_Handler(object sender, EventArgs e, int id)
        {
            var newForm = new FormMeet(this, id);
            newForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                var users = db.Users;
                foreach (Human u in users)
                {
                    if (u is Patient)
                    {
                        Patient tmp = new Patient(u.GetName(), u.GetLastName(), u.GetAge(), u.GetPol(), (int)u.GetPhone(), (u as Patient).GetPolis(), (u as Patient).GetDiagnos());
                        tmp.Id = u.Id;
                        patients.Add(tmp);
                    }
                    else
                    {
                        //bool[] sch1 = { false, false, true, true, false };
                        Doctor tmp = new Doctor(u.GetName(), u.GetLastName(), u.GetAge(), u.GetPol(), (int)u.GetPhone(), (u as Doctor).GetPosition());
                        tmp.SetSched((u as Doctor).GetSched());
                        tmp.Id = u.Id;

                        doctors.Add(tmp);
                    }
                }

                // загружаем визиты
                var visits = db.Visits.ToList();
                foreach (Visit v in visits)
                {
                    Human item1 = db.Users
                    .Where(o => o.Id == v.doc_id)
                    .FirstOrDefault();

                    Human item2 = db.Users
                    .Where(o => o.Id == v.pat_id)
                    .FirstOrDefault();

                    Visit vi = new Visit((Doctor)item1, (Patient)item2, v.GetDate());
                    VisitManager.Source.visits.Add(vi);
                    
                }

                UpdateVisits();
            }

            // ONLY FOR DEBUG
            /*AddPatient("Вася", "Пупкин", 2000, Pol.МУЖСКОЙ, 880044, 14555555, "");
            AddPatient("Вика", "Викина", 2001, Pol.ЖЕНСКИЙ, 111111, 22222222, "Ой");

            bool[] sch1 = { false, false, true, true, false };
            AddDoctor("Ася", "Асина", 2000, Pol.ЖЕНСКИЙ, 880044, Position.ТЕРАПЕВТ, sch1);

            bool[] sch2 = { false, true, true, true, false };
            AddDoctor("Виктор", "Викторов", 2000, Pol.МУЖСКОЙ, 880044, Position.ЛОР, sch2);*/

            UpdateVisits();
            UpdateDoctorsListPanel();
            UpdatePatientsListPanel();
        }

        // Добавляет в БД врача
        public void AddDoctor(string name, string lastName, int year, Pol pol, int tel, Position pos, string sched)
        {
            using (UserContext db = new UserContext())
            {
                Doctor tmp = new Doctor(name, lastName, year, pol, tel, pos);
                tmp.SetSched(sched);

                doctors.Add(tmp);
                db.Users.Add(tmp);
                db.SaveChanges();
            }
            UpdateDoctorsListPanel();
        }

        // Добавляет в БД пациента
        public void AddPatient(string name, string lastName, int year, Pol pol, int tel, long polisNum, string diagnosis)
        {
            using (UserContext db = new UserContext())
            {
                Patient tmp = new Patient(name, lastName, year, pol, tel, polisNum, diagnosis);
                
                patients.Add(tmp);
                db.Users.Add(tmp);
                db.SaveChanges();
            }

            UpdatePatientsListPanel();
        }

        // Обновляет список докторов
        void UpdateDoctorsListPanel(string search = "")
        {
            flowLayoutPanel_Doctors.Controls.Clear();

            // получение списка докторов из БД
            using (UserContext db = new UserContext())
            {
                var users = db.Users;
                foreach (Human doctor in users)
                {
                    if (doctor is Doctor)
                    {
                        // Если идет поиск, то отфильтровываем
                        if (search != "")
                        {
                            if (!doctor.GetLastName().StartsWith(search))
                            {
                                continue;
                            }
                        }

                        int id = doctor.Id;

                        Label tmp = new Label();
                        tmp.AutoSize = false;
                        tmp.Padding = new Padding(6);
                        tmp.Margin = new Padding(6);
                        //tmp.BackColor = Color.LightGray;
                        tmp.Text = doctor.GetInfo();
                        tmp.Width = 410;
                        tmp.Height = 120;

                        var flow = new TableLayoutPanel();
                        flow.AutoSize = true;
                        flow.Controls.Add(tmp, 0, 0);

                        Button b = new Button();
                        b.Text = "Раб. смены";
                        b.AutoSize = true;
                        b.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);

                        b.Click += new System.EventHandler((sender, e) => this.ShowSched_Handler(sender, e, id));
                        flow.Controls.Add(b, 1, 0);

                        Button b2 = new Button();
                        b2.Text = "Удалить";
                        b2.AutoSize = true;
                        b2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        b2.Click += new System.EventHandler((sender, e) => this.Delete_Handler(sender, e, id));
                        flow.Controls.Add(b2, 2, 0);

                        //tmp.Controls.Add(flow);

                        flowLayoutPanel_Doctors.Controls.Add(flow);
                    }
                }
            }

            /*
            foreach (Doctor doctor in doctors)
            {

                
            }
            */
        }

        // Обновляет список докторов
        void UpdatePatientsListPanel(string search = "")
        {
            flowLayoutPanel_Patients.Controls.Clear();
            // получение списка пациентов из БД
            using (UserContext db = new UserContext())
            {
                var users = db.Users;
                foreach (Human patient in users)
                {
                    if (patient is Patient)
                    {
                        // Если идет поиск, то отфильтровываем
                        if (search != "")
                        {
                            if (!patient.GetLastName().StartsWith(search))
                            {
                                continue;
                            }
                        }

                        int id = patient.Id;

                        Label tmp = new Label();
                        tmp.AutoSize = false;
                        tmp.Padding = new Padding(6);
                        tmp.Margin = new Padding(6);
                        //tmp.BackColor = Color.LightGray;
                        tmp.Text = patient.GetInfo();
                        tmp.Width = 410;
                        tmp.Height = 120;

                        var flow = new TableLayoutPanel();
                        flow.AutoSize = true;
                        flow.Controls.Add(tmp, 0, 0);

                        Button b = new Button();
                        b.Text = "Записать";
                        b.AutoSize = true;
                        b.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);

                        b.Click += new System.EventHandler((sender, e) => this.Meet_Handler(sender, e, id));
                        flow.Controls.Add(b, 1, 0);

                        Button b2 = new Button();
                        b2.Text = "Удалить";
                        b2.AutoSize = true;
                        b2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        b2.Click += new System.EventHandler((sender, e) => this.Delete_Handler(sender, e, id));
                        flow.Controls.Add(b2, 2, 0);

                        flowLayoutPanel_Patients.Controls.Add(flow);
                    }
                }
            }

            /*
            foreach (Patient patient in patients)
            {

                
            }
            */
        }

        string GetDoctorSched(int id)
        {
            // поиск доктора в БД по id
            using (UserContext db = new UserContext())
            {
                // Удаление из БД
                Human item = db.Users
                .Where(o => o.Id == id)
                .FirstOrDefault();

                if (item != null)
                {
                    return (item as Doctor).GetAvalibleTime();
                }
                else
                {
                    return $"Ошибка: Доктор с ID:{id} не найден";
                }
            }

            /*var item = doctors.SingleOrDefault(r => r.id == id);

            if (item != null)
            {
                return item.GetAvalibleTime();
            }
            else
            {
                return $"Ошибка: Доктор с ID:{id} не найден";
            }*/
        }

        public List<Doctor> GetDoctors()
        {
            return doctors;
        }

        public List<Patient> GetPatients()
        {
            return patients;
        }

        // поиск пациента по фио
        public List<Patient> SearchPatient(String lastName)
        {
            List<Patient> patientsList = patients.FindAll(r => r.GetLastName() == lastName);
            return patientsList;
        }

        // поиск доктора по фио
        public List<Doctor> SearchDoctor(String lastName)
        {
            List<Doctor> doctorsList = doctors.FindAll(r => r.GetLastName() == lastName);
            return doctorsList;
        }

        // Что-то вводят в поле поиска по фамилии доктора
        private void textBox_SearchDoc_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBox_SearchDoc.Text;

            UpdateDoctorsListPanel(currentText);
        }

        // Что-то вводят в поле поиска по фамилии пациента
        private void textBox_SearchPat_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBox_SearchPat.Text;

            UpdatePatientsListPanel(currentText);
        }

        public void UpdateVisits()
        {
            flowLayoutPanel_Visits.Controls.Clear();
            using (UserContext db = new UserContext())
            {
                var visits = db.Visits.ToList();
                foreach (Visit visit in visits)
                {

                    Human item1 = db.Users
                    .Where(o => o.Id == visit.pat_id)
                    .FirstOrDefault();
                    item1 = (Patient)item1;

                    Human item2 = db.Users
                    .Where(o => o.Id == visit.doc_id)
                    .FirstOrDefault();
                    item2 = (Doctor)item2;

                    Label tmp = new Label();
                    tmp.AutoSize = false;
                    tmp.Padding = new Padding(6);
                    tmp.Margin = new Padding(6);
                    //tmp.BackColor = Color.LightGray;
                    tmp.Text = "Доктор: " + item2.GetLastName() + " " + item2.GetName() + " (" + (item2 as Doctor).GetPosition() + ")\n";
                    tmp.Text += "Пациент: " + item1.GetLastName() + " " + item1.GetName() + "\n";
                    tmp.Text += "Дата приема: " + visit.GetDate().ToString();
                    tmp.Width = 410;
                    tmp.Height = 60;

                    var flow = new TableLayoutPanel();
                    flow.AutoSize = true;
                    flow.Controls.Add(tmp, 0, 0);

                    Button b = new Button();
                    b.Text = "Отменить запись";
                    b.AutoSize = true;
                    b.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);

                    b.Click += new System.EventHandler((sender, e) => this.MeetDelete_Handler(sender, e, visit.Id));
                    flow.Controls.Add(b, 1, 0);

                    flowLayoutPanel_Visits.Controls.Add(flow);
                }
            }

            foreach (Visit visit in VisitManager.Source.GetVisitsList())
            {
                
            }
        }
    }
}
