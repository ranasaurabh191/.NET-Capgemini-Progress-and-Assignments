class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp[0]="Saurabh";
        emp[1]="Sting1";
        emp[2]="Sting2";
        // emp[3]="Sting3";
        // emp[4]="Sting4";

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(emp[i]);
        }
        Console.WriteLine(emp["Saurabh"]);
        Console.WriteLine(emp[0]);

    }
}