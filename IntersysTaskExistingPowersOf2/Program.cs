namespace IntersysTaskExistingPowersOf2;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = new List<int>();

        Console.WriteLine("Enter as much integers as you want (provide empty line to stop): ");
        while (true)
        {
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) break;
            numbers.Add(int.Parse(input));
        }

        var powersOfTwo = new List<int>();
        for (var i = 0; i < numbers.Count; i++)
        {
            var powerOfTwo = (int) Math.Pow(2, i);
            if (numbers.Any(n => (n & powerOfTwo) == powerOfTwo)) powersOfTwo.Add(powerOfTwo);
        }

        if (powersOfTwo.Count == 0)
            Console.WriteLine("NA");
        else
            Console.WriteLine(string.Join(", ", powersOfTwo.OrderBy(x => x)));
    }
}