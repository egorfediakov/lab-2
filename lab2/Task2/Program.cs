using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12.3, 22);
            Console.WriteLine($"S = {rectangle.AreaCalculator()}");
            Console.WriteLine($"P = {rectangle.PerimeterCalculator()}");
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }
        public double AreaCalculator()
        {
            double area = Side1 * Side2;
            return area;
        }
        public double PerimeterCalculator()
        {
            double p = (Side1 + Side2) * 2;
            return p;
        }

    }
}
