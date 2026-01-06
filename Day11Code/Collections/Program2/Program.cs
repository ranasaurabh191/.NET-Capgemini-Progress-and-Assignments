using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        // object o;
        // int i = 10;
        // o = i; // Boxing

        // string str;

        // int j = (int)o; // Unboxing

        // ArrayList arrayList = new ArrayList();
        // arrayList.Add(1); // Boxing
        // arrayList.Add(false); // Boxing
        // arrayList.Add(3.14f); // Boxing

        // int k = (int)arrayList[0]; // Unboxing

        // var v = arrayList[1]; // No unboxing here, v is of type object
        // bool t = (bool)v; // Unboxing

        // // var x = 0;
        // // x= "hello"; //showing error;

        // dynamic d = 10;
        // d = "hello"; //no error



        // AddClass addClass = new AddClass();
        // int sumInt = addClass.AddInt(10, 20);

        // Console.WriteLine("Sum of Integers: " + sumInt);

        // float sumFloat = addClass.AddFloat(10.5f, 20.3f);
        // Console.WriteLine("Sum of Floats: " + sumFloat);

        // string sumString = addClass.AddString("Hello, ", "World!");
        // Console.WriteLine("Concatenated String: " + sumString);

        // AddGenericClass<int> addInteger = new AddGenericClass<int>(10, 20);
        // int genericSumInt = addInteger.AddAllType(10, 20);
        // Console.WriteLine("Generic Sum of Integers: " + genericSumInt);

        // AddGenericClass<float> addFloat = new AddGenericClass<float>(10.5f, 20.3f);
        // float genericSumFloat = addFloat.AddAllType(10.5f, 20.3f);
        // Console.WriteLine("Generic Sum of Floats: " + genericSumFloat);

        // AddGenericClass<string> addString = new AddGenericClass<string>("Hello, ", "World!");
        // string genericSumString = addString.AddAllType("Hello, ", "World!");
        // Console.WriteLine("Generic Concatenated String: " + genericSumString);


        // List<Employee> employees = new List<Employee>();
        // employees.Add(new Employee { Id = 1, Name = "Gaurav" });
        // employees.Add(new Employee { Id = 2, Name = "Kundan" });
        // employees.Add(new Employee { Id = 3, Name = "Krishna" });
        // foreach (Employee emp in employees)
        // {
        //     Console.WriteLine(emp);
        // }


        // Dictionary<int, string> dict = new Dictionary<int, string>();
        // dict.Add(101, "Gaurav");
        // dict.Add(102, "Kundan");
        // dict.Add(103, "Krishna");
        // foreach(var kvp in dict)
        // {
        //     Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        // }


        SortedList<string, string> sortedList = new SortedList<string, string>();
        sortedList.Add("101", "Gaurav");
        sortedList.Add("102", "Kundan");
        sortedList.Add("103", "Krishna");
        foreach(var kvp in sortedList)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }

        Stack<char> stack = new Stack<char>();
        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        foreach(var item in stack)
        {
            Console.WriteLine("Stack item: " + item);
        }
        stack.Pop();
        Console.WriteLine("After Pop:");
        foreach(var item in stack)
        {
            Console.WriteLine("Stack item: " + item);
        }

        Queue<char> queue = new Queue<char>();
        queue.Enqueue('X');
        queue.Enqueue('Y');
        queue.Enqueue('Z');
        foreach(var item in queue)
        {
            Console.WriteLine("Queue item: " + item);
        }
        queue.Dequeue();
        Console.WriteLine("After Dequeue:");
        foreach(var item in queue)
        {
            Console.WriteLine("Queue item: " + item);
        }
    }
}