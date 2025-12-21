// 1)Sample C# program to print a welcome message
// 2)Write C# program to read a number user and display it */
// 3)Write C# program to read a floating point number from user 
// 4)Write C# program to read a string from user and display 
// it on the screen 
// 5)Write C# program to perform all arithmetic operations*/
// 6)Write C# program to find the area of circle */
// 7) program to find whether the given number is Even or Odd */
// 8)program to find the greatest of 2 numbers */
// 9) program to find whether a given number is positive ,negative or zero*/
// 10 program to find the greatest of three numbers using nested if*/ 
// 11) program to find the greatest of 3 numbers
// using conditional operator */
// 12)Write C#  program to print numbers from 1 to n(user input) 
// using while loop*/
// 13)Write C#  program to print even numbers from 1 to n(user input) 
// 14)Write C#  program to find the sum  of numbers from 1 to n
// (user input) 
// using while loop*/
// 15)Write C#  program to print multiplication table of 
// given number */
// 16) Write C#  program to calculate the power of a given number */
// 17)Write C#  program to generate fibbonacci 
// series(0 1 1 2 3 5 8 13 21 34 55...)
// upto n(user input)*/
// 18)Write C#  program to find whether the given number is Armstrong or
//  not
// 19)program to print armstrong numbers from n1 to n2
// 20) program to check whether the number is prime or 
// not */
// 21) program to read student num,name,mark of six subject and 
// calculate total and average and print result and division */
// 22)/*program to read eno,ename,basic salary and calculate  
// pf,hra,da,net salary and gross salary and print eno,ename,basic 
// salary,
// gross salary and net salary*/
// pf= 12% of basic salary.
// hra=20% of basic salary.
// da= 15% of basic salary.
// gross salary=pf+hra+da+basic salary;
// net salary=gross salary - pf;
// 23)C# Program to Print Odd Numbers in a Given Range
// =======================================================================
// 24)C# Program to Find the Sum of All the Multiples of 3 and 5
// This is a C# Program to print the sum of all the multiples of 3 and 5.


using System;

