using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        using (var reader = new StreamReader("../../../text.txt"))
        {
            using (var writer = new StreamWriter("../../../output.txt"))
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    int charsCount = line.Where(x => Char.IsLetter(x) || Char.IsDigit(x)).ToArray().Length;
                    int punctuationCharsCount = line
                        .Where(x => x == '-' || x == '.' || x == ',' || x == '?' || x == '!' || x == '\'')
                        .ToArray().Length;

                    writer.WriteLine($"Line {lineNumber}: {line}({charsCount})({punctuationCharsCount})");

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}
