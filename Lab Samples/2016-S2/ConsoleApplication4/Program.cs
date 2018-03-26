using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

        BackAtStart:

            Console.Write("Enter a: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter b: ");
            int.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter c: ");
            int.TryParse(Console.ReadLine(), out c);

            Console.Write("Enter d: ");
            int.TryParse(Console.ReadLine(), out d);

            //if (a <= 7 && b < 10 || c < 2 && d <= 20)
            if (a >= 7 || b <= 10 && c>= 2 || d <= 20)
            {
                Console.WriteLine("Execute");
            }
            else
            {
                Console.WriteLine("Not execute");
            }

            Console.Write(Environment.NewLine);
            goto BackAtStart;
        }
    }
}
