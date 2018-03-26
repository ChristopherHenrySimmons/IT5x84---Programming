using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk_3_Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i_maxNo = 10;
            Console.Write("Type char to use: ");
            string s_symbol = Convert.ToString(Console.ReadKey(true).KeyChar);
            Console.WriteLine();

            for (int i_ct = 0; i_ct <= i_maxNo; i_ct++)
            {
                for (int i_ct2 = 0; i_ct2 <= i_ct; i_ct2++)
                {
                    Console.Write(s_symbol + " ");
                }

                Console.WriteLine();
            }
            
        }
    }
}
