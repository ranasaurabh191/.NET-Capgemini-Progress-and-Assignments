class Program
{
    public static void Main()
    {
        Student student1 = new Student();
        Console.WriteLine("Student 1:");
        Console.WriteLine("Name: " + student1.Name);
        Console.WriteLine("Age: " + student1.Age);
        Console.WriteLine("Grade: " + student1.Grade);

        Console.WriteLine("\nEnter details for Student 2:");
        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Grade: ");
        string grade = Console.ReadLine() ?? "";

        Student student2 = new Student(name, age, grade);
        Console.WriteLine("\nStudent 2:");
        Console.WriteLine("Name: " + student2.Name);
        Console.WriteLine("Age: " + student2.Age);
        Console.WriteLine("Grade: " + student2.Grade);

    }
}