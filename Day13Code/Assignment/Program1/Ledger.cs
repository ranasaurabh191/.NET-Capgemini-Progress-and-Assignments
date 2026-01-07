using System.Transactions;

class Ledger<T> where T : Transaction
{
    private List<T> enteries = new List<T>();
    public void AddEntry(T entry)
    {
        enteries.Add(entry);
    }

    public List<T> GetTransactionsByDate(DateTime date)
    {
        return enteries.Where(e => e.Date.Date == date.Date).ToList();
    }
    public decimal CalculateTotal()
    {
        return enteries.Sum(e => e.Amount);
    }
    public List<T> GetAll()
    {
        return enteries;
    }
}