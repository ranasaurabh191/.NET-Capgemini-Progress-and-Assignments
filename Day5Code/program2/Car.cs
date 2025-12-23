class Car
{
    public string Make{get;set;}
    public string Model{get;set;}
    public int Year{get;set;}

    public Car(string make,string model,int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Make: "+Make);
        Console.WriteLine("Model: "+Model);
        Console.WriteLine("Year :"+Year);
    }
    public void DisplayAge()
    {
        Console.WriteLine("Car Age :"+(2025-Year)+" years");
    }
}