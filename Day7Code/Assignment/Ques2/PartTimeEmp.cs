class PartTimeEmp : Employee 
{
    public PartTimeEmp(double hourRate, double hours) : base(hourRate, hours) { }

    public override double CalculateSalary()
    {
        return hourRate * 0.8 * hours;
    }
}