namespace Lab10.Main;
using System.Diagnostics;
class Program
{
    public static void Main()
    {
        Console.WriteLine("It took: " + BenchmarkSelectionSort() + " milliseconds " + "and It took " + BenchmarkQuickSort() + " milliseconds to sort the array");
    }

    private static double BenchmarkSelectionSort()
    {
        int[] numbers = (File.ReadAllLines("numbers.txt")
            .Select(x => int.Parse(x))
            .ToArray());
        Stopwatch sw = new Stopwatch();
        sw.Start();
        SelectionSort1.SelectionSort(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        sw.Stop();
        return (sw.ElapsedMilliseconds / 1000.0);
    }

    private static double BenchmarkQuickSort()
    {
        int[] numbers = (File.ReadAllLines("numbers.txt")
               .Select(x => int.Parse(x))
               .ToArray());
        Stopwatch sw = new Stopwatch();
        sw.Start();
        QuickSortClass.QuickSort(numbers, 0, numbers.Length - 1);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        sw.Stop();
        return (sw.ElapsedMilliseconds / 1000.0);
    }
}