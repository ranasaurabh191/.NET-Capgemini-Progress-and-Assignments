class Intern : Employee 
{
    public Intern(double hourRate, double hours) : base(hourRate, hours) { }

    public override double CalculateSalary()
    {
        return hourRate * 0.6 * hours;
    }
}