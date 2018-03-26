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
            int i_indexEntry, i_indexDisplay;

            for (i_indexEntry = 0; i_indexEntry < 5; i_indexEntry++)
            {
                //Console.Clear();
                
                Console.Write("Staff ID: ");
                asrt_Staff[i_indexEntry].s_ID = Console.ReadLine();

                Console.Write("Name: ");
                asrt_Staff[i_indexEntry].s_name = Console.ReadLine();

                Console.Write("Address: ");
                asrt_Staff[i_indexEntry].s_address = Console.ReadLine();

                Console.Write("Year Start: ");
                asrt_Staff[i_indexEntry].i_startYear = Convert.ToInt32(Console.ReadLine());


                if (i_indexEntry < 4)
                {
                    Console.WriteLine();
                    Console.Write("[" + (i_indexEntry + 1).ToString() + "/5] Continue [Y/N]: ");

                    if (Console.ReadKey().Key == ConsoleKey.N) { break; }

                    Console.WriteLine(); Console.WriteLine();
                }
            }


            Console.WriteLine(); Console.WriteLine();

            Console.Write("Staff ID: ");
            for (i_indexDisplay = 0; i_indexDisplay <= i_indexEntry; i_indexDisplay++)
            { Console.Write(asrt_Staff[i_indexDisplay].s_ID + " "); }

            Console.WriteLine();
            Console.Write("Name: ");
            for (i_indexDisplay = 0; i_indexDisplay <= i_indexEntry; i_indexDisplay++)
            { Console.Write(asrt_Staff[i_indexDisplay].s_name + " "); }

            Console.WriteLine();
            Console.Write("Address: ");
            for (i_indexDisplay = 0; i_indexDisplay <= i_indexEntry; i_indexDisplay++)
            { Console.Write(asrt_Staff[i_indexDisplay].s_address + " "); }

            Console.WriteLine();
            Console.Write("Year Start: ");
            for (i_indexDisplay = 0; i_indexDisplay <= i_indexEntry; i_indexDisplay++)
            { Console.Write(asrt_Staff[i_indexDisplay].i_startYear.ToString() + " "); }

            Console.WriteLine();
            Console.WriteLine("Total: " + (i_indexEntry+1).ToString() + " entries.");
        }
    }
}
