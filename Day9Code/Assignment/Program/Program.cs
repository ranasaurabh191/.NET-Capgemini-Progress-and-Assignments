using System;

class Program
{
    static void Main()
    {
        //1. Store and Print Array
        int[] arr1 = new int[10];
        Console.WriteLine("Enter 10 elements:");
        for (int i = 0; i < arr1.Length; i++)
            arr1[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Elements in array are: ");
        for (int i = 0; i < arr1.Length; i++)
            Console.Write(arr1[i] + " ");
        Console.WriteLine("\n");

        // 2. Reverse Array 
        Console.Write("Enter number of elements: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[n2];

        for (int i = 0; i < n2; i++)
            arr2[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Original: ");
        for (int i = 0; i < n2; i++)
            Console.Write(arr2[i] + " ");

        Console.Write("\nReverse: ");
        for (int i = n2 - 1; i >= 0; i--)
            Console.Write(arr2[i] + " ");
        Console.WriteLine("\n");

        //3. Sum of Array 
        Console.Write("Enter number of elements: ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        int[] arr3 = new int[n3];
        int sum = 0;

        for (int i = 0; i < n3; i++)
        {
            arr3[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr3[i];
        }
        Console.WriteLine("Sum of elements: " + sum + "\n");

        //  4. Copy Array 
        Console.Write("Enter number of elements: ");
        int n4 = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n4];
        int[] b = new int[n4];

        for (int i = 0; i < n4; i++)
            a[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n4; i++)
            b[i] = a[i];

        Console.Write("First array: ");
        for (int i = 0; i < n4; i++)
            Console.Write(a[i] + " ");

        Console.Write("\nCopied array: ");
        for (int i = 0; i < n4; i++)
            Console.Write(b[i] + " ");
        Console.WriteLine("\n");

        //  5. Count Duplicate Elements 
        Console.Write("Enter number of elements: ");
        int n5 = Convert.ToInt32(Console.ReadLine());
        int[] arr5 = new int[n5];
        int dupCount = 0;

        for (int i = 0; i < n5; i++)
            arr5[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n5; i++)
        {
            for (int j = i + 1; j < n5; j++)
            {
                if (arr5[i] == arr5[j])
                {
                    dupCount++;
                    break;
                }
            }
        }
        Console.WriteLine("Total duplicates: " + dupCount + "\n");

        //  6. Unique Elements 
        Console.Write("Unique elements: ");
        for (int i = 0; i < n5; i++)
        {
            bool unique = true;
            for (int j = 0; j < n5; j++)
            {
                if (i != j && arr5[i] == arr5[j])
                {
                    unique = false;
                    break;
                }
            }
            if (unique)
                Console.Write(arr5[i] + " ");
        }
        Console.WriteLine("\n");

        //  7. Merge Two Sorted Arrays 
        int[] m1 = { 1, 2, 3 };
        int[] m2 = { 1, 2, 3 };
        int[] merged = new int[m1.Length + m2.Length];

        int i1 = 0, i2 = 0, k = 0;
        while (i1 < m1.Length && i2 < m2.Length)
        {
            if (m1[i1] <= m2[i2])
                merged[k++] = m1[i1++];
            else
                merged[k++] = m2[i2++];
        }
        while (i1 < m1.Length)
            merged[k++] = m1[i1++];
        while (i2 < m2.Length)
            merged[k++] = m2[i2++];

        Console.Write("Merged array: ");
        for (int i = 0; i < merged.Length; i++)
            Console.Write(merged[i] + " ");
        Console.WriteLine("\n");

        //  8. Frequency Count 
        Console.Write("Frequency:\n");
        bool[] visited = new bool[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            if (visited[i]) continue;
            int count = 1;
            for (int j = i + 1; j < arr1.Length; j++)
            {
                if (arr1[i] == arr1[j])
                {
                    count++;
                    visited[j] = true;
                }
            }
            Console.WriteLine(arr1[i] + " occurs " + count + " times");
        }
        Console.WriteLine();

        //  9. Max & Min 
        int max = arr1[0], min = arr1[0];
        for (int i = 1; i < arr1.Length; i++)
        {
            if (arr1[i] > max) max = arr1[i];
            if (arr1[i] < min) min = arr1[i];
        }
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min + "\n");

        //  10. Even & Odd 
        Console.Write("Even: ");
        for (int i = 0; i < arr1.Length; i++)
            if (arr1[i] % 2 == 0)
                Console.Write(arr1[i] + " ");

        Console.Write("\nOdd: ");
        for (int i = 0; i < arr1.Length; i++)
            if (arr1[i] % 2 != 0)
                Console.Write(arr1[i] + " ");
        Console.WriteLine("\n");

        //  11. Sort Ascending 
        Array.Sort(arr1);
        Console.Write("Ascending: ");
        foreach (int x in arr1)
            Console.Write(x + " ");
        Console.WriteLine("\n");

        //  12. Sort Descending 
        Array.Reverse(arr1);
        Console.Write("Descending: ");
        foreach (int x in arr1)
            Console.Write(x + " ");
        Console.WriteLine("\n");

        //  13. Insert into Sorted Array 
        int[] sorted = { 5, 7, 9 };
        int insert = 8;
        int[] newArr = new int[sorted.Length + 1];
        int pos = 0;

        while (pos < sorted.Length && sorted[pos] < insert)
        {
            newArr[pos] = sorted[pos];
            pos++;
        }
        newArr[pos] = insert;
        for (int i = pos; i < sorted.Length; i++)
            newArr[i + 1] = sorted[i];

        Console.Write("After insert(sorted): ");
        foreach (int x in newArr)
            Console.Write(x + " ");
        Console.WriteLine("\n");

        //  14. Insert into Unsorted Array 
        int[] unsorted = { 1, 8, 7, 10 };
        int value = 5;
        int position = 1;
        int[] unsNew = new int[unsorted.Length + 1];

        for (int i = 0; i < position; i++)
            unsNew[i] = unsorted[i];

        unsNew[position] = value;

        for (int i = position; i < unsorted.Length; i++)
            unsNew[i + 1] = unsorted[i];

        Console.Write("After insert(unsorted): ");
        foreach (int x in unsNew)
            Console.Write(x + " ");
        Console.WriteLine("\n");

        //  15. Delete Element 
        int[] delArr = { 1, 2, 3, 4, 5 };
        int delPos = 2;
        for (int i = delPos; i < delArr.Length - 1; i++)
            delArr[i] = delArr[i + 1];

        Console.Write("After delete: ");
        for (int i = 0; i < delArr.Length - 1; i++)
            Console.Write(delArr[i] + " ");
        Console.WriteLine("\n");

        //  16. Count Distinct Duplicate Values 
        int[] arr16 = { 5, 1, 1, 2, 2, 1, 3, 3 };
        int dupTypes = 0;

        for (int i = 0; i < arr16.Length; i++)
        {
            bool counted = false;
            for (int j = 0; j < i; j++)
                if (arr16[i] == arr16[j])
                    counted = true;

            if (!counted)
            {
                int count = 0;
                for (int j = 0; j < arr16.Length; j++)
                    if (arr16[i] == arr16[j])
                        count++;

                if (count > 1)
                    dupTypes++;
            }
        }
        Console.WriteLine("Total duplicate element types: " + dupTypes);
    }
}
