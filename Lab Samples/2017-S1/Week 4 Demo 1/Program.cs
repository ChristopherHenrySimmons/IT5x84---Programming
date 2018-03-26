using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i_age = { 21, 22, 35, 44, 64, 66, 67 };
            //string[] s_name = new string[5];
            string[] s_name = new string[i_age.Length];
            //string[] s_metric = {"mg", "cg", "dg", "g", ""}

            Console.Write("Enter a name: ");
            s_name[0] = Console.ReadLine();
            s_name[1] = "roe";
            s_name[2] = "jane";
            s_name[3] = "john";
            s_name[4] = "doe";

            for (int i_index = 0; i_index < i_age.Length; i_index++)
            {
                Console.WriteLine(s_name[i_index] + ", " + i_age[i_index]);
            }

            //Console.WriteLine(s_name[0]);
            //Console.WriteLine(s_name[1]);

            //for (int i_index = 2; i_index<5; i_index++)
            //{
            //    Console.WriteLine(s_name[i_index]);
            //}

            //for (int i_index = 0; i_index < 5; i_index++)
            //{
            //    Console.WriteLine(i_age[i_index]);
            //}

            int[,] i_grade = new int[3, 8];

            i_grade[0, 0] = 78;
            i_grade[0, 1] = 79;
            i_grade[0, 2] = 89;
            i_grade[1, 0] = 78;
            i_grade[1, 1] = 79;
            i_grade[2, 7] = 89;

            for (int i_left = 0; i_left < 3; i_left++)
            {
                for (int i_right = 0; i_right < 8; i_right++)
                {
                    Console.WriteLine(i_grade[i_left, i_right]);
                }
            }
        }
    }
}
