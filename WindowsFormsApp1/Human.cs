using System;

namespace WindowsFormsApp1
{
    public enum Pol { МУЖСКОЙ, ЖЕНСКИЙ }
    // Класс человека
    public class Human
    {
        public int Id { get; set; }
        protected static int count = 0;
        public int id;
        public String name { get; set; }
        public String lastName { get; set; }
        public int age { get; set; }
        public Pol pol { get; set; } // 0-мужской, 1-женский
        public long phone { get; set; }

        // бля БД
        public Human()
        {

        }

        public Human(String name, String lastName, int age, Pol pol, long phone)
        {
            this.id = ++count;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.pol = pol;
            this.phone = phone;
        }

        public virtual string GetInfo()
        {
            //ID: {id}\n
            return $"Имя: {name}\nФамилия: {lastName}\nГод рождения: {age}\nПол: {pol}\nТелефон: {phone}\n";
        }

        public String GetLastName()
        {
            return lastName;
        }

        public String GetName()
        {
            return name;
        }

        public int GetID()
        {
            return id;
        }

        public int GetAge()
        {
            return age;
        }

        public Pol GetPol()
        {
            return pol;
        }

        public long GetPhone()
        {
            return phone;
        }
    }
}
