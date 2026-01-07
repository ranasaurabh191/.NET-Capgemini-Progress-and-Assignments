class Program
{
    static void Main()
    {
        try{
            CricketMatch cm = new CricketMatch();
            string input = Console.ReadLine()??"";
            string[] values = input.Split(' ');

            foreach (string val in values)
            {
                int score = Convert.ToInt32(val);
                cm.AddPlayerScore(score);
            }
            int totalScore = cm.CalculateTotalScore();
            Console.WriteLine("Total score of the cricket team: " + totalScore);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}