using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.SImpleFactory
{
    internal class Square: IShape
    {
        private double side;

        public Square( double s)
        {
            side = s;
        }
        public double CalcArea()
        {
            return side * side;
        }

        public void print()
        {
            Console.WriteLine("The Square area is :" + CalcArea());
        }
    }
}
