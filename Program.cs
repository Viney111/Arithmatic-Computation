using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation
{
    internal class Arithmatic
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"a+b*c is { a + b * c}");
            //Console.WriteLine($"a*b+c is { a * b + c}");
            Console.WriteLine($"c+a/b is { c + a / b}");
            Console.ReadLine();

        }
    }
}
