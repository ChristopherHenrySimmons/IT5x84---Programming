using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, it's a nice morning!");
            Console.WriteLine("It is indeed. What are we doing inside, then?");
            Console.Write(Environment.NewLine);
            Console.WriteLine("To study Programming, of course.");

            string s_Name;
            
            Console.Write(Environment.NewLine);
            Console.Write("Enter a name: ");
            s_Name = Console.ReadLine();


            int i_Age;

            //Console.Write(Environment.NewLine);
            Console.Write("Enter age   : ");
            //i_Age = Convert.ToInt32(Console.ReadLine());
            Int32.TryParse(Console.ReadLine(), out i_Age);

            i_Age = i_Age + 10;


            Console.Write(Environment.NewLine);
            Console.WriteLine("Name is: " + s_Name);

            //Console.Write(Environment.NewLine);
            Console.WriteLine("Age is: " + i_Age);

            Console.ReadKey();
        }
    }
}
