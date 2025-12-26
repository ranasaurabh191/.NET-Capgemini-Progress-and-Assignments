//Interface



class Program
{
    static void Main()
    {
        IPayment payment = new CreditCardPayment();
        payment.Refund(1000.0);
        payment.Pay(100.0);

        IPayment payment2 = new UpiPayment();
        payment2.Refund(300.0);
        payment2.Pay(3023.0);
    }
}