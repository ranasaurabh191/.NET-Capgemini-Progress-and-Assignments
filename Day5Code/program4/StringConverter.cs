public class StringConverter
{
    public string ConvertString(string input)
    {
        return input.ToUpper();
    }

    public string ConvertString(string input, bool toLower)
    {
        return input.ToLower();
    }
    public string ConvertString(string input, int value)
    {
        char[] chars = input.ToLower().ToCharArray();

        if (chars.Length > 0)
            chars[0] = char.ToUpper(chars[0]);

        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i - 1] == ' ')
                chars[i] = char.ToUpper(chars[i]);
        }

        return new string(chars);
    }

}