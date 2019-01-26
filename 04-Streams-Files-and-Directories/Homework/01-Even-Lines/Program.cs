using System;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        using (var reader = new StreamReader("../../../text.txt"))
        {
            using (var writer = new StreamWriter("../../../output.txt"))
            {
                string line = reader.ReadLine();

                int currentLine = 0;
                while (line != null)
                {
                    if (currentLine % 2 == 0)
                    {
                        string[] words = line.Split().Reverse()
                            .Select(x => x.Replace("-", "@"))
                            .Select(x => x.Replace(",", "@"))
                            .Select(x => x.Replace(".", "@"))
                            .Select(x => x.Replace("!", "@"))
                            .Select(x => x.Replace("?", "@"))
                            .ToArray();

                        writer.WriteLine(string.Join(" ", words));
                    }


                    currentLine++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

