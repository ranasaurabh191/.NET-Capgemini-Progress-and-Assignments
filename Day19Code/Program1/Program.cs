using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        
    List<string> Emails = new List<string>
    {
        "john.doe@gmail.com",
        "alice_123@yahoo.in",
        "mark.smith@company.com",
        "support-abc@banking.co.in",
        "user.nametag@domain.org",
        "john.doe@gmail",          // Missing domain extension
        "alice@@yahoo.com",        // Double @
        "mark.smith@.com",         // Domain missing name
        "support@banking..com",    // Double dot in domain
        "user name@gmail.com",     // Space not allowed
        "@domain.com",             // Missing username
        "admin@domain",            // No top-level domain
        "info@domain,com",         // Comma instead of dot
        "finance#dept@corp.com",   // Invalid character #
        "plainaddress" ,           // Missing @ and domain
        "abc@gmail.com.def@yahoo.com"
    };


        string pattern = @"\b[\w.-]+@[\w-]+\.\w{2,}$\b";

        foreach (string email in Emails)
        {
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine(email + " -> Valid");
            }
            else
            {
                Console.WriteLine(email + " -> Invalid");
            }
        }
    }
}
