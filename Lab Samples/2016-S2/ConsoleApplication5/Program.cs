using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i_Day;
            int i_Total = 5;

            ////for (i_Day = 1; i_Day <=10; i_Day++)
            //for (i_Day = 20; i_Day >= 1; i_Day--)
            //    {
            //    i_Total = i_Total + i_Day;

            //    Console.Write(i_Day + " ");
            //}

            //Console.Write(Environment.NewLine + i_Total);

            int i_star;
            int i_count;
            int i_space;

            //for (i_star = 1; i_star <= 10; i_star++)
            //{
            //    for (i_count = 1; i_count <= i_star; i_count++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (i_star = 10; i_star >= 1; i_star--)
            //{
            //    for (i_count = 1; i_count <= i_star; i_count++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (i_star = 1; i_star <= 10; i_star++)
            //{
            //    for (i_space = 1; i_space <= 10 - i_star; i_space++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (i_count = 1; i_count <= i_star; i_count++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (i_star = 1; i_star <= 10; i_star++)
            //{
            //    for (i_space = 1; i_space<= i_star; i_space++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (i_count = 1; i_count <= 10 - i_star; i_count++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            for (i_star = 1; i_star <= 10; i_star++)
            {
                for (i_space = 1; i_space <= 10 - i_star; i_space++)
                {
                    Console.Write(" ");
                }

                for (i_count = 1; i_count <= i_star; i_count++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (i_star = 10; i_star >= 1; i_star--)
            {
                for (i_space = 10 - i_star; i_space >= 1; i_space--)
                {
                    Console.Write(" ");
                }

                for (i_count = i_star; i_count >= 1; i_count--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
