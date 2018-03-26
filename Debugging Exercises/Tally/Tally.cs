// Exercise 3.30 Solution: Tally.cs
// Application accepts five numbers as input and displays a tally of the 
// number of negatives, positives and zeros.
using System;

public class Tally
{
   public static void Main( string[] args )
   {
      int inputNumber; // stores user input
      int zeroTally; // count of 0s
      int positiveTally; // count of positive values
      int negativeTally; // count of negative values

      // initialize counters
      zeroTally = 0;
      positiveTally = 0;
      negativeTally = 0;

      // prompt for input and read first number
      Console.Write( "Enter first integer: " );
      inputNumber = Convert.ToInt32( Console.ReadLine() );

      // is the number 0?
      if ( inputNumber == 0 )
         zeroTally = zeroTally + 1;

      // is the number negative?
      if ( inputNumber < 0 )
         negativeTally = negativeTally + 1;

      // is the number positive?
      if ( inputNumber > 0 )
         positiveTally = positiveTally + 1;

      // prompt for input and read second number
      Console.Write( "Enter second integer: " );
      inputNumber = Convert.ToInt32( Console.ReadLine() );

      // is the number 0?
      if ( inputNumber == 0 )
         zeroTally = zeroTally + 1;

      // is the number negative?
      if ( inputNumber < 0 )
         negativeTally = negativeTally + 1;

      // is the number positive?
      if ( inputNumber > 0 )
         positiveTally = positiveTally + 1;

      // prompt for input and read third number
      Console.Write( "Enter third integer: " );
      inputNumber = Convert.ToInt32( Console.ReadLine() );

      // is the number 0?
      if ( inputNumber == 0 )
         zeroTally = zeroTally + 1;

      // is the number negative?
      if ( inputNumber < 0 )
         negativeTally = negativeTally + 1;

      // is the number positive?
      if ( inputNumber > 0 )
         positiveTally = positiveTally + 1;

      // prompt for input and read fourth number
      Console.Write( "Enter fourth integer: " );
      inputNumber = Convert.ToInt32( Console.ReadLine() );

      // is the number 0?
      if ( inputNumber == 0 )
         zeroTally = zeroTally + 1;

      // is the number negative?
      if ( inputNumber < 0 )
         negativeTally = negativeTally + 1;

      // is the number positive?
      if ( inputNumber > 0 )
         positiveTally = positiveTally + 1;

      // prompt for input and read fifth number
      Console.Write( "Enter fifth integer: " );
      inputNumber = Convert.ToInt32( Console.ReadLine() );

      // is the number 0?
      if ( inputNumber == 0 )
         zeroTally = zeroTally + 1;
       
      // is the number negative?
      if ( inputNumber < 0 )
         negativeTally = negativeTally + 1;

      // is the number positive?
      if ( inputNumber > 0 )
         positiveTally = positiveTally + 1;

      // create a string describing the results
      Console.WriteLine( "\nThere are {0} zeros", zeroTally );
      Console.WriteLine( "There are {0} positive numbers",
         positiveTally );
      Console.WriteLine( "There are {0} negative numbers",
         negativeTally );
   } // end Main 
} // end class Tally


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
