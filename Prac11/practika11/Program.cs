using System;
using System.Collections.Generic;

namespace Practika11
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital1 = new Hospital(1, "Городская больница №1", "ул. Ленина, 10");
            Hospital hospital2 = new Hospital(2, "Областная больница", "пр. Мира, 25");

            Console.WriteLine("Всего больниц создано: " + Hospital.GetTotalHospitals());
            Console.WriteLine("Максимум отделений в больнице: " + Hospital.MAX_DEPARTMENTS);

            Cardiologist card = new Cardiologist(1, "иван", "иванов", "Кардиология");
            Surgeon surg = new Surgeon(2, "анна", "петрова", "Хирургия");
            Therapist ther = new Therapist(3, "сергей", "сидоров", "Терапия");

            Cardiology cardiology = new Cardiology(1, "Кардиология", card);
            cardiology.AddDoctor(card);

            Surgery surgery = new Surgery(2, "Хирургия", surg);
            surgery.AddDoctor(surg);

            Therapeutic therapeutic = new Therapeutic(3, "Терапия", ther);
            therapeutic.AddDoctor(ther);

            hospital1.AddDepartment(cardiology);
            hospital1.AddDepartment(surgery);
            hospital1.AddDepartment(therapeutic);

            Patient pat1 = new Patient(1, "петр", "сидоров", new DateTime(1990, 5, 15), "Гипертония");
            card.AddPatient(pat1);

            Console.WriteLine();
            Console.WriteLine("=== Полиморфизм: ExaminePatient ===");
            Doctor[] doctors = new Doctor[] { card, surg, ther };
            for (int i = 0; i < doctors.Length; i++)
            {
                doctors[i].ExaminePatient(pat1);
                Console.WriteLine();
            }

            Console.WriteLine("=== Отчёты по отделениям ===");
            for (int i = 0; i < hospital1.Departments.Count; i++)
            {
                Console.WriteLine(hospital1.Departments[i].GetDepartmentReport());
                Console.WriteLine();
            }

            Console.WriteLine("=== Специальная функциональность отделения ===");
            cardiology.SpecializedFunctionality();
            Console.WriteLine();

            Console.WriteLine("=== Метод расширения Capitalize ===");
            string raw = "иван иванов";
            Console.WriteLine("Было: " + raw);
            Console.WriteLine("Стало: " + raw.Capitalize());
            Console.WriteLine();

            Console.WriteLine("=== Информация о пациенте (с Capitalize) ===");
            Console.WriteLine(pat1.ToString());
            Console.WriteLine();

            Console.WriteLine("=== Сохранение в файл (IStorable) ===");
            hospital1.SaveToFile("hospital1.txt");
            card.SaveToFile("doctor1.txt");
            pat1.SaveToFile("patient1.txt");
            Console.WriteLine("Данные сохранены в hospital1.txt, doctor1.txt, patient1.txt");

            Console.WriteLine();
            Console.WriteLine("=== Загрузка из файла ===");
            Hospital loaded = new Hospital(99);
            loaded.LoadFromFile("hospital1.txt");
            Console.WriteLine("Загружено: " + loaded.Name + ", " + loaded.Address);
        }
    }
}
