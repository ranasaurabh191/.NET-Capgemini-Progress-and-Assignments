// class FileInfoDemo
// {
//     static void Main()
//     {
//         // string path = @"MyTextFile.txt";
//         // FileInfo f1 = new FileInfo(path);
//         // File.Create(path);
//         // {
//         //     Console.WriteLine("File created.");
//         // }

//         // FileInfo f1 = new FileInfo(@"Myt.txt");
//         // StreamWriter str = f1.CreateText();
//         // str.WriteLine("hello");
//         // Console.WriteLine("File has been created with text");
//         // str.Close();

//         // method to delete
//         // FileInfo f1 = new FileInfo(@"MyTextFile.txt");
//         // f1.Delete();
//         // Console.WriteLine("File has been deleted");

//         // //method to copy
//         // string path1 = @"Myt.txt";
//         // string path2 = @"Myt1.txt";
//         // FileInfo fi1 = new FileInfo(path1);
//         // FileInfo fi2 = new FileInfo(path2);
//         // fi1.CopyTo(path2);
//         // Console.WriteLine("{0} copied to {1}",path1,path2);

//         // //method to move
//         // string path3 = @"Myt.txt";
//         // string path4 = @"Myt2.txt";
//         // FileInfo fi3 = new FileInfo(path3);
//         // FileInfo fi4 = new FileInfo(path4);
//         // fi3.MoveTo(path4);
//         // Console.WriteLine("{0} moved to {1}",path3,path4);

//         // to append
//         // FileInfo f1 = new FileInfo(@"NewFile.txt");
//         // StreamWriter sw = f1.AppendText();
//         // sw.WriteLine("Hello");
//         // sw.WriteLine("World");
//         // sw.WriteLine("How");
//         // Console.WriteLine("File has been appended.");
//         // sw.Close();


//         // Opentext Method  
//         // FileInfo fi = new FileInfo(@"NewFile.txt");  
//         // StreamReader sr = fi.OpenText();  
//         // string s = "";
//         // while ((s = sr.ReadLine()) != null) {  
//         //     Console.WriteLine(s);  
//         // }  

//         FileInfo fi = new FileInfo(@"NewFile.txt");  
//         Console.WriteLine("File name is {0} ", fi.Name);  
//         Console.WriteLine("File creation time is {0} ", fi.CreationTime.ToLongTimeString());  
//         Console.WriteLine("File Lastaccesstime is {0} ", fi.LastAccessTime.ToLongDateString());  
//         Console.WriteLine("File length is {0} ", fi.Length.ToString() + " Bytes");  
//         Console.WriteLine("File extension is {0} ", fi.Extension);  
//         Console.WriteLine("File exist is: {0}", fi.Exists);  


//     }
// }