using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5___Array___Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i_Age = { 27, 37, 47, 57, 67, 77 };
            string[] s_Name = { "John", "Jane", "Sam", "Natasha", "Rob", "Diane" };

            int i_index;

            for (i_index = 0; i_index < i_Age.Count(); i_index++)
            {
                Console.WriteLine(i_Age[i_index].ToString() + s_Name[i_index]);
            }

            Console.WriteLine();
            Console.WriteLine(i_Age[3].ToString() + s_Name[5]);
            Console.WriteLine(i_Age[5].ToString() + s_Name[0]);
            Console.WriteLine(i_Age[0].ToString() + s_Name[4]);

            //Console.Clear();

            int[] i_HouseNumber = new int[5];

            i_HouseNumber[0] = 163;
            i_HouseNumber[1] = 563;
            i_HouseNumber[2] = 143;
            i_HouseNumber[3] = 124;
            i_HouseNumber[4] = 149;

            Array.Sort(i_HouseNumber);
            Array.Reverse(i_HouseNumber);
            
            Console.WriteLine();
            for (i_index = 0; i_index < i_HouseNumber.Count(); i_index++)
            {
                Console.WriteLine(i_HouseNumber[i_index].ToString());
            }
        }
    }
}
