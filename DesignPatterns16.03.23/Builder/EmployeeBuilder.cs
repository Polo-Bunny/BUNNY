using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.Builder
{
    internal class EmployeeBuilder
    {
        public string StaffNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public EmployeeBuilder withStaffNo(string staffno)
        {
            this.StaffNo = staffno;
            return this;
        }

        public EmployeeBuilder withName( string firstName , string Surname)
        {
            FirstName = firstName;
            LastName = Surname;

            return this;
        }

        // This method helps to join any combo of the previous methods 
        public EmployeeBuilder build()
        {
            if(checkBuild() == true)
            {
                throw new Exception("Staff Member needed");
            }
            return this;
        }

        public EmployeeBuilder Age(int Age)
        {
            age = Age;
            return this;
        }
        private bool checkBuild()
        {
            return StaffNo.Length > 0;
        }
        public override string ToString()
        {
            return $"Staff No:{StaffNo}"
                +$"\nName:{FirstName} {LastName}"
                +$"\nEmail:{email}"
                +$"\nAge:{age}"
                +$"\nSalary:{salary}";
        }
    }
}
