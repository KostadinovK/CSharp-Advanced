using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var shops = new Dictionary<string, Dictionary<string, double>>();

        string line = Console.ReadLine();
        while (line != "Revision")
        {
            string[] tokens = line.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string shop = tokens[0];
            string product = tokens[1];
            double price = double.Parse(tokens[2]);

            if (!shops.ContainsKey(shop))
            {
                shops[shop] = new Dictionary<string, double>();
            }

            shops[shop][product] = price;

            line = Console.ReadLine();
        }

        foreach (var shop in shops.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{shop.Key}->");
            foreach (var product in shop.Value)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}