class Program
{
    static void Main(string[] args)
    {
        //1
        Console.WriteLine("Welcome");
        //2
        int number;
        Console.WriteLine("Enter a number: ");
        number =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You entered: " + number);
        //3
        float floatNumber;
        Console.WriteLine("Enter a floating point number: ");
        floatNumber = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("You entered float number: "+ floatNumber);
        //4
        string inputString;
        Console.WriteLine("Enter a string: ");
        inputString = Console.ReadLine() ?? "";
        Console.WriteLine("You entered string: "+inputString);
        //5
        int a,b;
        Console.WriteLine("Enter two numbers: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition: "+(a+b));
        Console.WriteLine("Subtraction: "+(a-b));
        Console.WriteLine("Multiplication: "+(a-b));
        Console.WriteLine("Division: "+(a/b));
        Console.WriteLine("Modulus: "+(a%b));
        //6
        Console.WriteLine("Enter radius of circle: ");
        float radius;
        radius = Convert.ToSingle(Console.ReadLine());
        float area = 3.14f * radius * radius;
        Console.WriteLine("Area of circle: "+area);
        //7
        int num;
        Console.WriteLine("Enter a number to check even/odd: ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0)
        {
            Console.WriteLine(num + " is Even");
        }
        else
        {
            Console.WriteLine(num + " is Odd");
        }
        //8
        int num1, num2;
        Console.WriteLine("Enter two numbers to find the greatest: ");      
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        if(num1 > num2)
        {
            Console.WriteLine(num1 + " is greater than " + num2);
        }
        else
        {
            Console.WriteLine(num2 + " is greater than " + num1);           
        }
        //9
        int numberCheck;
        Console.WriteLine("Enter a number to check positive, negative or zero: ");
        numberCheck = Convert.ToInt32(Console.ReadLine());
        if(numberCheck > 0)
        {
            Console.WriteLine(numberCheck + " is Positive");
        }
        else if(numberCheck < 0)
        {
            Console.WriteLine(numberCheck + " is Negative");
        }
        else
        {
            Console.WriteLine("The number is Zero");
        }
        //10
        int n1, n2, n3;
        Console.WriteLine("Enter three numbers to find the greatest: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        if(n1 >= n2)
        {
            if(n1 >= n3)
            {
                Console.WriteLine(n1 + " is the greatest number");
            }
            else
            {
                Console.WriteLine(n3 + " is the greatest number");
            }
        }
        else
        {
            if(n2 >= n3)
            {
                Console.WriteLine(n2 + " is the greatest number");
            }
            else
            {
                Console.WriteLine(n3 + " is the greatest number");
            }
        }
        //11
        int x,y,z;
        Console.WriteLine("Enter three numbers to find the greatest using conditional operator: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        z = Convert.ToInt32(Console.ReadLine());
        int max;
        if (x > y)
        {
            max = (x > z) ? x : z;
        }
        else
        {
            max = (y > z) ? y : z;
        }
        Console.WriteLine(max + " is the greatest number");

        //12
        int n;
        Console.WriteLine("Enter a number n to print numbers from 1 to n: ");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        //13
        Console.WriteLine("Enter a number n to print even numbers from 1 to n: ");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        //14
        int sum = 0;
        Console.WriteLine("Enter a number n to find the sum of numbers from 1 to n: ");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum of numbers from 1 to " + n + " is: " + sum);

        //15
        int tableNumber;
        Console.WriteLine("Enter a number to print its multiplication table: ");    
        tableNumber = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(tableNumber + " x " + i + " = " + (tableNumber * i));
        }
        //16
        int baseNum, exponent;
        Console.WriteLine("Enter base number: ");   
        baseNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter exponent: ");
        exponent = Convert.ToInt32(Console.ReadLine());
        double power = Math.Pow(baseNum, exponent);
        Console.WriteLine(baseNum + " raised to the power of " + exponent + " is: " + power);
        //17
        int fiboTerms;
        Console.WriteLine("Enter number of terms for Fibonacci series: ");
        fiboTerms = Convert.ToInt32(Console.ReadLine());
        int a1 = 0, b1 = 1, c;
        Console.WriteLine("Fibonacci Series:");
        for(int i = 1; i <= fiboTerms; i++)
        {
            Console.WriteLine(a);
            c = a1 + b1;
            a1 = b1;
            b1 = c;
        }
        //18
        int armstrongNum, sumOfCubes = 0, temp, digit;
        Console.WriteLine("Enter a number to check if it is Armstrong or not: ");
        armstrongNum = Convert.ToInt32(Console.ReadLine());
        temp = armstrongNum;
        while(temp != 0)
        {
            digit = temp % 10;
            sumOfCubes += digit * digit * digit;
            temp /= 10;
        }
        if(sumOfCubes == armstrongNum)
        {
            Console.WriteLine(armstrongNum + " is an Armstrong number");
        }
        else
        {
            Console.WriteLine(armstrongNum + " is not an Armstrong number");
        }
        //19
        int s1, s2;
        Console.WriteLine("Enter two numbers (n1 and n2) to print Armstrong numbers between them: ");
        s1 = Convert.ToInt32(Console.ReadLine());
        s2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Armstrong numbers between " + s1 + " and " + s2 + " are:");
        for(int i = s1; i <= s2; i++)
        {
            int sumCubes = 0, tempNum = i, dig;
            while(tempNum != 0)
            {
                dig = tempNum % 10;
                sumCubes += dig * dig * dig;
                tempNum /= 10;
            }
            if(sumCubes == i)
            {
                Console.WriteLine(i);
            }
        }
        //20
        int pnum;
        Console.WriteLine("Enter a number to check if it is prime or not: ");
        pnum = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if(pnum <= 1)
        {
            isPrime = false;
        }
        else
        {
            for(int i = 2; i <= Math.Sqrt(pnum); i++)
            {
                if(pnum % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if(isPrime)
        {
            Console.WriteLine(pnum + " is a prime number");
        }
        else
        {
            Console.WriteLine(pnum + " is not a prime number");
        }
        //21
        int eno, mark1, mark2, mark3, mark4, mark5, mark6, total;
        string ename;
        Console.WriteLine("Enter student number: ");
        eno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter student name: ");
        ename = Console.ReadLine() ?? "";
        Console.WriteLine("Enter marks of six subjects: ");
        mark1 = Convert.ToInt32(Console.ReadLine());
        mark2 = Convert.ToInt32(Console.ReadLine());
        mark3 = Convert.ToInt32(Console.ReadLine());
        mark4 = Convert.ToInt32(Console.ReadLine());
        mark5 = Convert.ToInt32(Console.ReadLine());
        mark6 = Convert.ToInt32(Console.ReadLine());
        total = mark1 + mark2 + mark3 + mark4 + mark5 + mark6;
        float average = total / 6.0f;
        Console.WriteLine("Student Number: " + eno);
        Console.WriteLine("Student Name: " + ename);
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average Marks: " + average);
        //22
        int empNo;
        string empName;
        float basicSalary;
        Console.WriteLine("Enter Employee Number: ");
        empNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name: ");
        empName = Console.ReadLine() ?? "";
        Console.WriteLine("Enter Basic Salary: ");
        basicSalary = Convert.ToSingle(Console.ReadLine());
        float pf = 0.12f * basicSalary;
        float hra = 0.20f * basicSalary;
        float da = 0.15f * basicSalary;
        float grossSalary = basicSalary + pf + hra + da;
        float netSalary = grossSalary - pf;
        Console.WriteLine("Employee Number: " + empNo);
        Console.WriteLine("Employee Name: " + empName);
        Console.WriteLine("Basic Salary: " + basicSalary);
        Console.WriteLine("Gross Salary: " + grossSalary);
        Console.WriteLine("Net Salary: " + netSalary);
        //23
        int rangeStart, rangeEnd;
        Console.WriteLine("Enter the start and end of the range to print odd numbers: ");   
        rangeStart = Convert.ToInt32(Console.ReadLine());
        rangeEnd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Odd numbers between " + rangeStart + " and " + rangeEnd + " are:");
        for(int i = rangeStart; i <= rangeEnd; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        //24
        int limit;
        Console.WriteLine("Enter a number to find the sum of all multiples of 3 and 5 below it: ");
        limit = Convert.ToInt32(Console.ReadLine());
        int sumMultiples = 0;
        for(int i = 0; i < limit; i++)
        {
            if(i % 3 == 0 || i % 5 == 0)
            {
                sumMultiples += i;
            }
        }
        Console.WriteLine("Sum of all multiples of 3 and 5 below " + limit + " is: " + sumMultiples);


    }
}