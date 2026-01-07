
abstract class Transaction : IReportable
{
    public int Id{get;set;}
    public DateTime Date{get;set;}
    public decimal Amount{get;set;}
    public string Description{get;set;}
    protected Transaction(int id,DateTime date, decimal amount,string description) 
    // protected => Only derived classes can create transactions.Prevents misuse from outside.
    {
        Id = id;
        Date = date;
        Amount = amount;
        Description = description;
    }
    public abstract string GetSummary(); 
    //abstract => Each transaction type must describe itself differently.Forces derived classes to implement their own logic.

}