class Car : Vehicle
{
    public Car(double distance,double hour, double fuel):base(distance,hour,fuel)//calling base cls construtor
    {
        
    }
    public new void Average()
    {
        double avg=distance/fuel;
        Console.WriteLine("Avg Child: "+avg);
    }
    public override void Speed()
    {
        double speed = distance/hour;
        Console.WriteLine("Speed Child: "+speed);
    }
}