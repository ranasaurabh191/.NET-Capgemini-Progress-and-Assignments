class Calculator
{
    //method overloading
    public int Add()
    {
        int num1=10;
        int num2 = 32;
        return num1+num2;
    }
    public void Add(int n1,int n2)
    {
        Console.WriteLine(n1+n2);
    }
    public void Add(double n)
    {
        Console.WriteLine(n+2322.4);
    }
    public void Add(float n,float m)
    {
        Console.WriteLine(n+m);
    }
    public void Add(string s1,string s2)
    {
        Console.WriteLine(s1+s2);
    }
}