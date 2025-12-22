// Case Study 5: Examination System – Output Parameters (out)
// Scenario
// An online examination system needs to calculate total marks and also return individual subject marks back to the caller.
// Requirement
// •	Accept two marks
// •	Return:
// o	Total marks
// o	Individual marks back to calling function
// C# Concepts Used
// •	out parameters
// •	Returning multiple values from a method
// Mapping to Code
// public void Addition(int n1, int n2, out int result, out int n3, out int n4)
// Learning Outcome
// ✔ Multiple outputs from a single method
// ✔ Use of out keyword in enterprise applications
// ________________________________________
class Program
{
    static void Main()
    {
        Examination exam = new Examination();

        int subjectMark1 = 85;
        int subjectMark2 = 90;

        exam.Addition(subjectMark1, subjectMark2, out int totalMarks, out int returnedMark1, out int returnedMark2);

        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Returned Subject Mark 1: " + returnedMark1);
        Console.WriteLine("Returned Subject Mark 2: " + returnedMark2);
    }
}