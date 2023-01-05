using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        int sum = 0;
        float average = 0;
        int max = 0;
        int minPositive = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        while (number != 0);

        foreach (int num in numbers)
        {
            sum += num;
            if(num > max){
                max = num;
            }
            if(num > 0 && (num < minPositive || minPositive == -1)){
                minPositive = num;
            }
        }
        average = (float)sum / numbers.Count;

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        if(minPositive != -1){
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }

        Console.WriteLine("The sorted list of numbers is: ");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}