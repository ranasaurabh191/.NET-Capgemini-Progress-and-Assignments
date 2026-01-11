using System.Collections;
class Program
{
    private static bool IsValidInput(string input)
    {
        return !string.IsNullOrWhiteSpace(input);
    }
    private static void DisplayAlbums(ArrayList albums)
    {
        foreach (Album a in albums)
        {
            Console.WriteLine("Title: {0}, Artist: {1}",a.Title,a.Artist);
        }
    }
    static void Main()
    {
        ArrayList albums = new ArrayList();
        while (true)
        {
            string title = Console.ReadLine() ?? "";
            if(title.ToLower() == "quit") break;
            string artist = Console.ReadLine() ?? "";
            if (!IsValidInput(title) || !IsValidInput(artist)) continue;
            albums.Add(new Album(title, artist));
        }
        DisplayAlbums(albums);
    }
}