using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.SImpleFactory {
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            ShapeFactory sFactroy1 = new ShapeFactory();
            Console.WriteLine("Please enter the either \n" + "R:Rectangle\n" + "S:Square\n" + "C:Circle");
            string sType = Console.ReadLine().ToUpper();



            IShape shape = sFactroy1.GetShape(sType);
            shape.print();

        }






    }
}


    

