using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV___Reading_1_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] as_CourseCode = System.IO.File.ReadAllText("Q:\\IT5x84\\SampleCSV.soi").Split(';');

            for (int i_index = 0; i_index < as_CourseCode.Length; i_index++)
            { Console.WriteLine(as_CourseCode[i_index].ToString()); }
            
        }
    }
}
