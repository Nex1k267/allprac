using System;
using System.Collections.Generic;

namespace Practika11
{
    class Therapeutic : Department
    {
        public Therapeutic() : base()
        {
            this.name = "Терапия";
        }

        public Therapeutic(int departmentId) : base(departmentId)
        {
            this.name = "Терапия";
        }

        public Therapeutic(int departmentId, string name) : base(departmentId, name)
        {
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment) : base(departmentId, name, headOfDepartment)
        {
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors) : base(departmentId, name, headOfDepartment, doctors)
        {
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds) : base(departmentId, name, headOfDepartment, doctors, beds)
        {
        }

        public override string GetDepartmentReport()
        {
            int patientsCount = 0;
            for (int i = 0; i < doctors.Count; i++)
            {
                patientsCount += doctors[i].GetPatientCount();
            }
            string report = "Отчёт по отделению '" + name + "' (id=" + departmentId + ")\n";
            report += "Количество врачей: " + doctors.Count + "\n";
            report += "Количество пациентов: " + patientsCount + "\n";
            report += "Свободных коек: " + GetAvailableBeds();
            return report;
        }

        public override void SpecializedFunctionality()
        {
            Console.WriteLine("Общие рекомендации терапевта:");
            Console.WriteLine("- Соблюдайте режим сна и отдыха");
            Console.WriteLine("- Принимайте назначенные лекарства строго по графику");
            Console.WriteLine("- Регулярно проходите профилактические осмотры");
        }
    }
}
