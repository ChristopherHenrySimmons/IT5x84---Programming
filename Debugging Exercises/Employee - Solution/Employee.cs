// Exercise 4.13 Solution: Employee.cs
// Employee class.

public class Employee
{
   // auto-implemented property FirstName implicitly creates an
   // instance variable for the employee's first name
   public string FirstName { get; set; }

   // auto-implemented property LastName implicitly creates an
   // instance variable for the employee's last name
   public string LastName { get; set; }

   private decimal monthlySalary;

   // constructor to initialize first name, last name and monthly salary
   public Employee( string first, string last, decimal salary )
   {
      FirstName = first;
      LastName = last;
      MonthlySalary = salary;
   } // end three-parameter Employee constructor
   
   // property to get and set the salary
   public decimal MonthlySalary
   {
      get
      {
         return monthlySalary;
      } // end get
      set
      {
         if ( value >= 0 ) // determine whether salary is nonnegative
            monthlySalary = value;
      } // end set
   } // end property MonthlySalary
} // end class Employee


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
