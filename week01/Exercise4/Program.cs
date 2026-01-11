using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers,type 0 when you finished.");

        int userNumber = -1;
        while (userNumber != 0 )
        {
            Console.WriteLine("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)

            {
                numbers.Add(userNumber);
            }

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($" The sum is: {sum}");
        float average = ((float)sum) / userNumber.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        
    }
}