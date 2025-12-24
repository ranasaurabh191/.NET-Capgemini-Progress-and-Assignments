class Kids : Cloth
{
    int size;
    string returnCloth="NO";
    public Kids(int id,int size):base(id)
    {
        this.size=size;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("\nKids Cloth Details: ");
        Console.WriteLine("Cloth ID: "+id);
        Console.WriteLine("Cloth size: "+size);
        Console.WriteLine("ReturnCloth: "+returnCloth);
    }
}