using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string text = File.ReadAllText(@"../../../../../Lab Resources/05. Slice File/sliceMe.txt");

        int fileLenght = (int)Math.Ceiling((double)text.Length / 4);


        int charsWritten = 0;
        for (int i = 1; i <= 4; i++)
        {
            using (var writer = new StreamWriter("slice-" + i + ".txt"))
            {
                writer.Write(text.ToCharArray(), charsWritten, fileLenght);
                charsWritten += fileLenght - 1;
            }
        }
    }
}

