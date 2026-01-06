// using System.Collections;
// class MyCollection : IEnumerable
// {
//     int[] data = {1,2,3};
//     public IEnummerator GetEnummerator()
//     {
//         return data.GetEnumerator();
//     }
    
// }
// class Program{
    
//     static void Main()
//     {
//         MyCollection obj = new MyCollection();
//         foreach(int i in obj)
//         {
//             Console.WriteLine(i);
//         }
//     } 
// }

var name = "Alice";

var greeting = String.Format("Hello {0}, {1}!", name, "good morning");

Console.WriteLine(greeting);
