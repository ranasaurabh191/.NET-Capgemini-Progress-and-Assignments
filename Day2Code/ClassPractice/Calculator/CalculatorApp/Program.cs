using System;
class Program
{   
    // int number1;
    // int number2;
    // int result;
    public static void Main()
    {
    //     Program p = new Program();
    //     Console.WriteLine("Select Operation to Perform: ");
    //     Console.WriteLine("1. Addition");
    //     Console.WriteLine("2. Subtraction");
    //     Console.WriteLine("3. Multiplication");
    //     Console.WriteLine("4. Division");
    //     Console.WriteLine("5. Modulus");
    //     Console.Write("Enter your choice (1-5): ");

    //     int choice = Convert.ToInt32(Console.ReadLine());
    //     switch(choice)
    //     {
    //         case 1:
    //             p.Add();
    //             break;
    //         case 2:
    //             p.Subtract();
    //             break;
    //         case 3:
    //             p.Mulitiply();
    //             break;
    //         case 4:
    //             p.Divide();
    //             break;
    //         case 5:
    //             p.Modulus();
    //             break;
    //         default:
    //             Console.WriteLine("Invalid Choice");
    //             break;
    //     }
    
       
        // int i=0;
        // while (i <= 10)
        // {
        //     Console. WriteLine($"Value of i: {i}");
        //     i++;
        // }



        // int i=10;
        // while(i > 0)
        // {
        //     Console. WriteLine($"Value of i: {i}");
        //     i--;
        // }



        // for(int i=0; i<=10; i++)
        // {
        //     Console. WriteLine($"Value of i: {i}");
        // }


        // for(int i=10; i>0; i--)
        // {
        //     Console. WriteLine($"Value of i: {i}");
        // }


        int[] arr = {10,20,30,40,50,60,70,80,90,100};
        // foreach(int i in arr)
        // {
        //     Console. WriteLine($"Value of i: {i}");
        // }

        // for(int i=0; i<arr.Length; i++)
        // {
        //     Console. WriteLine($"Value of arr[{i}]: {arr[i]}");
        // }
        int i = 0;
        while (i < arr.Length)
        {
            Console. WriteLine($"Value of arr[{i}]: {arr[i]}");
            i++;        
        }




        
    }
    // public void Add()
    // {
    //     Console.Write("Enter First Number: ");
    //     number1=Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Enter Second Number: ");
    //     number2=Convert.ToInt32(Console.ReadLine());
    //     result = number1+number2;
    //     Console.WriteLine($"Sum of {number1} and {number2} is {result}");
    // }
    // public void Subtract()
    // {
    //     Console.Write("Enter First Number: ");
    //     number1=Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Enter Second Number: ");
    //     number2=Convert.ToInt32(Console.ReadLine());
    //     result = number1-number2;
    //     Console.WriteLine($"Difference of {number1} and {number2} is -> {result}");
    // }
    // public void Mulitiply()
    // {
    //     Console.Write("Enter First Number: ");
    //     number1=Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Enter Second Number: ");
    //     number2=Convert.ToInt32(Console.ReadLine());
    //     result = number1*number2;
    //     Console.WriteLine($"Product of {number1} and {number2} is -> {result}");
    // }
    // public void Divide()
    // {
    //     Console.Write("Enter First Number: ");
    //     number1=Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Enter Second Number: ");
    //     number2=Convert.ToInt32(Console.ReadLine());
    //     result = number1/number2;
    //     Console.WriteLine($"Division of {number1} and {number2} is -> {result}");
    // }
    // public void Modulus()
    // {
    //     Console.Write("Enter First Number: ");
    //     number1=Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Enter Second Number: ");
    //     number2=Convert.ToInt32(Console.ReadLine());
    //     result = number1%number2;
    //     Console.WriteLine($"Modulus of {number1} and {number2} is -> {result}");
    // }
}