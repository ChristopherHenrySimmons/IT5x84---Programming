using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV___Reading_Multi_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] as_AllCoursesByLine = System.IO.File.ReadAllLines("Q:\\IT5x84\\SampleMultiCSV.soi");

            string[,] as_Courses = new string[5, as_AllCoursesByLine.Length];

            for (int i_LineIndex = 0; i_LineIndex < as_AllCoursesByLine.Length; i_LineIndex++)
            { 
                string[] as_temp = as_AllCoursesByLine[i_LineIndex].Split(';');

                as_Courses[0, i_LineIndex] = as_temp[0];
                as_Courses[1, i_LineIndex] = as_temp[1];
                as_Courses[2, i_LineIndex] = as_temp[2];
                as_Courses[3, i_LineIndex] = as_temp[3];
                as_Courses[4, i_LineIndex] = as_temp[4];
            }

            Console.WriteLine(as_Courses[2,4]);
        }
    }
}
