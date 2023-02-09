namespace IntersysTaskFindingPrimes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Provide number of test cases: ");
        var testCases = int.Parse(Console.ReadLine()!);

        while (testCases-- > 0)
        {
            Console.WriteLine("Provide range between numbers to check: ");
            var inputs = Console.ReadLine()!.Split();
            var m = int.Parse(inputs[0]);
            var n = int.Parse(inputs[1]);
            var count = 0;

            for (var i = m; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (var i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}