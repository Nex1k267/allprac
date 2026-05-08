using System;
using System.Collections.Generic;

namespace Practika10
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital(1, "Городская больница №1", "ул. Ленина, 10");

            Doctor doc1 = new Doctor(1, "Иван", "Иванов", "Кардиология");
            Doctor doc2 = new Doctor(2, "Анна", "Петрова", "Кардиология");

            Cardiology cardiology = new Cardiology(1, "Кардиопульмонология", doc1);
            cardiology.AddDoctor(doc1);
            cardiology.AddDoctor(doc2);

            Surgery surgery = new Surgery(2);
            Therapeutic therapeutic = new Therapeutic(3);

            hospital.AddDepartment(cardiology);
            hospital.AddDepartment(surgery);
            hospital.AddDepartment(therapeutic);

            Console.WriteLine();
            Console.WriteLine("=== Перегрузка AddPatient ===");
            doc1.AddPatient(1, "Петр", "Сидоров", new DateTime(1990, 5, 15), "Гипертония");
            Console.WriteLine("У врача " + doc1.FirstName + " " + doc1.LastName + " пациентов: " + doc1.GetPatientCount());

            Console.WriteLine();
            Console.WriteLine("=== Уведомление о новом пациенте ===");
            cardiology.NotifyNewPatient("Сидоров Петр");

            Console.WriteLine();
            Console.WriteLine("=== Уведомление об обновлении протокола ===");
            cardiology.NotifyProtocolUpdate("сердечной недостаточности");

            Console.WriteLine();
            Console.WriteLine("=== Список отделений в больнице ===");
            for (int i = 0; i < hospital.Departments.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + hospital.Departments[i].Name + " (id=" + hospital.Departments[i].DepartmentId + ")");
            }

            Console.WriteLine();
            Console.WriteLine("=== Удаление отделения с id=2 ===");
            bool removed = hospital.RemoveDepartment(2);
            Console.WriteLine("Удалено: " + removed);
            Console.WriteLine("Количество отделений: " + hospital.Departments.Count);
        }
    }
}
