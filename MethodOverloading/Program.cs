namespace MethodOverloading
{
    public class Program
    {
        public static int Add (int x, int y)
        {
            return x + y;
        }

        public static decimal Add (decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool dollars)
        {
            int sum = x + y;
            if (dollars)
            {
                if (sum != 1)
                {
                    return $"{sum} dollars";
                }
                else
                {
                    return $"{sum} dollar";
                }
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another integer: ");
            var y = int.Parse(Console.ReadLine());
            var intSum = Add(x, y);
            Console.WriteLine();

            Console.WriteLine("Enter a number: ");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            var b = decimal.Parse(Console.ReadLine());
            var decimalSum = Add(a, b);
            Console.WriteLine();

            Console.WriteLine("Enter an integer: ");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another integer: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is {m} and {n} money? y/n");
            var yn = Console.ReadLine();
            bool dollar;
            if (yn == "y")
            {
                dollar = true;
            }
            else
            {
                dollar = false;
            }
            var accountSum = Add(n, m, dollar);
            Console.WriteLine();

            Console.WriteLine($"int add: {intSum}, decimal add: {decimalSum}, account add: {accountSum}");
        }
    }
}
