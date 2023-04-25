using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.Builder
{
    internal class Employee
    {
        public string StaffNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public double salary {get; set; }

        public Employee(string staffNo, string firstName, string lastName, string email, string username, string password, int age, double salary)
        {
            StaffNo = staffNo;
            FirstName = firstName;
            LastName = lastName;
            this.email = email;
            this.username = username;
            this.password = password;
            this.age = age;
            this.salary = salary;
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(string staffNo)
        {
           this.StaffNo = staffNo;
            
        }

    }
}
