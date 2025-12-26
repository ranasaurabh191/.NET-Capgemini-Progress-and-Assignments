
class CreditCardPayment: IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
    public void Refund(double amount)
    {
        Console.WriteLine($"Refunded {amount} to credit card.");
    }
}


