public class Program
{
    static void Main()
    {
        StudentManager manager = new StudentManager();

        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string grade = Console.ReadLine();

            Student student = new Student
            {
                Id = id,
                Name = name,
                Grade = grade
            };

            manager.AddStudent(student);
        }

        manager.DisplayStudents();
    }
}