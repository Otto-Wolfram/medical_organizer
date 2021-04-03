using System;

// Представляет пациента
namespace WindowsFormsApp1
{
    public class Patient : Human
    {
        public long polisNum { get; set; } // номер 

        public String diagnos { get; set; } // описание диагноза

        public Patient() { }

        public Patient(String name, String lastName, int age, Pol pol, long phone, long polisNum, string diagnosis) : base(name, lastName, age, pol, phone)
        {
            this.polisNum = polisNum;
            this.diagnos = diagnosis;
        }

        public override string GetInfo()
        {
            if (diagnos == "")
            {
                diagnos = "отсутствует";
            }

            return base.GetInfo() + $"Номер полиса: {polisNum}\nПредварительный диагноз: {diagnos}";
        }

        public long GetPolis()
        {
            return polisNum;
        }

        public string GetDiagnos()
        {
            return diagnos;
        }
    }
}
