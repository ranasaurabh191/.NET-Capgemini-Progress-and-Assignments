using System.Transactions;

class ExpenseTransaction : Transaction
{
    public string Category{get;set;}
    public ExpenseTransaction(int id, DateTime date, decimal amount, string description, string category): base(id, date, amount, description)
    {
        Category = category;
    }
    public override string GetSummary()
    {
        return $"[EXPENSE] ₹{Amount} for {Category} on {Date.ToShortDateString()} - {Description}";
    }

}