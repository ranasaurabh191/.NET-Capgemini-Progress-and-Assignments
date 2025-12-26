class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.GetEmployeeData();
        emp.DisplayEmployeeData();
        emp.CalculateSalary();

        Manager man = new Manager();
        man.GetEmployeeData();
        man.DisplayEmployeeData();
        man.CalculateSalary();

    }
}