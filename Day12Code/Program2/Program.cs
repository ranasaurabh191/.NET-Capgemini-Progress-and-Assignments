class Program
{
    static void Main()
    {
        
        
        // try{
        //     int num1 = Convert.ToInt32(Console.ReadLine());
        //     int num2 = Convert.ToInt32(Console.ReadLine());
        //     int result;
        //     result = num1/num2;
        //     Console.WriteLine("Result: "+result);

        // }
        // // catch(DivideByZeroException)
        // // {
        // //     Console.WriteLine("Enter non 0 number");
        // // }
        // // catch (FormatException)
        // // {
        // //     Console.WriteLine("Enter integer");
        // // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Code executed finally");
        // }
       
       

        
        try
        {
           int age = 12;
           if (age < 18)
            {
                throw new AgeNotValid("no");
            }

        }
        catch (AgeNotValid ex)
        {
            Console.WriteLine(ex.Message);
        }
    

    }

}