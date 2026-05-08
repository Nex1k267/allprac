using System;
using System.IO;

namespace Practika11
{
    class Patient : IStorable
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
            string fio = (firstName + " " + lastName).Capitalize();
            return "Пациент №" + patientId + ": " + fio + ", возраст: " + GetAge() + ", диагноз: " + diagnosis;
        }

        public void SaveToFile(string filePath)
        {
            string[] lines = new string[5];
            lines[0] = patientId.ToString();
            lines[1] = firstName;
            lines[2] = lastName;
            lines[3] = dateOfBirth.ToString("yyyy-MM-dd");
            lines[4] = diagnosis;
            File.WriteAllLines(filePath, lines);
        }

        public void LoadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 5)
            {
                firstName = lines[1];
                lastName = lines[2];
                dateOfBirth = DateTime.Parse(lines[3]);
                diagnosis = lines[4];
            }
        }
    }
}
