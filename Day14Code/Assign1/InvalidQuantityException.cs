class InvalidQuantityException : SystemException
{
    // Default constructor
    public InvalidQuantityException()
        : base("Error: Quantity must be greater than zero.")
    {
    }

    // Constructor with custom message
    public InvalidQuantityException(string message)
        : base(message)
    {
    }
}