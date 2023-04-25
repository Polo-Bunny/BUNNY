using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.SImpleFactory
{
    internal class Rectangle: IShape
    {
        private double Length;
        private double Width;

        public Rectangle(double l, double w)        {
            Length = l;
            Width = w;
        }

        public double CalcArea()
        {
            return Length * Width;
        }

        public void print()
        {
             Console.WriteLine("The Rectangles area is :" + CalcArea());
        }
    }
}
