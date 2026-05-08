using System;
using System.Collections.Generic;

namespace Practika9
{
    class Hospital
    {
        private readonly int hospitalId;
        private string name;
        private string address;
        private List<int> departments;

        public Hospital(int hospitalId)
        {
            this.hospitalId = hospitalId;
            this.name = "";
            this.address = "";
            this.departments = new List<int>();
        }

        public Hospital(int hospitalId, string name) : this(hospitalId)
        {
            this.name = name;
        }

        public Hospital(int hospitalId, string name, string address) : this(hospitalId, name)
        {
            this.address = address;
        }

        public Hospital(int hospitalId, string name, string address, List<int> departments) : this(hospitalId, name, address)
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

        public List<int> Departments
        {
            get { return departments; }
            set { departments = value; }
        }
    }
}
