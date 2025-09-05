using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
                break;
            numbers.Add(number);
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest_num = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largest_num)
            {
                largest_num = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest_num}");
    }
}