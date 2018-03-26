using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i_DayNumber;
            //string s_DayName = "";

            string s_MonthName = "";
            string s_Message = "";

        BackAtOne:

            //Console.Write("Enter day number: ");
            //int.TryParse(Console.ReadLine(), out i_DayNumber);

            //switch (i_DayNumber)
            //{
            //    case 1:s_DayName = "Monday"; break;
            //    case 2: s_DayName = "Tuesday"; break;
            //    case 3: s_DayName = "Wednesday"; break;
            //    case 4: s_DayName = "Thursday"; break;
            //    case 5: s_DayName = "Friday"; break;
            //    case 6: s_DayName = "Saturday"; break;
            //    case 7: s_DayName = "Sunday"; break;
            //    default: s_DayName = "Invalid input"; break;
            //}

            //Console.WriteLine(s_DayName);
            //Console.ReadKey();
            //Console.Clear();

            Console.Write("Enter month name: ");
            s_MonthName = Console.ReadLine();

            switch (s_MonthName.ToLower())
            {
                case "january":
                case "february":
                case "march": s_Message = "1st Q"; break;

                case "april":
                case "may":
                case "june": s_Message = "2nd Q"; break;

                case "july":
                case "august":
                case "september": s_Message = "3rd Q"; break;

                case "october":
                case "november":
                case "december": s_Message = "4th Q"; break;

                default: s_Message = "Invalid input"; break;
            }

            Console.WriteLine(s_Message + Environment.NewLine);
     
            if (Console.ReadKey(true).Key == ConsoleKey.Y) { Console.Clear(); }

            goto BackAtOne;
        }
    }
}
