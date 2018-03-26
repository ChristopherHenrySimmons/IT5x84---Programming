// Exercise 4.13 Solution: EmployeeTest.cs
// Application to test class Employee.
using System;

public class EmployeeTest
{
   public static void Main( string[] args )
   {
      EmployeeNOW employee1 = new EmployeeNOW( "Bob", "Jones", 2875.00M );
      EmployeeNOW employee2 = new EmployeeNOW( "Susan", "Baker", 3150.75M );

        // display employees
        Console.WriteLine("Employee 1: {0} {1}; Gross Yearly Salary: {2:C}",
           employee1.FirstName, employee1.LastName,
           12 * employee1.MonthlySalary);
        Console.WriteLine("Net yearly salary after tax: {0:C}", 12 * employee1.MonthlySalaryWithTax());

        Console.WriteLine();

        Console.WriteLine("Employee 2: {0} {1}; Gross Yearly Salary: {2:C}",
         employee2.FirstName, employee2.LastName,
         12 * employee2.MonthlySalary);
        Console.WriteLine("Net yearly salary after tax: {0:C}", 12 * employee2.MonthlySalaryWithTax());

        //// increase employee salaries by 10%
        //Console.WriteLine( "\nIncreasing employee salaries by 10%" );
        //employee1.MonthlySalary = employee1.MonthlySalary * 1.10M;
        //employee2.MonthlySalary = employee2.MonthlySalary * 1.10M;
        Console.Write("Enter increment % (for Bob): ");
        employee1.d_incrementRate = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter increment % (for Susan): ");
        employee2.d_incrementRate = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine();

        // display employees with new yearly salary
        Console.WriteLine( "Employee 1: {0} {1}; After Tax Yearly Salary: {2:C}",
         employee1.FirstName, employee1.LastName,
         12 * employee1.MonthlySalaryWithTax() );
      Console.WriteLine("Employee 2: {0} {1}; After Tax Yearly Salary: {2:C}",
         employee2.FirstName, employee2.LastName,
         12 * employee2.MonthlySalaryWithTax());
   } // end Main
} // end class EmployeeTest


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
