using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCircleAndClassCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle Test
            Circle circle = new Circle();
            Console.WriteLine(circle);

            circle = new Circle(3.5);
            Console.WriteLine(circle);

            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);

            // Cylinder Test
            Circle cylinder = new Cylinder();
            Console.WriteLine(cylinder);

            cylinder = new Cylinder(7.5);
            Console.WriteLine(cylinder);

            cylinder = new Cylinder(5, 3.5, "indigo", false);
            Console.WriteLine(cylinder);
        }
    }
}
