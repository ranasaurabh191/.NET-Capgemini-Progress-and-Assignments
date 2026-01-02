class Program
{
    static void Main()
    {
        string fname,lname;
        fname = "Ram";
        lname = "Kumar";
        char[] letters = {'H','E','L','L','O'};
        string[] sarray = {"Hello","From","Tutorial","Point"};
        
        string fullName = fname+lname;
        Console.WriteLine("Full Name: {0}",fullName);
        //using string constructor
        string greetings = new string(letters);
        Console.WriteLine("Full Name: {0}",greetings);
        //method returning string
        string message = String.Join(" ",sarray);
        Console.WriteLine("Full Name: {0}",message);

        //formatting
        DateTime waiting = new DateTime(2012,10,10,17,58,32);
        string chat = String.Format("Message sent at {0:t} on {0:D}",waiting);
        Console.WriteLine("Message: {0}",chat);

        string str1 = "This is next";
        string str2 = "This is next";
        Console.WriteLine(String.Compare(str1,str2)==0 ? "str1 and str2 are Equal" : "str1 and str2 are not Equal");

        Console.WriteLine(str1.Contains("is  ") ? "Sequence found" : "Sequence not found");

        string str3 = "Last night I dreamed of my future wife";
        string substring = str3.Substring(2,5);//start , length upto 
        Console.WriteLine(substring);

        Console.WriteLine("\"Hllloo\"");
        Console.WriteLine(@"C:\Packages\B9ECED6F.ArmouryCrate_qmbB9ECED6F.ArLocryCrate\GPUPowerSavingLocalState");
        Console.WriteLine("C:\\Packages\\B9ECED6F.ArmouryCrate_qmbB9ECED6F.ArLocryCrate\\GPUPowerSavingLocalState");

        var msg = @"hello,
                sdlkfjsdkf,
                fdsddgd";
        Console.WriteLine(msg);

        

    }

}