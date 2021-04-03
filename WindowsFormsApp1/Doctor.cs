using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public enum Position { ТЕРАПЕВТ, ЭНДОКРИНОЛОГ, ЛОР, ХИРУРГ, }

    // описывает врача больницы
    public class Doctor : Human
    {
        public Position position { get; set; }
        bool[] jobTime = new bool[5]; // false - с 8.00 до 13.00 или true - с14.00 до 18.00 с ПН по ПТ
        //Cabinet cabinet; // кабинет к которому врач привязан
        public string JobTime { get; set; }

        public Doctor() { }
        public Doctor(String name, String lastName, int age, Pol pol, long phone, Position position) :
            base(name, lastName, age, pol, phone)
        {
            this.position = position;
        }

        // Устанавливает расписание приема врача по сменам в дни недели
        public void SetSched(string sched)
        {
            JobTime = sched;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Специальность: {position}";
        }

        // Показывает время работы врача
        public string GetAvalibleTime()
        {
            StringBuilder sb = new StringBuilder(80);
            sb.Append($"Врач {name} {lastName} ({position}) принимает:\n");

            sb.Append("\nПонедельник:\n");
            if (JobTime[0] == '1') sb.Append("с 14.00 до 18.00");
            else sb.Append("с 8.00 до 13.00");

            sb.Append("\nВторник:\n");
            if (JobTime[1] == '1') sb.Append("с 14.00 до 18.00");
            else sb.Append("с 8.00 до 13.00");

            sb.Append("\nСреда:\n");
            if (JobTime[2] == '1') sb.Append("с 14.00 до 18.00");
            else sb.Append("с 8.00 до 13.00");

            sb.Append("\nЧетверг:\n");
            if (JobTime[3] == '1') sb.Append("с 14.00 до 18.00");
            else sb.Append("с 8.00 до 13.00");

            sb.Append("\nПятница:\n");
            if (JobTime[4] == '1') sb.Append("с 14.00 до 18.00");
            else sb.Append("с 8.00 до 13.00");

            return sb.ToString();
        }

        // принимает ли врач в данные часы
        public bool IsAvalible(DateTime date)
        {
            // не принимаем по выходным
            if ((int)date.DayOfWeek > 5)
            {
                return false;
            }

            if (JobTime[(int)date.DayOfWeek-1] == '1') // 14-18
            {
                if (date.Hour >= 14 && date.Hour < 18)
                {
                    return true;
                }
            }
            else // 8-13
            {
                if (date.Hour >= 8 && date.Hour < 13)
                {
                    return true;
                }
            }

            return false;
        }

        // Полное расписание врача с записанными пациентами
        /*
        public void ShowSched()
        {
            Console.WriteLine("\n>>> Расписание врача на неделю:");
            List<Visit> visitList = VisitManager.Source.GetVisitsList(this);

            for (int i = 1; i <= 5; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine((Days)(i - 1)); // Вывод названия дня недели
                Console.ResetColor();

                List<Visit> dayList = visitList.FindAll(r => r.GetDayNum() == i);

                if (dayList.Count != 0)
                {
                    foreach (Visit visit in dayList)
                    {
                        visit.ShowInfo();
                    }
                }
                else
                {
                    Console.WriteLine("Записей нет");
                }

                Console.WriteLine("================================\n");
            }
        }*/

        public Position GetPosition()
        {
            return position;
        }

        public string GetSched()
        {
            return JobTime;
        }
    }
}

