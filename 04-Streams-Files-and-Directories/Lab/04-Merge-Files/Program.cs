using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        List<int> nums = new List<int>();

        using (StreamReader reader = new StreamReader(@"../../../../../Lab Resources/04. Merge Files/FileOne.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                int num = int.Parse(line);

                nums.Add(num);

                line = reader.ReadLine();
            }
        }

        using (StreamReader reader = new StreamReader(@"../../../../../Lab Resources/04. Merge Files/FileTwo.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                int num = int.Parse(line);

                nums.Add(num);

                line = reader.ReadLine();
            }
        }

        nums.Sort();

        using (StreamWriter writer = new StreamWriter("Output.txt"))
        {
            foreach (var num in nums)
            {
                writer.WriteLine(num);
            }
        }
    }
}
