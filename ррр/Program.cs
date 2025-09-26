using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ррр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double a, b, x2, D, c, x1;
                Console.Write("Enter a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                c = double.Parse(Console.ReadLine());
                D = Math.Pow(b, 2) - (4 * a * c);
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"The answers are x1 = {x1}, x2 = {x2}.");
            }
        }
    }
}
