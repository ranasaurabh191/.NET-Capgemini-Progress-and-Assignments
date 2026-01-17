using System.Text.RegularExpressions;

namespace LogProcessing
{
    public class LogParser
    {
        private readonly string validLineRegexPattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
        private readonly string splitLineRegexPattern = @"<\*{3}>|<={4}>|<\^\*>";
        private readonly string quotedPasswordRegexPattern = @"(?i)""[^""]*password[^""]*""";
        private readonly string endOfLineRegexPattern = @"end-of-line\d+";
        private readonly string weakPasswordRegexPattern = @"(?i)password[a-z0-9]+";

        // ---------------- Task 1 ----------------
        public bool IsValidLine(string text)
        {
            return Regex.IsMatch(text, validLineRegexPattern);
        }

        // ---------------- Task 2 ----------------
        public string[] SplitLogLine(string text)
        {
            return Regex.Split(text, splitLineRegexPattern);
        }

        // ---------------- Task 3 ----------------
        public int CountQuotedPasswords(string lines)
        {
            MatchCollection matches = Regex.Matches(lines, quotedPasswordRegexPattern);

            return matches.Count;
        }

        // ---------------- Task 4 ----------------
        public string RemoveEndOfLineText(string line)
        {
            return Regex.Replace(line, endOfLineRegexPattern, "");
        }

        // ---------------- Task 5 ----------------
        public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match m = Regex.Match(lines[i], weakPasswordRegexPattern);

                if (m.Success)
                {
                    result[i] = m.Value + ": " + lines[i];
                }
                else
                {
                    result[i] = "--------: " + lines[i];
                }
            }

            return result;
        }
    }
}