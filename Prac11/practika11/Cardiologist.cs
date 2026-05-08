using System;

namespace Practika11
{
    class Cardiologist : Doctor
    {
        public Cardiologist() : base()
        {
        }

        public Cardiologist(int doctorId) : base(doctorId)
        {
        }

        public Cardiologist(int doctorId, string firstName) : base(doctorId, firstName)
        {
        }

        public Cardiologist(int doctorId, string firstName, string lastName) : base(doctorId, firstName, lastName)
        {
        }

        public Cardiologist(int doctorId, string firstName, string lastName, string specialization) : base(doctorId, firstName, lastName, specialization)
        {
        }

        public override void ExaminePatient(Patient patient)
        {
            string fio = (patient.FirstName + " " + patient.LastName).Capitalize();
            Console.WriteLine("Кардиолог " + (FirstName + " " + LastName).Capitalize() + " осматривает пациента " + fio);
            Console.WriteLine("Рекомендации кардиолога:");
            Console.WriteLine("- Измерьте артериальное давление");
            Console.WriteLine("- Сделайте ЭКГ");
            Console.WriteLine("- Ограничьте употребление соли и жирной пищи");
        }
    }
}
