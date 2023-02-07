namespace IntersysTask1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Provide size of your input: ");
        var size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Provide chars to reverse: ");
        var numbers = Console.ReadLine();
        var trimmedNumbers = string.Concat((numbers ?? throw new InvalidOperationException()).Where(space => !char.IsWhiteSpace(space)));
        if(trimmedNumbers.Length == size) 
        {
            var reversedNumbers = Reverse(trimmedNumbers);
            var reversedAndJoinedNumbers = Join(reversedNumbers);
            Console.Write("Reversed chars are: " + reversedAndJoinedNumbers);
        }
        else
        {
            Console.WriteLine("Size of input is not equal to length of chars to reverse! Please try again.");
        }
    }

    public static string Reverse(string numbers)
    {
        var numbersArray = numbers.ToCharArray();
        Array.Reverse(numbersArray);
        return new string(numbersArray);
    }

    public static string Join(string textToJoin)
    {
        var chars = textToJoin.ToCharArray();
        return string.Join(" ", chars);
    }
}