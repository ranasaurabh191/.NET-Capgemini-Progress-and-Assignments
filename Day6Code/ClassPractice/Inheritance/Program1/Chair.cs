class Chair : Furniture
{
    public override void Accept()
    {
        Console.Write("Enter the no of chair: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the color: ");
        color = Console.ReadLine() ?? "";
        Console.Write("Enter the width: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height: ");
        height = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        Console.WriteLine("\nDetails are : ");
        Console.WriteLine("No of chairs are: "+num);
        Console.WriteLine("Color is: "+color);
        Console.WriteLine("Width is: "+width);
        Console.WriteLine("Height is: "+height);

    }
}