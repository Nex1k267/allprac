using System;
using System.Collections.Generic;

namespace Practika11
{
    class Surgery : Department
    {
        public Surgery() : base()
        {
            this.name = "Хирургия";
        }

        public Surgery(int departmentId) : base(departmentId)
        {
            this.name = "Хирургия";
        }

        public Surgery(int departmentId, string name) : base(departmentId, name)
        {
        }

        public Surgery(int departmentId, string name, Doctor headOfDepartment) : base(departmentId, name, headOfDepartment)
        {
        }

        public Surgery(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors) : base(departmentId, name, headOfDepartment, doctors)
        {
        }

        public Surgery(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds) : base(departmentId, name, headOfDepartment, doctors, beds)
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
            Console.WriteLine("Рекомендации по подготовке к операции:");
            Console.WriteLine("- Не есть и не пить за 8 часов до операции");
            Console.WriteLine("- Сообщить врачу обо всех принимаемых препаратах");
            Console.WriteLine("- Подготовить чистую одежду и средства гигиены");
        }
    }
}
