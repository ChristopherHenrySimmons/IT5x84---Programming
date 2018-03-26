// Exercise 5.24 Solution: Analysis.cs
// Application performs analysis of examination results.
using System;

public class Analysis
{
   // analyze the results of 10 tests
   public static void Main( string[] args )
   {
        // initializing variables in declarations
        try
        {
            double passes = 0; // number of passes
            int failures = 0; // number of failures
            int studentCounter = 1; // student counter
            int result; // one exam result

            Console.Write("Enter number of loop: ");
            double i_totalLoop = Convert.ToInt32(Console.ReadLine());

            // process 10 students using counter-controlled loop
            //while ( studentCounter <= 10 )
            for (studentCounter = 1; studentCounter <= i_totalLoop; studentCounter++)
            {
                // prompt user for input and obtain value from user
                Console.Write("Enter result (1 = pass, 2 = fail): ");
                result = Convert.ToInt32(Console.ReadLine());

                // if...else nested in while 
                if (result == 1)
                {
                    ++passes;
                    //++studentCounter;
                } // end if
                else if (result == 2)
                {
                    ++failures;
                    //++studentCounter;
                } // end else if
                else
                    Console.WriteLine("Invalid Input");
            } // end while

            // termination phase; prepare and display results
            Console.WriteLine("Passed: {0}\nWill keep trying: {1}", passes, failures);

            // determine whether more than 8 students passed
            //if (passes > 8)
            if ((passes/ (passes+failures)) < (0.85))
                Console.WriteLine("Must try harder next time. No one should be left behind.");
        }
        catch { }
   } // end Main
} // end class Analysis


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
