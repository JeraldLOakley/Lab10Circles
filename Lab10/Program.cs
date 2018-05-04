using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine("Welcome to circumference circulator");
            Console.WriteLine();
            Console.WriteLine("If you would like to find the area and circumference of a circle please type a radius");
            
           string input= Console.ReadLine();
           
            bool success = double.TryParse(input, out double Radius);
            if (success)
            {
                Circle circle = new Circle(Radius);
                Console.WriteLine($"The circumference of a circle is {circle.CalculateCircumference()}");
                Console.WriteLine($"The area of a circle is {circle.CalculateArea()}");
            }
            else
                Console.WriteLine("Not a number");
            

            
            
            Console.ReadKey();
        }
    }
}
