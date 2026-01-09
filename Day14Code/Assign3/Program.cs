public class Program
{
    public static void Main()
    {
        try
        {
            CricketMatch match = new CricketMatch();

            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            foreach (string val in values)
            {
                int score = int.Parse(val);
                match.AddPlayerScore(score);
            }

            int totalScore = match.CalculateTotalScore();
            Console.WriteLine($"Total score of the cricket team: {totalScore}");
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