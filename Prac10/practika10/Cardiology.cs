using System;
using System.Collections.Generic;

namespace Practika10
{
    class Cardiology : Department
    {
        public Cardiology() : base()
        {
            this.name = "Кардиология";
        }

        public Cardiology(int departmentId) : base(departmentId)
        {
            this.name = "Кардиология";
        }

        public Cardiology(int departmentId, string name) : base(departmentId, name)
        {
        }

        public Cardiology(int departmentId, string name, Doctor headOfDepartment) : base(departmentId, name, headOfDepartment)
        {
        }

        public Cardiology(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors) : base(departmentId, name, headOfDepartment, doctors)
        {
        }

        public Cardiology(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds) : base(departmentId, name, headOfDepartment, doctors, beds)
        {
        }
    }
}
