public class StudentManager
{
    public Dictionary<int, Student> Students { get; set; }

    public StudentManager()
    {
        Students = new Dictionary<int, Student>();
    }

    public void AddStudent(Student student)
    {
        Students[student.Id] = student;
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Student Information:");
        foreach (KeyValuePair<int, Student> entry in Students)
        {
            Student s = entry.Value;
            Console.WriteLine("ID: {0}, Name: {1}, Grade: {2}",s.Id, s.Name, s.Grade);
        }
    }
}