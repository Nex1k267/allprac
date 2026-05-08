using System;
using System.Collections.Generic;

namespace Practika10
{
    class Therapeutic : Department
    {
        public Therapeutic() : base()
        {
            this.name = "Терапия";
        }

        public Therapeutic(int departmentId) : base(departmentId)
        {
            this.name = "Терапия";
        }

        public Therapeutic(int departmentId, string name) : base(departmentId, name)
        {
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment) : base(departmentId, name, headOfDepartment)
        {
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors) : base(departmentId, name, headOfDepartment, doctors)
        {
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds) : base(departmentId, name, headOfDepartment, doctors, beds)
        {
        }
    }
}
