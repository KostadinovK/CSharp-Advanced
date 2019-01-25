using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

public class Program
{
    public static void Main()
    {
        Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader(@"../../../../../Lab Resources/03. Word Count/words.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] words = line.Split().Select(x => x.ToLower()).ToArray();
                foreach (var word in words)
                {
                    if (!wordOccurrences.ContainsKey(word))
                    {
                        wordOccurrences[word] = 0;
                    }
                }

                line = reader.ReadLine();
            }
        }

        using (StreamReader reader = new StreamReader(@"../../../../../Lab Resources/03. Word Count/text.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] words = line.Split()
                    .Select(x => x.ToLower())
                    .Select(x => x.TrimStart(new []{'-',',','.','!','?'}))
                    .Select(x => x.TrimEnd(new []{ '-', ',', '.', '!', '?' }))
                    .ToArray();
                foreach (var word in words)
                {
                    if (wordOccurrences.ContainsKey(word))
                    {
                        wordOccurrences[word]++;
                        
                    }
                }

                line = reader.ReadLine();
            }
        }

        using (StreamWriter writer = new StreamWriter("Output.txt"))
        {
            foreach (var kvp in wordOccurrences.OrderByDescending(x => x.Value))
            {
                writer.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}