using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        HashSet<string> vipGuests = new HashSet<string>();
        HashSet<string> normalGuests = new HashSet<string>();

        string guest = Console.ReadLine();

        while (guest != "PARTY")
        {
            if (guest[0] >= '0' && guest[0] <= '9')
            {
                vipGuests.Add(guest);
            }
            else
            {
                normalGuests.Add(guest);
            }

            guest = Console.ReadLine();
        }

        guest = Console.ReadLine();

        int missingGuests = vipGuests.Count + normalGuests.Count;

        while (guest != "END")
        {
            if (guest[0] >= '0' && guest[0] <= '9')
            {
                if (vipGuests.Contains(guest))
                {
                    vipGuests.Remove(guest);
                    missingGuests--;
                }
            }
            else
            {
                if (normalGuests.Contains(guest))
                {
                    normalGuests.Remove(guest);
                    missingGuests--;
                }
            }

            guest = Console.ReadLine();
        }

        Console.WriteLine(missingGuests);
        if (vipGuests.Any())
        {
            Console.WriteLine(string.Join('\n', vipGuests));
        }

        if (normalGuests.Any())
        {
            Console.WriteLine(string.Join('\n', normalGuests));
        }

        
    }
}

