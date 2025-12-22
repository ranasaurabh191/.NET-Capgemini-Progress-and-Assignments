class PayRoll
{

    public void Swap(int sal1, int sal2)
    {
        int temp = sal1;
        sal1 = sal2;
        sal2 = temp;

        Console.WriteLine("\nInside Swap Method:");
        Console.WriteLine("Salary Component 1: " + sal1);
        Console.WriteLine("Salary Component 2: " + sal2);
    }
}