using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.Singleton
{
    internal class ExecutePrinter
    {

        static void Main(string[] args)
        {
            Printer printer = Printer.GetInstance();
            Printer p1 = Printer.GetInstance();
            

            Console.WriteLine(printer.GetHashCode());
           Console.WriteLine(p1.GetHashCode());

            //printer1.sModel = "Konica";
        }
    }
}
