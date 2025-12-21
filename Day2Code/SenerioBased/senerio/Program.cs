// 1)program to print numbers from 1 to 5(R to L)

//      1
//     12
//     123
//    1234
//    12345

// 2)
// program to print the output as following 

//      *
//     **
//    *
//   **
//  ***

// */

// 3)
// program to read student details (no, name,marks)using do 
// while loop by accepting details till user enter y as an 
// input */

// 4)
// C# Program to Print All the Multiples of 17 which are Less than 100
// This is a C# Program to print all the multiples of 17 which are less than 100.

// 5) Sum of Digits Program in C#
// This is a C# Program to get a number and display the sum of the digits.
// Problem Description
// This C# Program Gets a Number and Display the Sum of the Digits.
// Runtime Test Cases
// Enter a Number : 123
// Sum of Digits of the Number : 6 
// Problem Solution
// The digit sum of a given integer is the sum of all its digits.
// Program/Source Code
// Write the  source code of the C# Program to Get a Number and Display the Sum of the Digits. The C# program is successfully compiled and executed with Microsoft Visual Studio. The program output is also shown below.
// Runtime Test Cases
// Enter a Number : 123
// Sum of Digits of the Number : 6

using System;
class Program
{
    public static void Main()
    {
        //1
        for(int i=1; i<=5; i++)
        {
            for(int j=5; j>i; j--)
            {
                Console.Write(" ");
            }
            for(int k=1; k<=i; k++)
            {
                Console.Write(k+" ");
            }
            Console.WriteLine();
        }
        //2
        Console.WriteLine();
        for(int i=1; i<=3; i++)
        {
            for(int j=3; j>=i; j--)
            {
                Console.Write(" ");
            }
            for(int k=1; k<=i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        //3
        char choice;
        do
        {
            Console.Write("Enter Student No: ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter Student Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Student Details: No={no}, Name={name}, Marks={marks}");
            Console.Write("(y/n): ");
            choice = Convert.ToChar(Console.ReadLine());
        } while (choice == 'y');

        //4
        Console.WriteLine("Multiples of 17 are :");
        for(int i=17; i<100; i+=17)
        {
            Console.WriteLine(i);
        }
        //5
        Console.Write("Enter a Number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while(number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine("Sum of Digits of the Number : " + sum);
    }
}