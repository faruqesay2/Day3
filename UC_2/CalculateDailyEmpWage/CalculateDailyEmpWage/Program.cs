using System.Collections.Generic;

public class Employee
{
    int ID;
    string Name;
    int Salary;
    string Department;

    static void Main(string[] args)
    {
        int TotalSalary = 0;

        List<Employee> employees = new List<Employee>()
        {