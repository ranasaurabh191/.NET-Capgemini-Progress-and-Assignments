namespace PartialDemo
{
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine("Full name is "+_firstName+_lastName);
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine("Firstname is : "+_firstName);
            Console.WriteLine("Lastname is : "+_lastName);
            Console.WriteLine("Gender is : "+_gender);
            Console.WriteLine("Salary is : "+_salary);
        }
        partial void PartialMethod()
        {
            Console.WriteLine("Partial method invoked");
        }
    }
}