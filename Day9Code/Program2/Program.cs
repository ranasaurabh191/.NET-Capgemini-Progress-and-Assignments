
public class Program
{
    public static void Main()
    {
        // int[] arr = { 10, 60, 30, 40, 50 };

        // Console.WriteLine($"Array index of value 30: {Array.IndexOf(arr, 30)}");
        // Console.WriteLine($"Array value at index 2: {arr.GetValue(2)}");
        // Console.WriteLine($"Array is fixed size: {arr.IsFixedSize}");
        // Console.WriteLine($"Array is ReadOnly: {arr.IsReadOnly}");
        // Console.WriteLine($"Array's Rank: {arr.Rank}");
        // Console.WriteLine("Array before sorting:");
        // foreach (int num in arr)
        // {
        //     Console.Write(num + " ");
        // }
        // Console.WriteLine();
        // Console.WriteLine("Sorting array...");
        // Array.Sort(arr);
        // foreach (int num in arr)
        // {
        //     Console.Write(num + " ");
        // }
        // Console.WriteLine();
        // Array.Reverse(arr);
        // Console.WriteLine("Reversed array:");
        // foreach (int num in arr)
        // {
        //     Console.Write(num + " ");
        // }
        // Console.WriteLine();


        Employee employee1 = new Employee(){ Id = 101, Name = "Gaurav"};
        Employee employee2 = new Employee(){ Id = 102, Name = "Krishna"};
        Employee employee3 = new Employee(){ Id = 103, Name = "Kundan"};
        Employee employee4 = new Employee(){ Id = 104, Name = "Shubham"};
        Employee[] employeeList = new Employee[4];
        employeeList[0] = employee1;
        employeeList[1] = employee2;
        employeeList[2] = employee3;
        employeeList[3] = employee4;
        Console.WriteLine("Before Sorting:");
        foreach(Employee emp in employeeList)
        {
            Console.WriteLine(emp);
        }
        Array.Sort(employeeList);
        Console.WriteLine("After Sorting:");
        foreach(Employee emp in employeeList)
        {
            Console.WriteLine(emp);
        }
        Program program = new Program();
        program.PassObject(employeeList[2]);
        program.PassArrayObject(employeeList);
        Employee returnedEmp = program.ReturnObject();
        Console.WriteLine("Returned Employee:");
        Console.WriteLine(returnedEmp);
    }
    public void PassObject(Employee employee)
    {
        Console.WriteLine(employee);
    }
    public void PassArrayObject(Employee[] employees)
    {
        foreach(Employee emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
    public Employee ReturnObject()
    {
        Employee emp = new Employee { Id = 105, Name = "Gaurav Jha" };
        return emp;
    }
}