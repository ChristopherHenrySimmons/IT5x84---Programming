// Exercise 4.15 Solution: HeartRates.cs
// Maintains information about a person's maximum and target heart rates.
// This class assumes that the birth and current years are correct values.
public class HeartRates
{
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public int BirthYear { get; set; }
   public int CurrentYear { get; set; }

   // constructor
   public HeartRates(string firstName, string lastName, 
      int birthYear, int currentYear)
   {
      FirstName = firstName;
      LastName = lastName;
      BirthYear = birthYear;
      CurrentYear = currentYear;
   } // end constructor   

   // returns the person's age in years
   public int Age
   {
      get
      {
         return CurrentYear - BirthYear;
      } // end get
   } // end property Age

   // returns the maximum heart rate
   public int MaximumHeartRate
   {
      get
      {
         return 220 - Age;
      } // end get
   } // end property MaximumHeartRate

   // returns the minimum target heart rate (50% of maximum heart rate)
   public double MinimumTargetHeartRate
   {
      get
      {
         return .5 * MaximumHeartRate;
      } // end get
   } // end property MinimumTargetHeartRate

   // returns the maximum target heart rate (85% of maximum heart rate)
   public double MaximumTargetHeartRate
   {
      get
      {
         return .85 * MaximumHeartRate;
      } // end get
   } // end property MinimumTargetHeartRate
} // end class HeartRates



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
