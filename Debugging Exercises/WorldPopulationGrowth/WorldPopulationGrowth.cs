// Exercise 5.40 Solution: WorldPopulationGrowth.cs
// Based on the current annual population growth rate and current
// world population, calculate the world population.
using System;

public class WorldPopulationGrowth 
{
   public static void Main( string[] args )
   {
      double currentPopulation; // today's world population
      double growthRate; // growth rate (1.14% would be .0114)
      double futurePopulation; // future population based on growth rate

      Console.WriteLine( "Welcome to the world population calculator" );
      Console.Write( "Enter the current world population: " );
      currentPopulation = Convert.ToDouble( Console.ReadLine() );
      Console.Write( 
         "Enter the current growth rate: (e.g, 1.14% would be .0114): " );
      growthRate = Convert.ToDouble( Console.ReadLine() );

      int year = 1; // year counter 
      Console.WriteLine( 
         "Year\tEstimated Population\tChange from prior Year" );
      
      while ( year <= 75 )
      {
         futurePopulation = currentPopulation * ( 1 + growthRate );
         Console.WriteLine( "{0}\t{1:F0}\t\t{2:F0}", 
            year, futurePopulation, 
            futurePopulation - currentPopulation );
         currentPopulation = futurePopulation; // keep track 
         ++year;
      } // end while
   } // end Main 
} // end class WorldPopulationGrowth


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
