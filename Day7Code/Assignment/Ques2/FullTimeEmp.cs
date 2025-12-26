class FullTimeEmp : Employee 
{
    public FullTimeEmp(double hourRate, double hours) : base(hourRate, hours) { }

    public override double CalculateSalary()
    {
        return hourRate * hours;
    }
}