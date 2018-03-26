using System;

public class EmployeeNOW : Employee
{
    public decimal d_taxRate = 28;
    public decimal d_incrementRate;

    public EmployeeNOW(string first, string last, decimal salary) : base(first, last, salary)
    {
        FirstName = first;
        LastName = last;
        MonthlySalary = salary;
    }
    public decimal MonthlySalaryWithTax()
        {
        return (MonthlySalary * (1 + d_incrementRate/100)) * (1 - d_taxRate/100);
        }
}

