using System;

class Program
{
    static void Main()
    {
        // 44) Program to read a string and display it on the screen
        Console.WriteLine("\n44) Output: Read a string and display it");
        string s = "Hello";
        Console.WriteLine(s);

        // 45) Program to read 10 strings and display them on the screen
        Console.WriteLine("\n45) Output: Read 10 strings and display them");
        string[] strs = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
        for (int i = 0; i < 10; i++)
            Console.Write(strs[i]+" ");

        // 46a) Program to accept 2x2 matrices and display in matrix form
        Console.WriteLine("\n\n46a) Output: Display 2x2 matrix");
        int[,] a = { { 1, 2 }, { 3, 4 } };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(a[i, j] + " ");
            Console.WriteLine();
        }

        // 46b) Program to add 2 matrices
        Console.WriteLine("\n46b) Output: Addition of two matrices");
        int[,] b = { { 5, 6 }, { 7, 8 } };
        int[,] sum = new int[2, 2];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                sum[i, j] = a[i, j] + b[i, j];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(sum[i, j] + " ");
            Console.WriteLine();
        }

        // 47) Program to find the largest and smallest element in the array
        Console.WriteLine("\n47) Output: Largest and smallest element in array");
        int[] arr = { 10, 5, 20, 3, 15 };
        int max = arr[0], min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        Console.WriteLine(max);
        Console.WriteLine(min);

        // 48) Program for matrix multiplication (2x2)
        Console.WriteLine("\n48) Output: Matrix multiplication (2x2)");
        int[,] mul = new int[2, 2];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    mul[i, j] += a[i, k] * b[k, j];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(mul[i, j] + " ");
            Console.WriteLine();
        }

        // 49) Program to find transpose of a matrix
        Console.WriteLine("\n49) Output: Transpose of matrix");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(a[j, i] + " ");
            Console.WriteLine();
        }

        // 50) Program to check whether the given matrix is a diagonal matrix or not
        Console.WriteLine("\n50) Output: Check diagonal matrix");
        int[,] d = { { 1, 0 }, { 0, 5 } };
        bool diagonal = true;
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                if (i != j && d[i, j] != 0)
                    diagonal = false;
        Console.WriteLine(diagonal);

        // 51) Program to reverse the contents of a string using string function
        Console.WriteLine("\n51) Output: Reverse string using string function");
        char[] ch = s.ToCharArray();
        Array.Reverse(ch);
        Console.WriteLine(new string(ch));

        // 52) Program to reverse the contents of a string without using string function
        Console.WriteLine("\n52) Output: Reverse string without string function");
        for (int i = s.Length - 1; i >= 0; i--)
            Console.Write(s[i]);
        Console.WriteLine();

        // 53) Program to convert from lower letter to upper letter and vice versa
        Console.WriteLine("\n53 & 54) Output: Toggle case of string");
        char[] cArr = s.ToCharArray();
        for (int i = 0; i < cArr.Length; i++)
        {
            if (cArr[i] >= 'a' && cArr[i] <= 'z')
                cArr[i] = (char)(cArr[i] - 32);
            else if (cArr[i] >= 'A' && cArr[i] <= 'Z')
                cArr[i] = (char)(cArr[i] + 32);
        }
        Console.WriteLine(new string(cArr));

        // 54) Program to convert a string to uppercase and lowercase without using string functions
        // (Handled in the same logic as above using ASCII manipulation)

        // 55) Program to compare 2 strings using standard library functions
        Console.WriteLine("\n55) Output: Compare strings using library function");
        string s1 = "Test";
        string s2 = "Test";
        Console.WriteLine(s1.Equals(s2));

        // 56) Program to compare 2 strings without using standard library functions
        Console.WriteLine("\n56) Output: Compare strings without library function");
        bool equal = true;
        if (s1.Length != s2.Length)
            equal = false;
        else
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] != s2[i])
                    equal = false;
        Console.WriteLine(equal);

        // 57) Program to concatenate 2 strings using standard library functions
        Console.WriteLine("\n57) Output: Concatenate strings using library function");
        Console.WriteLine(s1 + s2);

        // 58) Program to concatenate 2 strings without using standard library functions
        Console.WriteLine("\n58) Output: Concatenate strings without library function");
        string result = "";
        foreach (char x in s1)
            result += x;
        foreach (char x in s2)
            result += x;
        Console.WriteLine(result);

        // 59) Program to search a string in main string
        Console.WriteLine("\n59) Output: Search string in main string");
        Console.WriteLine("Hello World".Contains("World"));
    }
}
