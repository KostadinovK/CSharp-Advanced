using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string[] files = Directory.GetFiles(@"../../../../../Lab Resources/06. Folder Size/TestFolder");

        double totalSizeInMB = 0;

        foreach (var file in files)
        {
            FileInfo info = new FileInfo(file);
            double fileSizeInMB = (double)info.Length / 1024 / 1024;
            totalSizeInMB += fileSizeInMB;
        }

        File.WriteAllText("Output.txt",totalSizeInMB.ToString());
    }
}
