using System;

public class PatientBill
{
    public string BillId {get; set;}
    public string PatientName {get; set;}
    public bool HasInsurance {get; set;}
    public decimal ConsultationFees {get; set;}
    public decimal LabCharges {get; set;}
    public decimal MedicineCharges {get; set;}
    public decimal GrossAmount {get; set;}
    public decimal DiscountAmount {get; set;}
    public decimal FinalPayable {get; set;}

    public static PatientBill? LastBill;
    public static bool HasLastBill = false;

    public PatientBill(string BillId, string PatientName, bool HasInsurance, decimal ConsultationFees, decimal LabCharges, decimal MedicineCharges)
    {
        this.BillId = BillId;
        this.PatientName = PatientName;
        this.HasInsurance = HasInsurance;
        this.ConsultationFees = ConsultationFees;
        this.LabCharges = LabCharges;
        this.MedicineCharges = MedicineCharges;
        CalculateBill();
    }
    public void CalculateBill()
    {
        GrossAmount = ConsultationFees + LabCharges + MedicineCharges;
        if (HasInsurance){
            DiscountAmount = GrossAmount * 10/100;
        }else{
            DiscountAmount = 0;
        }
        FinalPayable = GrossAmount - DiscountAmount;
    }

    public static void Create()
    {
        Console.Write("Enter Bill Id: ");
        string billId = Console.ReadLine()??"";

        if (string.IsNullOrWhiteSpace(billId))
        {
            Console.WriteLine("Bill Id cannot be empty.");
            return;
        }

        Console.Write("Enter Patient Name: ");
        string patientName = Console.ReadLine()??"";

        Console.Write("Is the patient insured? (Y/N): ");
        bool hasInsurance = (Console.ReadLine()??"").ToUpper() == "Y";

        Console.Write("Enter Consultation Fee: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal consultationFee) || consultationFee <= 0)
        {
            Console.WriteLine("Consultation Fee must be greater than 0.");
            return;
        }

        Console.Write("Enter Lab Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal labCharges) || labCharges < 0)
        {
            Console.WriteLine("Lab Charges cannot be negative.");
            return;
        }

        Console.Write("Enter Medicine Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal medicineCharges) || medicineCharges < 0)
        {
            Console.WriteLine("Medicine Charges cannot be negative.");
            return;
        }

        LastBill = new PatientBill(
            billId,
            patientName,
            hasInsurance,
            consultationFee,
            labCharges,
            medicineCharges
        );

        HasLastBill = true;

        Console.WriteLine("Bill created successfully.");
        Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
    }


    public static void View()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        LastBill.ViewBill();
    }

    public static void Clear()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }
    public void ViewBill()
    {
        Console.WriteLine("----------- Patient Bill -----------");
        Console.WriteLine($"Bill Id: {BillId}");
        Console.WriteLine($"Patient Name: {PatientName}");
        Console.WriteLine($"Insured: {(HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fees: {ConsultationFees:F2}");
        Console.WriteLine($"Lab Charges: {LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {MedicineCharges:F2}");
        Console.WriteLine($"Gross Amount: {GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {FinalPayable:F2}");
        Console.WriteLine("-----------------------------------");
    }
}
