class Men:Cloth
{
    int size;

    string returnCloth="YES";
    public Men(int id,int size):base(id)
    {
        this.size = size;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("\nMen Cloth Details: ");
        Console.WriteLine("Cloth ID: "+id);
        Console.WriteLine("Cloth size: "+size);
        Console.WriteLine("ReturnCloth: "+returnCloth);
    }
}