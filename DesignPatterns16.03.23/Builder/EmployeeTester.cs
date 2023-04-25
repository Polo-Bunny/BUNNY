using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.Builder
{
    internal class EmployeeTester
    {
     static void Main(string[] args)
        {
            EmployeeBuilder E1 = new EmployeeBuilder().withName("Thabiso","Madumo").Age(22).build();
            Console.WriteLine(E1.ToString());

        }
    }

}
