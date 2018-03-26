using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6___Structure
{
    class Program
    {
        private struct strPerson
        {
            public int i_age;
            public string s_name;
            public string s_address;
            public double d_income; 
            public int i_postcode;
        }

        static void Main(string[] args)
        {
            int i_loop;

            strPerson[] astr_Staff = new strPerson[5];

            astr_Staff[0].i_age = 61;
            astr_Staff[1].i_age = 31;
            astr_Staff[2].i_age = 51;
            astr_Staff[3].i_age = 21;
            astr_Staff[4].i_age = 11;
             
            astr_Staff[0].s_name = "Iwan";
            astr_Staff[1].s_name = "Kate";
            astr_Staff[2].s_name = "Jane";
            astr_Staff[3].s_name = "Mike";
            astr_Staff[4].s_name = "John";

            for (i_loop = 0; i_loop < 5; i_loop++)
            { Console.WriteLine(astr_Staff[i_loop].i_age.ToString() + ", " + astr_Staff[i_loop].s_name); }


            //Array.Sort<strPerson>(astr_Staff, (temp1, temp2) => temp1.i_age.CompareTo(temp2.i_age));
            Array.Sort<strPerson>(astr_Staff,(temp1,temp2) => temp1.s_name.CompareTo(temp2.s_name));

            Console.WriteLine();

            for (i_loop = 0; i_loop < astr_Staff.Length; i_loop++)
            { Console.WriteLine(astr_Staff[i_loop].i_age.ToString() + ", " + astr_Staff[i_loop].s_name); }



            //strPerson str_Iwan = new strPerson();

            //Console.Write("Enter age: ");
            //str_Iwan.i_age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter name: ");
            //str_Iwan.s_name = Console.ReadLine();

            //Console.Write("Enter address: ");
            //str_Iwan.s_address = Console.ReadLine();

            //Console.Write("Enter income: ");
            //str_Iwan.d_income = Convert.ToDouble(Console.ReadLine());

            //str_Iwan.i_postcode = str_Iwan.i_age + 50;

            //Console.WriteLine();
            //Console.WriteLine("Age is: " + str_Iwan.i_age.ToString());
            //Console.WriteLine("Name is: " + str_Iwan.s_name);
            //Console.WriteLine("Address is: " + str_Iwan.s_address);
            //Console.WriteLine("Income is: " + str_Iwan.d_income.ToString());
            //Console.WriteLine("Postcode is: " + str_Iwan.i_postcode.ToString());




            //int i_age;
            //string s_name;
            //string s_address;
            //double d_income;

            //Console.Write("Enter age: ");
            //i_age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter name: ");
            //s_name = Console.ReadLine();

            //Console.Write("Enter address: ");
            //s_address = Console.ReadLine();

            //Console.Write("Enter income: ");
            //d_income = Convert.ToDouble(Console.ReadLine());


            //Console.WriteLine();
            //Console.WriteLine("Age is: " + i_age.ToString());
            //Console.WriteLine("Name is: " + s_name);
            //Console.WriteLine("Address is: " + s_address);
            //Console.WriteLine("Income is: " + d_income.ToString());



        }
    }
}
