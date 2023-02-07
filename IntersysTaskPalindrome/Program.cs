namespace IntersysTaskPalindrome;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Provide string to check: ");
        var input = Console.ReadLine();
        var cleanInput = string.Concat(Array.FindAll(input.ToCharArray(), char.IsLetter)).ToLower();
        var result = CheckPalindrome(cleanInput);
        Console.WriteLine(result ? "YES" : "NO");
    }

    public static bool CheckPalindrome(string cleanInput)
    {
        var reverseCleanInput = Reverse(cleanInput);
        return cleanInput == reverseCleanInput;
    }

    public static string Reverse(string input)
    {
        var inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        return new string(inputArray);
    }
}