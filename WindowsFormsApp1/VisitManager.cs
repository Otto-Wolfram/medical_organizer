using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public class Visit
    {
        public int Id { get; set; }

        public int doc_id { get; set; }
        public int pat_id { get; set; }
        public DateTime date { get; set; }

        public Visit() { }

        public Visit(Doctor doc, Patient pat, DateTime date)
        {
            this.doc_id = doc.Id;
            this.pat_id = pat.Id;
            this.date = date;
        }

        /*public void ShowInfo()
        {
            Console.WriteLine(">>> Информация о визите: ");
            Console.WriteLine("Доктор: " + doc.GetLastName());
            Console.WriteLine("Пациент: " + pat.GetLastName());
            Console.WriteLine("Дата и время: " + date.ToString());
            Console.WriteLine("<<<\n");
        }*/

        public int GetDoc()
        {
            return doc_id;
        }

        public int GetPat()
        {
            return pat_id;
        }

        public DateTime GetDate()
        {
            return date;
        }

        // Возвращает номер для недели. 1-понедельник, 2-...
        public int GetDayNum()
        {
            return (int)date.DayOfWeek;
        }
    }

    // занимается хранением и обработкой информации о визитах
    public class VisitManager
    {
        // Паттерн - Синглетон
        private VisitManager() { }

        private static VisitManager source = null;

        public static VisitManager Source
        {
            get
            {
                if (source == null)
                    source = new VisitManager();

                return source;
            }
        }

        public List<Visit> visits = new List<Visit>();

        // Добавление новой записи.
        // Правила: на 1 пациента врач выделяет по 30 минут
        // Нельзя принимать сразу несколько пациентов
        // Врач работает в определенные смены
        public string AddVisit(Doctor doc, Patient pat, DateTime date)
        {
            // проверка 1: работает ли врач в эту смену?
            if (doc.IsAvalible(date))
            {
                // Проверка 2: занят ли врач другим пациентом?
                if (CheckDocAvalible(doc, date))
                {
                    // Проверка 3: свободен ли пациент в это время?
                    if (CheckPatAvalible(pat, date))
                    {
                        using (UserContext db = new UserContext())
                        {
                            Visit tmp = new Visit(doc, pat, date);

                            db.Visits.Add(tmp);
                            db.SaveChanges();

                            visits.Add(tmp);
                        }

                        return $"Успешно. {pat.GetLastName()} записан на прием к {doc.GetLastName()} ({doc.GetPosition()}) на дату: {date.ToString()}.";
                    }
                }
                else
                {
                    return "Ошибка: в данное время уже ведется приём другого пациента";
                    //doc.ShowSched();
                }
            }
            else
            {
                return "Ошибка: врач не принимает в данные часы";
                //doc.GetAvalibleTime();
            }

            return "Ошибка: Невозможно провести запись";
        }

        // Проверяет, занят ли врач каким-либо пациентом в это время
        public bool CheckDocAvalible(Doctor doc, DateTime date)
        {
            foreach (Visit visit in visits)
            {
                if (visit.GetDoc() == doc.Id)
                {
                    if (date < visit.GetDate().AddMinutes(30) && date > visit.GetDate().AddMinutes(-30))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Проверяет, занят ли пациент в это время
        public bool CheckPatAvalible(Patient pat, DateTime date)
        {
            foreach (Visit visit in visits)
            {
                if (visit.GetPat() == pat.Id)
                {
                    if (date < visit.GetDate().AddMinutes(30) && date > visit.GetDate().AddMinutes(-30))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Получает список всех записей к данному врачу
        public List<Visit> GetVisitsList(Doctor doc)
        {
            List<Visit> newV = new List<Visit>();

            foreach (Visit visit in visits)
            {
                if (visit.GetDoc() == doc.Id)
                {
                    newV.Add(visit);
                }
            }

            return newV;
        }

        public List<Visit> GetVisitsList()
        {
            List<Visit> newV = new List<Visit>();

            foreach (Visit visit in visits)
            {
                
                newV.Add(visit);
                
            }

            return newV;
        }

        public void DeleteVisit(int id)
        {
            var itemToRemove2 = visits.SingleOrDefault(r => r.Id == id);
            if (itemToRemove2 != null)
            {
                visits.Remove(itemToRemove2);
            }
 
            using (UserContext db = new UserContext())
            {
                // Удаление из БД
                Visit what = db.Visits
                    .Where(o => o.Id == id)
                    .FirstOrDefault();

                db.Visits.Remove(what);
                db.SaveChanges();
            }
        }
    }
}
