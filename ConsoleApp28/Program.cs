class Program
{
    static (int count, List<int> positions) LinearSearch(int[] array, int target)
    {
        int count = 0;
        List<int> positions = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                count++;
                positions.Add(i);
            }
        }

        return (count, positions);
    }

    static void Main()
    {
        int[] numbers = { 1, 3, 7, 8, 3, 5, 3, 9, 10 };
        int target = 3;

        var result = LinearSearch(numbers, target);

        Console.WriteLine($"Намерени са {result.count} елемента със стойност {target}.");
        Console.WriteLine("Позиции на намерените елементи:");
        foreach (int position in result.positions)
        {
            Console.WriteLine(position);
        }
    }
}