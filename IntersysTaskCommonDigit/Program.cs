namespace IntersysTaskCommonDigit;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Provide number of numbers: ");
        var inputNumber = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Provide {inputNumber} numbers to check: ");
        
        var numbersArray = Console.ReadLine()!.ToCharArray();
        var newNumbersArray = numbersArray.Where(number => number != ' ').ToArray();
        CommonDigit(newNumbersArray);
    }

    private static void CommonDigit(IEnumerable<char> numbersArray)
    {
        var counts = new Dictionary<char, int>();
        foreach (var number in numbersArray)
        {
            if (!counts.ContainsKey(number))
            {
                counts[number] = 0;
            }
            counts[number]++;
        }

        var maxKey = counts.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        Console.WriteLine(maxKey);
    }
}