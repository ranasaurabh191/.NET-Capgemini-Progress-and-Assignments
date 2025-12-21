// 12) program to read student num,name,mark of six subject in property and 
// calculate total and average and print result and division */
// program that reads a student’s exam score from the user and determines their grade based on the following grading scale:
// •	Score ≥ 90 : Grade A
// •	80 ≥ Score < 90 : Grade B
// •	70 ≥ Score < 80 : Grade C
// •	60 ≥ Score < 70 : Grade D
// •	Score < 60 : Grade Fusing System;

using System;
class Students
{
    private int studentNum = 0;
    private string studentName = "Not Assigned";
    private int subject1 = 0;
    private int subject2 = 0;   
    private int subject3 = 0;
    private int subject4 = 0;
    private int subject5 = 0;
    private int subject6 = 0;
    public int StudentNum
    {
        get { return studentNum; }
        set { studentNum = value; }
    }
    public string StudentName
    {
        get { return studentName; }
        set { studentName = value; }
    }
    public int Subject1
    {
        get { return subject1; }
        set { subject1 = value; }
    }
    public int Subject2
    {
        get { return subject2; }
        set { subject2 = value; }
    }
    public int Subject3
    {
        get { return subject3; }
        set { subject3 = value; }
    }
    public int Subject4
    {
        get { return subject4; }
        set { subject4 = value; }
    }
    public int Subject5
    {
        get { return subject5; }
        set { subject5 = value; }
    }
    public int Subject6
    {
        get { return subject6; }
        set { subject6 = value; }
    }

    public void AcceptDetails()
    {
        Console.WriteLine("Enter Student Number:");
        studentNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student Name:");
        studentName = Console.ReadLine();
        Console.WriteLine("Enter Marks for Subject 1:");
        subject1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Marks for Subject 2:");
        subject2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Marks for Subject 3:");
        subject3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Marks for Subject 4:");
        subject4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Marks for Subject 5:");
        subject5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Marks for Subject 6:");
        subject6 = Convert.ToInt32(Console.ReadLine());
    }
    public void calculateTotalAndAverage()
    {
        int total = subject1 + subject2 + subject3 + subject4 + subject5 + subject6;
        double average = total / 6.0;
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average Marks: " + average);

        if (average >= 90)
            Console.WriteLine("Grade A");
        else if (average >= 80)
            Console.WriteLine("Grade B");
        else if (average >= 70)
            Console.WriteLine("Grade C");
        else if (average >= 60)
            Console.WriteLine("Grade D");
        else
            Console.WriteLine("Grade F");
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Student Number: " + studentNum);
        Console.WriteLine("Student Name: " + studentName);
    }
}