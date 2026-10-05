public class Program
{
    public static void Main()
    {
        int[] numbers = { 7, 3, 9, 1, 5 };

        Array.Sort(numbers);

        Console.WriteLine("Ascending order:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Array.Reverse(numbers);

        Console.WriteLine("Reversed order:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int position = Array.IndexOf(numbers, 5);
        Console.WriteLine("Index of 5: " + position);
    }
}
