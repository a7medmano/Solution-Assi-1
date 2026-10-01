namespace Solution_Assi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine("Charges: $25 per small");
            Console.WriteLine("Charges: $35 per large");
            Console.WriteLine("Sales tax rate is 6%");
            Console.WriteLine("Estimates are valid for 30 days");

            Console.WriteLine();

            Console.Write("Number of small carpets: ");
            int small = int.Parse(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            int large = int.Parse(Console.ReadLine());

            double smallPrice = 25;
            double largePrice = 35;

            double smallCost = small * smallPrice;
            double largeCost = large * largePrice;

            double cost = smallCost + largeCost;

            double tax = cost * 0.06;

            double total = cost + tax;

            Console.WriteLine();

            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine($"Number of small carpets: {small}");
            Console.WriteLine($"Number of large carpets: {large}");
            Console.WriteLine($"Price per small carpet: ${smallPrice}");
            Console.WriteLine($"Price per large carpet: ${largePrice}");
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${total}");
        }
    }
}
