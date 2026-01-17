using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] logs =
        {
            "[INFO] 2025-03-21T14:22:19Z service=auth userId=USR_1023 action=LOGIN_SUCCESS ip=192.168.1.10",
            "[WARN] 2025-03-21T14:22:22Z service=auth userId=USR_2045 passwordTemp123 LOGIN_FAILED",
            "[ERROR] 2025-03-21T14:22:30Z service=payment txnId=TXN998877 amount=₹45,000.50 status=FAILED",
            "[DEBUG] <***> service=payment <===> txnId=TXN112233 amount=$1200 status=SUCCESS",
            "[INFO] \"user passwordReset456 completed successfully\"",
            "[CRITICAL] service=db query=\"SELECT * FROM users WHERE password='abc123'\"",
            "[KUBE] pod=api-gateway-7f9d8 container=nginx restartCount=3"
        };

        string headerRegex = @"^\[(INFO|WARN|ERROR|DEBUG|CRITICAL)\]\s\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])T([01]\d|2[0-3]):[0-5]\d:[0-5]\dZ";

        string serviceUserRegex = @"service=(?<service>[a-z]+)(?:.*userId=(?<userId>USR_\d+))?";

        string weakPasswordRegex = @"(?i)password[a-z0-9]+|password='[a-z0-9]+'";

        string transactionRegex = @"txnId=(?<txnId>TXN\d+).*amount=(?<amount>[₹$]\d{1,3}(?:,\d{3})*(?:\.\d+)?)";

        string unmaskedPasswordRegex = @"password=(?!\*+|X+|#+)[a-zA-Z0-9]+|password[a-zA-Z0-9]+";

        string sqlInjectionRegex = @"(?i)(?=.*select)(?=.*where)(?=.*password).*";

        string kubeRegex = @"pod=(?<pod>[a-zA-Z0-9-]+).*container=(?<container>\w+).*restartCount=(?<count>[1-9]\d*)";

        string highRiskRegex = @"(?i)(ERROR|CRITICAL|password|FAILED|restartCount=[3-9]\d*)";

        string isoRegex = @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])T([01]\d|2[0-3]):[0-5]\d:[0-5]\dZ$";

        Console.WriteLine("===== LOG ANALYSIS OUTPUT =====\n");

        foreach (string log in logs)
        {
            Console.WriteLine("LOG: " + log);

            // Task 1
            Console.WriteLine("Valid Header: " + Regex.IsMatch(log, headerRegex));

            // Task 2
            Match su = Regex.Match(log, serviceUserRegex);
            if (su.Success)
            {
                Console.WriteLine("Service: " + su.Groups["service"].Value);
                if (su.Groups["userId"].Success)
                    Console.WriteLine("UserId: " + su.Groups["userId"].Value);
            }

            // Task 3
            Match pw = Regex.Match(log, weakPasswordRegex);
            if (pw.Success)
                Console.WriteLine("Weak Password Detected: " + pw.Value);

            // Task 4
            Match txn = Regex.Match(log, transactionRegex);
            if (txn.Success)
            {
                Console.WriteLine("Transaction ID: " + txn.Groups["txnId"].Value);
                Console.WriteLine("Amount: " + txn.Groups["amount"].Value);
            }

            // Task 5
            Match unmasked = Regex.Match(log, unmaskedPasswordRegex);
            if (unmasked.Success)
                Console.WriteLine("Unmasked Secret: " + unmasked.Value);

            // Task 6
            if (Regex.IsMatch(log, sqlInjectionRegex))
                Console.WriteLine("SQL Injection Risk Detected");

            // Task 7
            Match kube = Regex.Match(log, kubeRegex);
            if (kube.Success)
            {
                Console.WriteLine("Pod: " + kube.Groups["pod"].Value);
                Console.WriteLine("Container: " + kube.Groups["container"].Value);
                Console.WriteLine("Restart Count: " + kube.Groups["count"].Value);
            }

            // Task 8
            if (Regex.IsMatch(log, highRiskRegex))
                Console.WriteLine("⚠ High Risk Log");

            Console.WriteLine("----------------------------------\n");
        }

        // ---------------- TASK 10 (REDACTION) ----------------
        Console.WriteLine("===== REDACTION =====");

        string sensitive = "User password=abc123 paid with card 1234-5678-9012-3456";

        sensitive = Regex.Replace(sensitive, @"password=[a-zA-Z0-9]+", "password=***REDACTED***");

        sensitive = Regex.Replace(sensitive, @"\d{4}-\d{4}-\d{4}-\d{4}", "XXXX-XXXX-XXXX-XXXX");

        Console.WriteLine(sensitive);
    }
}
