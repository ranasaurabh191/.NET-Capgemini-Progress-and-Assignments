namespace PartialDemo;
class Program
{
    static void Main()
    {
        PartialEmployee part= new PartialEmployee();
        part.FirstName = "Rahul";
        part.LastName = "Kumar";
        part.Gender = "male";
        part.Salary=323.32;
        part.DisplayEmployeeDetails();
        part.DisplayFullName();
        
    }
}