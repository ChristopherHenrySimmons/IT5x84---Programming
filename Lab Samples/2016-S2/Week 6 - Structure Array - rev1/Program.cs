using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6___Structure_Array
{
    class Program
    {
        private struct strPerson
        {
            public string s_ID;
            public string s_name;
            public string s_address;
            public int i_startYear;

        }
        static void Main(string[] args)
        {
            strPerson[] asrt_Staff = new strPerson[5];
            //int i_indexEntry, i_indexDisplay;
            int i_index;

            for (i_index = 0; i_index < 5; i_index++)
            {
                //Console.Clear();
                
                Console.Write("Staff ID: ");
                asrt_Staff[i_index].s_ID = Console.ReadLine();

                Console.Write("Name: ");
                asrt_Staff[i_index].s_name = Console.ReadLine();

                Console.Write("Address: ");
                asrt_Staff[i_index].s_address = Console.ReadLine();

                Console.Write("Year Start: ");
                asrt_Staff[i_index].i_startYear = Convert.ToInt32(Console.ReadLine());


                if (i_index < 4)
                {
                    Console.WriteLine();
                    Console.Write("[" + (i_index + 1).ToString() + "/5] Continue [Y/N]: ");

                    if (Console.ReadKey().Key == ConsoleKey.N) { break; }

                    Console.WriteLine(); Console.WriteLine();
                }
            }


            Console.WriteLine(); Console.WriteLine();

            Console.Write("Staff ID: ");
            for (i_index = 0; i_index < asrt_Staff.Length; i_index++)
            { Console.Write(asrt_Staff[i_index].s_ID + " "); }

            Console.WriteLine();
            Console.Write("Name: ");
            for (i_index = 0; i_index < asrt_Staff.Length; i_index++)
            { Console.Write(asrt_Staff[i_index].s_name + " "); }

            Console.WriteLine();
            Console.Write("Address: ");
            for (i_index = 0; i_index < asrt_Staff.Length; i_index++)
            { Console.Write(asrt_Staff[i_index].s_address + " "); }

            Console.WriteLine();
            Console.Write("Year Start: ");
            for (i_index = 0; i_index < asrt_Staff.Length; i_index++)
            { Console.Write(asrt_Staff[i_index].i_startYear.ToString() + " "); }

            Console.WriteLine();
            Console.WriteLine("Total: " + (i_index + 1).ToString() + " entries.");
        }
    }
}
