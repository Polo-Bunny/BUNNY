using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.SImpleFactory
{
    internal class ShapeFactory
    {
        public IShape GetShape(String type)
        {
            IShape shape = null;
            switch (type)
            {
                case "R":
                    double x, y;
                    Console.Write("ENter the lengthn of the shape:");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.Write("ENter the width of the shape:");
                    y = Convert.ToDouble(Console.ReadLine());

                    shape = new Rectangle(x, y);
                    return shape;
                  
                case "S":
                    double s;
                    Console.Write("Enter the side of the square");
                    s = Convert.ToDouble(Console.ReadLine());
                    shape = new Square(s);
                    return shape;
                case "C":
                    double r;
                    Console.WriteLine("enter the radius of the cirle");
                    r = Convert.ToDouble(Console.ReadLine());
                    shape = new Circle(r);
                    return shape;


            } 
           

            return shape;
        }

    }
}
