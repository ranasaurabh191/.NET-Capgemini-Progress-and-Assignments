using System.Collections;

class InvalidLength: Exception
{
    public InvalidLength(string Message) : base(Message) { }
}
class Program
{
    static void Main()
    {
        try{
            ArrayList arr1 = new ArrayList();
            string input1 = Console.ReadLine()??"";
            string[] values1 = input1.Split(' ');
            for(int i = 0; i < values1.Length; i++)
            {
                arr1.Add(Convert.ToInt32(values1[i]));
            }

            ArrayList arr2 = new ArrayList();
            string input2 = Console.ReadLine()??"";
            string[] values2 = input2.Split(' ');
            for(int i = 0; i < values2.Length; i++)
            {
                arr2.Add(Convert.ToInt32(values2[i]));
            }
            if (arr1.Count != arr2.Count)
            {
                throw new InvalidLength("Error: Arrays must have the same length for addition.");
            }

            ArrayList sumArray = new ArrayList();
            for (int i = 0; i < arr1.Count; i++)
            {
                sumArray.Add((int)arr1[i] + (int)arr2[i]);
            }

            int index = Convert.ToInt32(Console.ReadLine());

            // Output
            Console.WriteLine($"Element at index {index} in the sum array: {sumArray[index]}");


        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format. Please enter integers only.");
            Console.WriteLine("Exception Message: " + ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Index out of range for the sum array.");
            Console.WriteLine("Exception Message: " + ex.Message);
        }
        catch (InvalidLength ex)
        {
            Console.WriteLine(ex.Message);
        }

        
    


    }
}