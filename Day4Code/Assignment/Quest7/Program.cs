// Case Study 7: Console Application – Main Method Integration
// Scenario
// A console-based testing application is used by trainees to test all calculator features from a single entry point.
// Requirement
// •	Create object
// •	Call calculation method
// •	Display final output
// Mapping to Code
// Calculator calculator2 = new Calculator();
// calculator2.Addition(num1, num2, out result, out num3, out num4);
// Learning Outcome
// ✔ Program flow control
// ✔ Object interaction in Main method
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