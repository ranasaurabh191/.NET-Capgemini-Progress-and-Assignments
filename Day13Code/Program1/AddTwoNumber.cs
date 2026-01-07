class AddTwoNumbers
{
    public delegate void dgOddNumber(); //declared delegate

    public event dgOddNumber evOddNumber; //declared event

    public void Add()
    {
        int result;
        result = 5+4;
        Console.WriteLine(result.ToString());
        if((result%2!=0) && (evOddNumber != null))
        {
            evOddNumber(); // calling event
        }
    }
}