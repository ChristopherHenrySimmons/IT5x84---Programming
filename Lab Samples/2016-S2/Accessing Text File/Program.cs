using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessing_Text_File
{
    class Program
    {
        private static void m_ReadAsWhole(string FilePath)
        {
            //Read  textfile as a whole
            string s_File;
            s_File = System.IO.File.ReadAllText(FilePath);
            Console.WriteLine(s_File);
        }

        private static void m_ReadLineByLine (string FilePath)
        {
            string[] as_FileLineByLine = System.IO.File.ReadAllLines(FilePath);

            for (int i_index = 0; i_index < as_FileLineByLine.Length; i_index++)
            { Console.WriteLine(as_FileLineByLine[i_index]); }

            Console.WriteLine(as_FileLineByLine[2]);
        }

        private static void m_AppendLineToFile (string FilePath)
        {
            Console.Write("Enter data: ");
            string s_Data = Environment.NewLine + Console.ReadLine();

            System.IO.File.AppendAllText(FilePath, s_Data);
        }
        static void Main(string[] args)
        {
        StartPoint:

            m_ReadAsWhole("Q:\\IT5x84\\SampleText.soi");

            //m_ReadLineByLine("SampleText.soi");

            m_AppendLineToFile("Q:\\IT5x84\\SampleText.soi");

            m_ReadAsWhole("Q:\\IT5x84\\SampleText.soi");

            Console.ReadKey(); Console.Clear();
            goto StartPoint;
        }
    }
}
