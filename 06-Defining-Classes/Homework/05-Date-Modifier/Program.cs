using System;


public class Program
{
    public static void Main()
    {
        DateModifier modifier = new DateModifier();

        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();

        Console.WriteLine(modifier.CalculateDayDifferenceBetweenTwoDates(date1,date2));
    }
}

