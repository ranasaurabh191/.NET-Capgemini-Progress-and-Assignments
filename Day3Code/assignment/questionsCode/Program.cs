// 1: Write a C# program that determines if a given year is a leap year.
// The program should prompt the user to enter a year, use control statements to 
// determine if the year is a leap year, and print whether the year is a leap year or not.

//2: Write a C# program that reads a temperature in Celsius from the user, 
// converts it to Fahrenheit, and then prints both the original Celsius temperature and the converted Fahrenheit temperature.

//3: Write a C# program that reads a student’s exam score from the user and determines their grade based on the following grading scale:
// •	Score ≥ 90 : Grade A
// •	80 ≥ Score < 90 : Grade B
// •	70 ≥ Score < 80 : Grade C
// •	60 ≥ Score < 70 : Grade D
// •	Score < 60 : Grade F
// The program should use nested if statements to evaluate the input and print the corresponding grade.

//4: Write a C# program that calculates the factorial of a non-negative integer entered by the user.
// The program should continuously prompt the user for input until they enter the letter q to quit.
// The program should perform the following:
// Requirements:
// •	Prompt the user to enter a non-negative integer.
// •	Calculate the factorial of the entered number.
// •	Display the result to the user.
// •	If the user enters a negative integer, display an error message.
// •	If the user enters any non-numeric input other than q, display an error message.

//5 :Write a C# program that calculates and prints the sum of the first N natural numbers, where N is a positive integer entered by the user.
// Requirements:
// •	The program should prompt the user to enter a positive integer N.
// •	Use a for loop to calculate the sum of the first N natural numbers.
// •	Print the calculated sum to the console.

//6: Write a C# program that prints the first N even numbers, where N is a positive integer entered by the user.
// Requirements:
// •	The program should use a for loop to generate and print the even numbers.
// •	Print each even number on a separate line.

using System;

class Program
{
    public static void Main()
    {
        //1 Leap Year Program
        Console.WriteLine(":1) Leap Year Checker");
        int year;
        Console.WriteLine("Enter a year:");
        year = Convert.ToInt32(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
        //2 Temperature Conversion Program
        Console.WriteLine("\n2) Temperature Conversion");
        double celsius, fahrenheit;
        Console.WriteLine("Enter temperature in Celsius:"); 
        celsius = Convert.ToDouble(Console.ReadLine());
        fahrenheit = (celsius * 9 / 5) + 32;    
        Console.WriteLine("Temperature in Celsius: " + celsius);
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

        //3 Student Grade Program
        Console.WriteLine("\n3) Student Grade Determination");
        int score;
        Console.WriteLine("Enter student's exam score:");
        score = Convert.ToInt32(Console.ReadLine());
        if (score >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Grade F");
        }

        //4 Factorial Calculation Program
        Console.WriteLine("\n4) Factorial Calculation");
        Console.WriteLine("Enter a non-negative integer to calculate its factorial (or 'q' to quit):");
        // Loop to continuously prompt user for input
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "q"){ break; } // Exit loop if user enters 'q'
            int number;
            number = Convert.ToInt32(input);
            if (number >= 0)
            {
                if (number < 0)
                {
                    Console.WriteLine("Error: Please enter a non-negative integer.");
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("Factorial of " + number + " is: " + factorial);
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a non-negative integer or 'q' to quit.");
            }
        }
        //5 Sum of First N Natural Numbers Program
        Console.WriteLine("\n5) Sum of First N Natural Numbers");
        Console.WriteLine("Enter a positive integer N:");
        int numb = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= numb; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum of first " + numb + " natural numbers is: " + sum);


        //6 First N Even Numbers Program
        Console.WriteLine("\n6) First N Even Numbers");
        Console.Write("Enter a positive integer N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(2 * i);
        }
    }
}