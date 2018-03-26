using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i_Number1, i_Number2;
            int[] ai_Age = new int[5];

            StartingPoint:

            try
            {
                Console.Write("Enter 1st number: ");
                i_Number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 2nd number: ");
                i_Number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result: " + (i_Number1 / i_Number2).ToString());
                ai_Age[i_Number1] = i_Number2;
            }
            catch (System.FormatException)
            { Console.WriteLine("Invalid number"); }
            catch (System.DivideByZeroException)
            { Console.WriteLine("Cannot divide by zero"); }
            catch (System.IndexOutOfRangeException)
            { Console.WriteLine("Wrong index number"); }
            catch
            { Console.WriteLine("Unknown error. Contact whoever."); }

            Console.WriteLine("Game ends here. Please pay again to continue.");
            Console.ReadKey();
            
            goto StartingPoint;
        }
    }
}
