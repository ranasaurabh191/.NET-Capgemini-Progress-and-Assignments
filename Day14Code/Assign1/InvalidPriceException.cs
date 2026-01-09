class InvalidPriceException : SystemException
{
    // Default constructor
    public InvalidPriceException()
        : base("Error: Price must be greater than zero.")
    {
    }

    // Constructor with custom message
    public InvalidPriceException(string message)
        : base(message)
    {
    }
}