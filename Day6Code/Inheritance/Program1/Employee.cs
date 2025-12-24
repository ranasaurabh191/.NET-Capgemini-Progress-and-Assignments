class Employee
{
    public int EmployeeId {get;set;}
    public string Name{get;set;}
    public float Salary{get;set;}

    public Employee(){
        EmployeeId=0;
        Name="";
        Salary = 0.0f;
    }
    public Employee(int empid,string name,float salary){
        EmployeeId=empid;
        Name=name;
        Salary = salary;
    }
    //overriding tostring
    public override string ToString()
    {
        return "Employee Details are: \nEmployee id is: "+EmployeeId
        +" \nEmployee name is: "+Name
        +"\nEmployee salary is: "+Salary;
    }
    //param
    public void Add(params int[] arr)
    {
        int sum=0;
        foreach(int n in arr)
        {
            sum+=n;
        }
        Console.WriteLine("Sum is : "+sum);
    }
}