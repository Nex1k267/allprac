using System;
using System.Collections.Generic;

namespace Practika9
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital(1, "Городская больница №1", "ул. Ленина, 10");

            Doctor doc1 = new Doctor(1, "Иван", "Иванов", "Кардиология");
            Doctor doc2 = new Doctor(2, "Анна", "Петрова", "Кардиология");

            Patient pat1 = new Patient(1, "Петр", "Сидоров", new DateTime(1990, 5, 15), "Гипертония");
            Patient pat2 = new Patient(2, "Мария", "Кузнецова", new DateTime(1985, 3, 20), "Аритмия");

            doc1.AddPatient(pat1);
            doc1.AddPatient(pat2);

            Cardiology cardiology = new Cardiology(1, "Кардиология", doc1, new List<Doctor>(), new bool[] { true, true, false, true, false });
            cardiology.AddDoctor(doc1);
            cardiology.AddDoctor(doc2);

            Console.WriteLine("Больница: " + hospital.Name);
            Console.WriteLine("Адрес: " + hospital.Address);
            Console.WriteLine();

            Console.WriteLine("Отделение: " + cardiology.Name);
            Console.WriteLine("Заведующий: " + cardiology.HeadOfDepartment.FirstName + " " + cardiology.HeadOfDepartment.LastName);
            Console.WriteLine("Количество врачей: " + cardiology.Doctors.Count);
            Console.WriteLine("Свободных коек: " + cardiology.GetAvailableBeds());
            Console.WriteLine();

            Console.WriteLine("Врач: " + doc1.FirstName + " " + doc1.LastName);
            Console.WriteLine("Количество пациентов у врача: " + doc1.GetPatientCount());
            Console.WriteLine();

            Patient? found = doc1.FindPatient(1);
            if (found != null)
            {
                Console.WriteLine("Найден пациент:");
                Console.WriteLine(found.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Удаление врача с id=2: " + cardiology.RemoveDoctor(2));
            Console.WriteLine("Количество врачей после удаления: " + cardiology.Doctors.Count);
        }
    }
}
