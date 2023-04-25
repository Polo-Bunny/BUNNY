using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.SImpleFactory
{
    internal class Circle  : IShape
    {
        private double Radius;
        private double PI = Math.PI;
        public Circle(double radius)
        {
            Radius = radius;
            
        }

        public double CalcArea()
        {
            return PI*(Radius*Radius);
        }

        public void print()
        {
            Console.WriteLine("The Circle area is :" + CalcArea());
        }
    }
}
