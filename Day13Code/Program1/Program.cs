// using System;

// delegate void Message();

// class Program
// {
//     static void Hello()
//     {
//         Console.WriteLine("Hello World");
//     }
//     static void World()
//     {
//         Console.WriteLine("World");
//     }
//     static void World2()
//     {
//         Console.WriteLine("World2");
//     }

//     static void Main()
//     {
//         Message msg = Hello; 
//         msg+=World;
//         // msg1(); 
//         msg+=World2;                           // method stored
//         msg();                 // method invoked
//     }
// }

class Program
{
    public static void EventMessage()
    {
        Console.WriteLine("Hello this is  an event odd number");
    }
    static void Main()
    {
        AddTwoNumbers a = new AddTwoNumbers();// class
        a.evOddNumber += new AddTwoNumbers.dgOddNumber(EventMessage);
        a.Add();
    }
    
}


