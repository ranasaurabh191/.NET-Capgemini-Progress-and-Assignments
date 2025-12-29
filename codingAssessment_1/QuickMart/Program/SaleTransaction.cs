class SaleTransaction
{
    public string InvoiceNo{get;set;}
    public string CustomerName{get;set;}
    public string ItemName{get;set;}
    public int Quantity{get;set;}
    public decimal PurchaseAmount{get;set;}
    public decimal SellingAmount{get;set;}
    public string ProfitOrLossStatus{get;set;} = ""; 
    public decimal ProfitOrLossAmount{get;set;}
    public decimal ProfitMarginPercent{get;set;}

    public SaleTransaction(string InvoiceNo,string CustomerName,string ItemName,int Quantity,decimal PurchaseAmount,decimal SellingAmount){
        this.InvoiceNo=InvoiceNo;
        this.CustomerName=CustomerName;
        this.ItemName=ItemName;
        this.Quantity=Quantity;
        this.PurchaseAmount=PurchaseAmount;
        this.SellingAmount=SellingAmount;
        CalculateProfitLoss();
    }
    public static SaleTransaction LastTransaction;
    public static bool HasLastTransaction=false;

    public void CalculateProfitLoss()
        {
            if (SellingAmount > PurchaseAmount)
            {
                ProfitOrLossStatus = "PROFIT";
                ProfitOrLossAmount = SellingAmount - PurchaseAmount;
            }
            else if (SellingAmount < PurchaseAmount)
            {
                ProfitOrLossStatus = "LOSS";
                ProfitOrLossAmount = PurchaseAmount - SellingAmount;
            }
            else
            {
                ProfitOrLossStatus = "BREAK-EVEN";
                ProfitOrLossAmount = 0;
            }

            ProfitMarginPercent = ProfitOrLossAmount / PurchaseAmount * 100;
        }
    public void ViewTransaction()
    {
        Console.WriteLine("-------------- Last Transaction --------------");
        Console.WriteLine($"InvoiceNo: {InvoiceNo}");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Item: {ItemName}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Purchase Amount: {PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {SellingAmount:F2}");
        Console.WriteLine($"Status: {ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {ProfitMarginPercent:F2}");

    }
    public static void Create()
        {
            Console.Write("Enter Invoice No: ");
            string invoiceNo = Console.ReadLine()??"";
            if (string.IsNullOrWhiteSpace(invoiceNo))
            {
                Console.WriteLine("Invoice No cannot be empty.");
                return;
            }
            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine()??"";

            Console.Write("Enter Item Name: ");
            string itemName = Console.ReadLine()??"";

            Console.Write("Enter Quantity: ");
            if (!int.TryParse(Console.ReadLine()??"", out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0.");
                return;
            }

            Console.Write("Enter Purchase Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine()??"", out decimal purchaseAmount) || purchaseAmount <= 0)
            {
                Console.WriteLine("Purchase Amount must be greater than 0.");
                return;
            }

            Console.Write("Enter Selling Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal sellingAmount) || sellingAmount < 0)
            {
                Console.WriteLine("Selling Amount cannot be negative.");
                return;
            }

            LastTransaction = new SaleTransaction(
                invoiceNo,
                customerName,
                itemName,
                quantity,
                purchaseAmount,
                sellingAmount
            );

            HasLastTransaction = true;
            Console.WriteLine("Transaction saved successfully.");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
        }
        public static void View()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }
            LastTransaction.ViewTransaction();
        }
        public static void Recalculate()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }
            LastTransaction.CalculateProfitLoss();
            Console.WriteLine("Recalculated Profit/Loss:");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
        }

}