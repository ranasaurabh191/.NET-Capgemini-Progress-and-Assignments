// 13)/*program to read eno,ename,basic salary and calculate  
// pf,hra,da,net salary and gross salary and print eno,ename,basic 
// salary,
// gross salary and net salary*/

// pf= 12% of basic salary.
// hra=20% of basic salary.
// da= 15% of basic salary.
// gross salary=pf+hra+da+basic salary;
// net salary=gross salary - pf;
using System;
class Employee
{
    // Employee class implementation
    private int eno = 0;
    private string ename = "Not Assigned";
    private int basicSalary = 0;

    public int Eno
    {
        get { return eno; }
        set { eno = value; }
    }
    public string Ename
    {
        get { return ename; }
        set { ename = value; }
    }
    public int BasicSalary
    {
        get { return basicSalary; }
        set { basicSalary = value; }
    }
    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employee Number:");
        eno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name:");
        ename = Console.ReadLine();
        Console.WriteLine("Enter Basic Salary:");
        basicSalary = Convert.ToInt32(Console.ReadLine());
    }
    public void Pf()
    {
        Console.WriteLine("PF Amount: " + (basicSalary * 0.12));
    }
    public void Hra()
    {
        Console.WriteLine("HRA Amount: " + (basicSalary * 0.20));
    }
    public void Da()
    {
        Console.WriteLine("DA Amount: " + (basicSalary * 0.15));
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Number: " + eno);
        Console.WriteLine("Employee Name: " + ename);
        Console.WriteLine("Basic Salary: " + basicSalary);
        
    }

}