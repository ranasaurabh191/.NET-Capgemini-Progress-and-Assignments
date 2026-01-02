namespace ArrayDemoApp;
class Program
{
    static void Main()
    {
        int[] arr;//declaration
        Console.Write("Enter length: ");
        int length = Convert.ToInt32(Console.ReadLine());
        arr = new int[length];//array initialisation
        arr[0]=10;
        arr[1]=23;
        arr[2]=41;
        arr[3]=42;
        arr[4]=44;
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Element for {i} index: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int len = arr.GetLength(0);
        
        Console.WriteLine("length1: "+len);
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Element at {i} index is {arr[i]}");
        }

        char[] ch = new char[4]{'a','b','c','d'};
        foreach(char i in ch)
        {
            Console.WriteLine($"Char element is {i}");
        }

        string[] str = new string[4]{"dfsdf","sdfsd","sdewt","fs"};
        foreach(string i in str)
        {
            Console.WriteLine($"Char element is {i}");
        }
        
    }
}