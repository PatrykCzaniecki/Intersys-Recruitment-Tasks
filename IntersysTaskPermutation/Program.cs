namespace IntersysTaskPermutation;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstArray = new int[11];
        var secondArray = new int[11];

        Console.WriteLine("Enter the elements of the first array: ");
        for (var i = 0; i < 11; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Enter the elements of the second array: ");
        for (var i = 0; i < 11; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine()!);
        }

        var result = CheckPermutation(firstArray, secondArray);
        Console.WriteLine(result ? "YES" : "NO");
    }

    public static bool CheckPermutation(int[] firstArray, int[] secondArray)
    {
        return firstArray.Length == secondArray.Length &&
               firstArray.OrderBy(x => x).SequenceEqual(secondArray.OrderBy(x => x));
    }
}