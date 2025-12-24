class Student
{
   
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }  
    //reate a default constructor that initializes the Name, Age, and Grade properties
    public Student()
    {
        Name = "Hellen Doe";
        Age = 21;
        Grade = "A";
    }
    //	Create a parameterized constructor that allows initialization of the Name, Age, and Grade properties using values provided as arguments.
    
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}