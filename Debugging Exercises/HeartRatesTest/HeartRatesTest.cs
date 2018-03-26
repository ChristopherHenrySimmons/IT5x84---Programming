// Exercise 4.15 Solution: HeartRatesTest.cs
// Tests class HeartRates.
using System;

public class HeartRatesTest
{
   public static void Main( string[] args )
   {
      // create a HeartRates object for a person born in 1975;
      // rates calculated based on current year 2010.
      HeartRates bob = new HeartRates( "Bob", "Blue", 1975, 2010 );
      
      Console.WriteLine( "First name: {0}", bob.FirstName );
      Console.WriteLine( "Last name: {0}", bob.LastName );
      Console.WriteLine( "Age: {0}", bob.Age );
      Console.WriteLine( "Maximum heart rate: {0}", bob.MaximumHeartRate );
      Console.WriteLine( "Target heart rate range:" );
      Console.WriteLine( "   Minimum: {0}", bob.MaximumHeartRate );
      Console.WriteLine( "   Maximum: {0}", bob.MaximumTargetHeartRate );
   } // end Main
} // end class HeartRatesTest


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
