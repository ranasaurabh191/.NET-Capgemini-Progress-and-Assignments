// using System.Text;

// StringBuilder sb = new StringBuilder();

// sb = new StringBuilder("hello world");

// for(int i = 0; i < sb.Length; i++)
//     Console.Write(sb[i]); 

using System;

public interface IDisplayable
{
    void Display();
}

public class MyClass<T> where T : class, IDisplayable, new()
{
    public void Show()
    {
        T obj = new T();
        obj.Display();
    }
}

public class DisplayItem : IDisplayable
{
    public void Display()
    {
        Console.WriteLine("Displaying item...");
    }
}

public class Program
{
    public static void Main()
    {
        MyClass<DisplayItem> myClass = new MyClass<DisplayItem>();
        myClass.Show(); // Output: Displaying item...
    }
}
