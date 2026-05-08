using System;
using System.Collections.Generic;

namespace Practika10
{
    class Surgery : Department
    {
        public Surgery() : base()
        {
            this.name = "Хирургия";
        }

        public Surgery(int departmentId) : base(departmentId)
        {
            this.name = "Хирургия";
        }

        public Surgery(int departmentId, string name) : base(departmentId, name)
        {
        }

        public Surgery(int departmentId, string name, Doctor headOfDepartment) : base(departmentId, name, headOfDepartment)
        {
        }

        public Surgery(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors) : base(departmentId, name, headOfDepartment, doctors)
        {
        }

        public Surgery(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds) : base(departmentId, name, headOfDepartment, doctors, beds)
        {
        }
    }
}
