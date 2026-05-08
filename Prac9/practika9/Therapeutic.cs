using System;
using System.Collections.Generic;

namespace Practika9
{
    class Therapeutic
    {
        private readonly int departmentId;
        private string name;
        private Doctor headOfDepartment;
        private List<Doctor> doctors;
        private bool[] beds;

        public Therapeutic()
        {
            this.departmentId = 0;
            this.name = "Терапия";
            this.headOfDepartment = new Doctor();
            this.doctors = new List<Doctor>();
            this.beds = new bool[0];
        }

        public Therapeutic(int departmentId) : this()
        {
            this.departmentId = departmentId;
        }

        public Therapeutic(int departmentId, string name) : this(departmentId)
        {
            this.name = name;
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment) : this(departmentId, name)
        {
            this.headOfDepartment = headOfDepartment;
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors) : this(departmentId, name, headOfDepartment)
        {
            this.doctors = doctors;
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds) : this(departmentId, name, headOfDepartment, doctors)
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
        }

        public bool RemoveDoctor(int doctorId)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].DoctorId == doctorId)
                {
                    doctors.RemoveAt(i);
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
    }
}
