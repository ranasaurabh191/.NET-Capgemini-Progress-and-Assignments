using System.Transactions;

class Program
{
    static void Main()
    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        incomeLedger.AddEntry(new IncomeTransaction(1,DateTime.Today,500,"Petty Cash","Main Cash"));

        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();
        expenseLedger.AddEntry(new ExpenseTransaction(2,DateTime.Today,100,"Pens and Papers","Stationary"));

        decimal totalIncome=incomeLedger.CalculateTotal();
        decimal totalExpense=expenseLedger.CalculateTotal();

        decimal balance = totalIncome-totalExpense;

        Console.WriteLine("----- PETTY CASH SUMMARY -----");
        Console.WriteLine($"Total Income  : ${totalIncome}");
        Console.WriteLine($"Total Expense : ${totalExpense}");
        Console.WriteLine($"Net Balance   : ${balance}");

        Console.WriteLine("\n----- REPORT -----");

        List<Transaction> allTransactions = new List<Transaction>();
        allTransactions.AddRange(incomeLedger.GetAll());
        allTransactions.AddRange(expenseLedger.GetAll());

        foreach(Transaction t in allTransactions)
        {
            Console.WriteLine(t.GetSummary());
        } 
    }
}