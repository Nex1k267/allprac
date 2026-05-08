using System;
using System.Collections.Generic;

namespace Practika11
{
    class Cardiology : Department
    {
        public Cardiology() : base()
        {
            this.name = "Кардиология";
        }

        public Cardiology(int departmentId) : base(departmentId)
        {
            this.name = "Кардиология";
        }

        public Cardiology(int departmentId, string name) : base(departmentId, name)
        {
        }

        public Cardiology(int departmentId, string name, Doctor headOfDepartment) : base(departmentId, name, headOfDepartment)
        {
        }

        public Cardiology(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors) : base(departmentId, name, headOfDepartment, doctors)
        {
        }

        public Cardiology(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds) : base(departmentId, name, headOfDepartment, doctors, beds)
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
            Console.WriteLine("Рекомендации по профилактике сердечных заболеваний:");
            Console.WriteLine("- Контролируйте артериальное давление");
            Console.WriteLine("- Соблюдайте диету с пониженным содержанием соли");
            Console.WriteLine("- Регулярно занимайтесь физической активностью");
        }
    }
}
