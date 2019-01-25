using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        using (var writer = new StreamWriter("Output.txt"))
        {
            using (var reader = new StreamReader(@"../../../../../Lab Resources/01. Odd Lines/Input.txt"))
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        writer.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}

