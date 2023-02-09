namespace IntersysTaskDigitSum;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Provide number of numbers to check: ");
        var inputNum = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Provide {inputNum} numbers to check: ");
        var numbers = Console.ReadLine()!.Split(' ');
        var numbersArray = Array.ConvertAll(numbers, int.Parse);
        
        var maxDigitSum = 0;
        var maxDigitSumIndex = 0;
        for (var i = 0; i < inputNum; i++)
        {
            var digitSum = DigitSum(numbersArray[i]);
            if (digitSum > maxDigitSum)
            {
                maxDigitSum = digitSum;
                maxDigitSumIndex = i;
            }
        }
        Console.WriteLine(maxDigitSumIndex);
    }

    private static int DigitSum(int number)
    {
        var digitSum = 0;
        while (number > 0)
        {
            digitSum += number % 10;
            number /= 10;
        }
        return digitSum;
    }
}