using System;

namespace Practika11
{
    class Therapist : Doctor
    {
        public Therapist() : base()
        {
        }

        public Therapist(int doctorId) : base(doctorId)
        {
        }

        public Therapist(int doctorId, string firstName) : base(doctorId, firstName)
        {
        }

        public Therapist(int doctorId, string firstName, string lastName) : base(doctorId, firstName, lastName)
        {
        }

        public Therapist(int doctorId, string firstName, string lastName, string specialization) : base(doctorId, firstName, lastName, specialization)
        {
        }

        public override void ExaminePatient(Patient patient)
        {
            string fio = (patient.FirstName + " " + patient.LastName).Capitalize();
            Console.WriteLine("Терапевт " + (FirstName + " " + LastName).Capitalize() + " осматривает пациента " + fio);
            Console.WriteLine("Рекомендации терапевта:");
            Console.WriteLine("- Измерьте температуру тела");
            Console.WriteLine("- Сдайте общий анализ крови и мочи");
            Console.WriteLine("- Соблюдайте постельный режим первые 3 дня");
        }
    }
}
