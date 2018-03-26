using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //double d_temperature;

            //Console.Write("Enter temperature: ");
            //double.TryParse(Console.ReadLine(), out d_temperature);

            //if (d_temperature < 0) { Console.WriteLine("It's freezing"); };



            double d_temperature;
            string s_message = "";

            Console.Write("Enter temperature: ");
            double.TryParse(Console.ReadLine(), out d_temperature);

            //if (d_temperature <= 0) { s_message = "It's freezing"; };
            //if (d_temperature > 0 && d_temperature <= 4) { s_message = "Anomaly"; }

            if (d_temperature <= 0) { s_message = "Freezing"; };

            if (d_temperature > 0) { s_message = "Anomaly"; };
            if (d_temperature > 4) { s_message = "Cold"; };
            if (d_temperature > 16) { s_message = "Cool"; };
            if (d_temperature > 25) { s_message = "Warm"; };
            if (d_temperature > 40) { s_message = "Hot"; };

            if (d_temperature >= 100) { s_message = "Boiling"; };

            Console.WriteLine(s_message);
            //Console.ReadKey();
        }
    }
}
