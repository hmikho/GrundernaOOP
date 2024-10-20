using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP.Lab5
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle_1 = new Circle(5);
            Circle circle_2 = new Circle(6);

            Console.WriteLine("Arean av en cirkel med radien 5 cm är: " + circle_1.GetArea() + " cm² ");
            Console.WriteLine("Arean av en cirkel med radien 6 cm är: " + circle_2.GetArea() + " cm² ");

            Console.ReadLine();
        }
    }
}
