using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            number = int.Parse(Console.ReadLine());

            if (number != 0)  // Only add non-zero numbers to the list
            {
                numberList.Add(number);
            }
        }

        int sum = 0;
        foreach (int num in numberList)
        {
            sum += num;
        }

        double average = (double)sum / numberList.Count;
        Console.WriteLine($"The average is: {average}");
        int largest = numberList[0];
        foreach (int num in numberList)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest is: {largest}");
    }
}