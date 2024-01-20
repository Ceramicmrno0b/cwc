using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int addNumber = 34;
        while (addNumber != 0)
        {
            Console.Write("Enter a number. Enter 0 to quit: ");
            
            string newNumber = Console.ReadLine();
            addNumber = int.Parse(newNumber);
            
            // Only add the number to the list if it is not 0
            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum of your numbers is: {total}");

         float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average of your numbers is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The highest number of your numbers is: {max}");
    }
}