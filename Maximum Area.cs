using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication10
{
    class Circle
    {
        public double radius;
        public double area()
        {
            return radius * radius;
        }
        public double circumference()
        {
            return 2 * 3.14159 * radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Please Enter The Number of Circle/s:");
            input = int.Parse(Console.ReadLine());
            Circle[] circle = new Circle[input];
            for(int i=0;i<input;i++)
                circle[i]= new Circle();
            for (int i = 0; i < input; i++)
            {
                circle[i].radius = float.Parse(Console.ReadLine());
            }
            double max = circle[0].radius;
            for (int i = 1; i < input; i++)
                if (circle[i].radius > max)
                    max = circle[i].radius;
            Circle mx = new Circle();
            mx.radius = max;
            Console.WriteLine("Largest Circle's Area : " +mx.area()+" ,Circumference : "+mx.circumference());
            Console.Write("Press Any Key to Continue.....");
            Console.ReadKey();
        }
    }
}
