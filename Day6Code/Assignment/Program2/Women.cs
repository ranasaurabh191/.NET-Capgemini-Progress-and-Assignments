class Women:Cloth
{
    int size;
    string materialType = "";
    string returnCloth= "YES";

    public Women(int id,int size,string materialType):base(id) 
    {
        this.size=size;
        this.materialType=materialType;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("\nWomen Cloth Details: ");
        Console.WriteLine("Cloth ID: "+id);
        Console.WriteLine("Cloth size: "+size);
        Console.WriteLine("Material Type: "+materialType);
        Console.WriteLine("ReturnCloth: "+returnCloth);
    }
}