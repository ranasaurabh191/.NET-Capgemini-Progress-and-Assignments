// class BinaryRead
// {
//     static void Main()
//     {
//         string filePath = "employee.dat";
//         using (FileStream fs = new FileStream(filePath,FileMode.Open)) // instance 
//         using (BinaryReader reader = new BinaryReader(fs))
//         {
//             int id = reader.ReadInt32();
//             string name = reader.ReadString();
//             double salary = reader.ReadDouble();
//             bool isActive = reader.ReadBoolean();

//             Console.WriteLine("Id is: "+id);
//             Console.WriteLine("Name is: "+name);
//             Console.WriteLine("Salary is: "+salary);
//             Console.WriteLine("IsActive is: "+isActive);

//         }
//     }
// }