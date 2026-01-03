using System.Collections;

internal class Program
{
    static void Main()
    {
        // Hashtable hashtable = new Hashtable();
        // hashtable.Add(100,"Rajesh");
        // hashtable.Add(200,"Suresh");
        // hashtable.Add(300,"Rahul");
        // hashtable.Add(400,"Ram");
        // Console.WriteLine("Keys are: ");
        // ICollection key = hashtable.Keys;
        // foreach(var k in key) //CLR simply walks through internal buckets
        // {
        //     Console.WriteLine(k);
        // }
        // Console.WriteLine("\nValues are: "); //Keys and Values are aligned by same internal index
        // ICollection values = hashtable.Values;
        // foreach(var k in values)
        // {
        //     Console.WriteLine(k);
        // }

        // foreach(var k in key)
        // {
        //     Console.WriteLine($"Key: {k} value: {hashtable[k]}");
        // }


        // Console.WriteLine("Search key  and value: ");
        // int key2 = Convert.ToInt32(Console.ReadLine());
        // if (hashtable.ContainsKey(key2))
        // {
        //     Console.WriteLine("Found key: "+key2);

        // }
        // else
        // {
        //     Console.WriteLine("Not found");
        // }

        // SortedList list = new SortedList();
        // list.Add(500,"Rajesh");
        // list.Add(200,"Suresh");
        // list.Add(300,"Mira");
        // list.Add(400,"Suresh");
        // ICollection key = list.Keys;
        // Console.WriteLine("All keys are: ");
        // foreach(var k in key)
        // {
        //     Console.WriteLine(k);
        // }
        // ICollection values = list.Values;
        // Console.WriteLine("All values are: ");
        // foreach(var v in values)
        // {
        //     Console.WriteLine(v);
        // }

        // Console.WriteLine("All keys and values are: ");
        // foreach(var k in key)
        // {
        //     Console.WriteLine($"Key: {k} value: {list[k]}");
        // }

        // Console.WriteLine($"Index of key:  {list.IndexOfKey(500)} having indexof value: {list.IndexOfValue("Rajesh")}");
        // int count = list.Count;
        // Console.WriteLine($"Count before:  {count}");
        // list.Clear();
        // Console.WriteLine("After clearing: ");
        // Console.WriteLine("All keys and values are: ");
        // foreach(var k in key)
        // {
        //     Console.WriteLine($"Key: {k} value: {list[k]}");
        // }

        // count = list.Count;
        // Console.WriteLine($"Count after:  {count}");

        Stack stack = new Stack();
        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        stack.Push('D');
        stack.Push('E');

        foreach(var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Element at top : "+stack.Peek());
        
    }
}