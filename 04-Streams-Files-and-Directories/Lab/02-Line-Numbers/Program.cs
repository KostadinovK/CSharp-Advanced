using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        using (StreamWriter writer = new StreamWriter("Output.txt"))
        {
            using (StreamReader reader = new StreamReader(@"../../../../../Lab Resources/02. Line Numbers/Input.txt"))
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    string toWrite = "" + lineNumber + ".  " + line;
                    writer.WriteLine(toWrite);

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}
