using System;
using System.Collections.Generic;
using System.IO;

namespace Practika11
{
    class Doctor : IStorable
    {
        private readonly int doctorId;
        private string firstName;
        private string lastName;
        private string specialization;
        private List<Patient> patients;

        public Doctor()
        {
            this.doctorId = 0;
            this.firstName = "";
            this.lastName = "";
            this.specialization = "";
            this.patients = new List<Patient>();
        }

        public Doctor(int doctorId) : this()
        {
            this.doctorId = doctorId;
        }

        public Doctor(int doctorId, string firstName) : this(doctorId)
        {
            this.firstName = firstName;
        }

        public Doctor(int doctorId, string firstName, string lastName) : this(doctorId, firstName)
        {
            this.lastName = lastName;
        }

        public Doctor(int doctorId, string firstName, string lastName, string specialization) : this(doctorId, firstName, lastName)
        {
            this.specialization = specialization;
        }

        public int DoctorId
        {
            get { return doctorId; }
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

        public string Specialization
        {
            get { return specialization; }
            set
            {
                if (value == "Кардиология" || value == "Хирургия" || value == "Терапия")
                {
                    specialization = value;
                }
                else
                {
                    Console.WriteLine("Специализация не соответствует ни одному из отделений");
                }
            }
        }

        public List<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void AddPatient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string diagnosis)
        {
            Patient patient = new Patient(patientId, firstName, lastName, dateOfBirth, diagnosis);
            patients.Add(patient);
        }

        public bool RemovePatient(int patientId)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].PatientId == patientId)
                {
                    patients.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public Patient? FindPatient(int patientId)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].PatientId == patientId)
                {
                    return patients[i];
                }
            }
            return null;
        }

        public int GetPatientCount()
        {
            return patients.Count;
        }

        public virtual void ExaminePatient(Patient patient)
        {
            string fio = (patient.FirstName + " " + patient.LastName).Capitalize();
            Console.WriteLine("Врач " + (firstName + " " + lastName).Capitalize() + " осматривает пациента " + fio);
            Console.WriteLine("Общие рекомендации: соблюдайте режим, принимайте назначенные лекарства, придите на повторный приём через неделю.");
        }

        public void SaveToFile(string filePath)
        {
            string[] lines = new string[5];
            lines[0] = doctorId.ToString();
            lines[1] = firstName;
            lines[2] = lastName;
            lines[3] = specialization;
            lines[4] = patients.Count.ToString();
            File.WriteAllLines(filePath, lines);
        }

        public void LoadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 4)
            {
                firstName = lines[1];
                lastName = lines[2];
                specialization = lines[3];
            }
        }
    }
}
