using System;
using System.Collections.Generic;

namespace Practika10
{
    class Hospital
    {
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

        public void AddDepartment(Department department)
        {
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
    }
}
