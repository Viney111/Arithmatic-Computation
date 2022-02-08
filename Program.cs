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
            int[] aritmaticArray = new int[4];
            aritmaticArray[1] = a + b * c;
            aritmaticArray[2] = a * b + c;
            aritmaticArray[3] = c + a / b;
            aritmaticArray[4] = a % b + c;
            Console.WriteLine(aritmaticArray);
            Console.ReadLine();

        }
    }
}
