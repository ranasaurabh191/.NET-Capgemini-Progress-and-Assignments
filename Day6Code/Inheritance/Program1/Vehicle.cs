class Vehicle
{
    protected double distance = 0.0;
    protected double hour = 0.0;
    protected double fuel = 0.0;
    public Vehicle(double distance,double hour,double fuel)
    {
        this.distance=distance;
        this.hour=hour;
        this.fuel=fuel;

    }
    public void Average()
    {
        double avg=distance/fuel;
        Console.WriteLine("Avg Base : "+avg);
    }
    public virtual void Speed()
    {
        double speed = distance/hour;
        Console.WriteLine("Speed Base: "+speed);
    }
}