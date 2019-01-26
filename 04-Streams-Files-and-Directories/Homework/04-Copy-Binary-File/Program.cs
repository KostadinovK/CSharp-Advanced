using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        using (var reader = new FileStream("../../../copyMe.png", FileMode.Open))
        {
            using (var writer = new FileStream("../../../copied.png",FileMode.Create))
            {
                while (true)
                {
                    byte[] buffer = new byte[4096];

                    int readedBytes = reader.Read(buffer, 0, buffer.Length);

                    if (readedBytes == 0)
                    {
                        break;
                    }

                    writer.Write(buffer, 0, readedBytes);
                }
                
            }
        }
    }
}

