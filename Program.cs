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
            /*     This Code is valid for integers only !
             *     if decimal value to be input,
             *     then we have to change our "int" variable to "doubles" or "floats"   */
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] aritmaticArray = new int[4];
            aritmaticArray[0] = a + b * c;
            aritmaticArray[1] = a * b + c;
            aritmaticArray[2] = c + a / b;
            aritmaticArray[3] = a % b + c;
            Console.WriteLine(string.Join(" ",aritmaticArray));
            Console.ReadLine();
        }
    }
}
