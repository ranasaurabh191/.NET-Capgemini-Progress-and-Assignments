class Program
{
    static void Main()
    {
        Console.Write("Enter the number of Employees: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Please enter a valid integer :");
        }

        Employee[] emp = new Employee[number];
        string[] empTypes = new string[number];
        for (int i = 0; i < number; i++)
        {
            while (true)
            {
                double hourRate,hours;
                Console.Write("Enter employee type: ");
                string empType = (Console.ReadLine() ?? "").ToLower();
                if (empType == "fulltimeemployee")
                {
                    Console.Write("Enter hour rate: ");
                    hourRate = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter hours: ");
                    hours = Convert.ToDouble(Console.ReadLine());
                    emp[i] = new FullTimeEmp(hourRate,hours);
                    empTypes[i] = "FullTimeEmployee";
                    break;
                    
                }
                else if (empType == "parttimeemployee")
                {
                    Console.Write("Enter hour rate: ");
                    hourRate = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter hours: ");
                    hours = Convert.ToDouble(Console.ReadLine());
                    emp[i] = new PartTimeEmp(hourRate, hours);
                    empTypes[i] = "PartTimeEmployee";
                    break;
                }
                else if (empType == "intern")
                {
                    Console.Write("Enter hour rate: ");
                    hourRate = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter hours: ");
                    hours = Convert.ToDouble(Console.ReadLine());
                    emp[i] = new Intern(hourRate, hours);
                    empTypes[i] = "Intern";
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown employee type. Please enter FullTimeEmployee, PartTimeEmployee, or Intern.");
                }
            }
        }
        Console.WriteLine("Salaries of the employees:");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Salary of Employee {i + 1} ({empTypes[i]}): {emp[i].CalculateSalary()}");
        }
    }
}