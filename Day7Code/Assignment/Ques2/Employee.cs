class Employee
{

    protected double hourRate,hours;
    public Employee(double hourRate,double hours)
    {
        this.hourRate=hourRate;
        this.hours=hours;
    }
    public virtual double CalculateSalary()
    {
        return hourRate * hours;
    }
}