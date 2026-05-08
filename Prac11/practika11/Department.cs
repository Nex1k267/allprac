using System;
using System.Collections.Generic;

namespace Practika11
{
    abstract class Department
    {
        protected readonly int departmentId;
        protected string name;
        protected Doctor headOfDepartment;
        protected List<Doctor> doctors;
        protected bool[] beds;

        public Department()
        {
            this.departmentId = 0;
            this.name = "";
            this.headOfDepartment = new Doctor();
            this.doctors = new List<Doctor>();
            this.beds = new bool[0];
        }

        public Department(int departmentId) : this()
        {
            this.departmentId = departmentId;
        }

        public Department(int departmentId, string name) : this(departmentId)
        {
            this.name = name;
        }

        public Department(int departmentId, string name, Doctor headOfDepartment) : this(departmentId, name)
        {
            this.headOfDepartment = headOfDepartment;
        }

        public Department(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors) : this(departmentId, name, headOfDepartment)
        {
            this.doctors = doctors;
        }

        public Department(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds) : this(departmentId, name, headOfDepartment, doctors)
        {
            this.beds = beds;
        }

        public int DepartmentId
        {
            get { return departmentId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Doctor HeadOfDepartment
        {
            get { return headOfDepartment; }
            set { headOfDepartment = value; }
        }

        public List<Doctor> Doctors
        {
            get { return doctors; }
            set { doctors = value; }
        }

        public bool[] Beds
        {
            get { return beds; }
            set { beds = value; }
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
            NotifyDoctors("В отделение " + name + " добавлен новый врач: " + (doctor.FirstName + " " + doctor.LastName).Capitalize());
        }

        public bool RemoveDoctor(int doctorId)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].DoctorId == doctorId)
                {
                    string fio = (doctors[i].FirstName + " " + doctors[i].LastName).Capitalize();
                    doctors.RemoveAt(i);
                    NotifyDoctors("Из отделения " + name + " удалён врач: " + fio);
                    return true;
                }
            }
            return false;
        }

        public Doctor? FindDoctor(int doctorId)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].DoctorId == doctorId)
                {
                    return doctors[i];
                }
            }
            return null;
        }

        public int GetAvailableBeds()
        {
            int count = 0;
            for (int i = 0; i < beds.Length; i++)
            {
                if (beds[i] == true)
                {
                    count++;
                }
            }
            return count;
        }

        protected void NotifyDoctors(string message)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                string fio = (doctors[i].FirstName + " " + doctors[i].LastName).Capitalize();
                Console.WriteLine("Уведомление для доктора " + fio + " из отделения " + name + ": " + message);
            }
        }

        public void NotifyNewPatient(string patientFullName)
        {
            NotifyDoctors("Поступил новый пациент: " + patientFullName.Capitalize());
        }

        public void NotifyProtocolUpdate(string protocolName)
        {
            NotifyDoctors("Обновлен протокол лечения: " + protocolName);
        }

        public abstract string GetDepartmentReport();
        public abstract void SpecializedFunctionality();
    }
}
