

// class BinaryWrite
// {
//     static void Main()
//     {
//         string filePath = "employee.dat";
//         using (FileStream fs = new FileStream(filePath,FileMode.Create)) // instance 
//         using (BinaryWriter writer = new BinaryWriter(fs))
//         {
//             writer.Write(101);
//             writer.Write("Ravi");
//             writer.Write(34.234);
//             writer.Write(true);
//         }
//         Console.WriteLine("Binary file written successfully");
//     }
// }