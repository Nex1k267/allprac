using System;
using System.Collections.Generic;
using System.IO;

namespace Practika11
{
    class Hospital : IStorable
    {
        public const int MAX_DEPARTMENTS = 10;
        private static int hospitalCount = 0;

        private readonly int hospitalId;
        private string name;
        private string address;
        private List<Department> departments;

        public Hospital(int hospitalId)
        {
            this.hospitalId = hospitalId;
            this.name = "";
            this.address = "";
            this.departments = new List<Department>();
            hospitalCount++;
        }

        public Hospital(int hospitalId, string name) : this(hospitalId)
        {
            this.name = name;
        }

        public Hospital(int hospitalId, string name, string address) : this(hospitalId, name)
        {
            this.address = address;
        }

        public Hospital(int hospitalId, string name, string address, List<Department> departments) : this(hospitalId, name, address)
        {
            this.departments = departments;
        }

        public int HospitalId
        {
            get { return hospitalId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public List<Department> Departments
        {
            get { return departments; }
            set { departments = value; }
        }

        public static int GetTotalHospitals()
        {
            return hospitalCount;
        }

        public void AddDepartment(Department department)
        {
            if (departments.Count >= MAX_DEPARTMENTS)
            {
                Console.WriteLine("Нельзя добавить новое отделение: достигнуто максимальное количество (" + MAX_DEPARTMENTS + ")");
                return;
            }
            departments.Add(department);
        }

        public bool RemoveDepartment(int departmentId)
        {
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].DepartmentId == departmentId)
                {
                    departments.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void SaveToFile(string filePath)
        {
            string[] lines = new string[4];
            lines[0] = hospitalId.ToString();
            lines[1] = name;
            lines[2] = address;
            lines[3] = departments.Count.ToString();
            File.WriteAllLines(filePath, lines);
        }

        public void LoadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 3)
            {
                name = lines[1];
                address = lines[2];
            }
        }
    }
}
