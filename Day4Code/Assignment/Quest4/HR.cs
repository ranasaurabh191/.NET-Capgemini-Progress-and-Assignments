class HR
{
    public void Swap1(ref int num3, ref int num4)
    {
        int temp = num3;
        num3 = num4;
        num4 = temp;

        Console.WriteLine("\nAfter Swap (Inside Method):");
        Console.WriteLine("Employee ID 1: " + num3);
        Console.WriteLine("Employee ID 2: " + num4);
    }
}