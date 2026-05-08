using System;

namespace Practika9
{
    class Patient
    {
        private readonly int patientId;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string diagnosis;

        public Patient(int patientId)
        {
            this.patientId = patientId;
            this.firstName = "";
            this.lastName = "";
            this.dateOfBirth = DateTime.Now;
            this.diagnosis = "";
        }

        public Patient(int patientId, string firstName) : this(patientId)
        {
            this.firstName = firstName;
        }

        public Patient(int patientId, string firstName, string lastName) : this(patientId, firstName)
        {
            this.lastName = lastName;
        }

        public Patient(int patientId, string firstName, string lastName, DateTime dateOfBirth) : this(patientId, firstName, lastName)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public Patient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string diagnosis) : this(patientId, firstName, lastName, dateOfBirth)
        {
            this.diagnosis = diagnosis;
        }

        public int PatientId
        {
            get { return patientId; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        public void UpdateDiagnosis(string newDiagnosis)
        {
            diagnosis = newDiagnosis;
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age--;
            }
            return age;
        }

        public override string ToString()
        {
            return "Пациент №" + patientId + ": " + firstName + " " + lastName + ", возраст: " + GetAge() + ", диагноз: " + diagnosis;
        }
    }
}
