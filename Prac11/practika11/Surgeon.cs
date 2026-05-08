using System;

namespace Practika11
{
    class Surgeon : Doctor
    {
        public Surgeon() : base()
        {
        }

        public Surgeon(int doctorId) : base(doctorId)
        {
        }

        public Surgeon(int doctorId, string firstName) : base(doctorId, firstName)
        {
        }

        public Surgeon(int doctorId, string firstName, string lastName) : base(doctorId, firstName, lastName)
        {
        }

        public Surgeon(int doctorId, string firstName, string lastName, string specialization) : base(doctorId, firstName, lastName, specialization)
        {
        }

        public override void ExaminePatient(Patient patient)
        {
            string fio = (patient.FirstName + " " + patient.LastName).Capitalize();
            Console.WriteLine("Хирург " + (FirstName + " " + LastName).Capitalize() + " осматривает пациента " + fio);
            Console.WriteLine("Рекомендации хирурга:");
            Console.WriteLine("- Сдайте анализы крови и пройдите УЗИ");
            Console.WriteLine("- Обеспечьте покой повреждённой области");
            Console.WriteLine("- Не принимайте препараты, разжижающие кровь, без согласования");
        }
    }
}
