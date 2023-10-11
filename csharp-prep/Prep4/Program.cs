using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int max = 0;


        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
            
            if (number > max)
            {
                max = number;
            }
            
            sum += number;
        }


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The max is: {max}");

    }
}