using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a task to run (1, 2, 3, or 4):");
        Console.WriteLine("1 - Palindrome Check");
        Console.WriteLine("2 - Temperature Conversion");
        Console.WriteLine("3 - Sort Numbers");
        Console.WriteLine("4 - Character Frequency Count");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                PalindromeCheck();
                break;
            case "2":
                TemperatureConversion();
                break;
            case "3":
                SortNumbers();
                break;
            case "4":
                CharacterFrequencyCount();
                break;
            default:
                Console.WriteLine("Invalid choice. Please run the program again.");
                break;
        }
    }

    static void PalindromeCheck()
    {
        Console.Write("Enter a word or phrase: ");
        string input = Console.ReadLine().ToLower().Replace(" ", ""); // Normalize input
        string reversed = new string(input.Reverse().ToArray());

        if (input == reversed)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not a Palindrome");
        }
    }

    static void TemperatureConversion()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose the conversion:");
        Console.WriteLine("1 - Fahrenheit");
        Console.WriteLine("2 - Kelvin");
        Console.Write("Enter your choice: ");
        string tempChoice = Console.ReadLine();

        switch (tempChoice)
        {
            case "1":
                double fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine($"Celsius: {celsius}, Fahrenheit: {fahrenheit:F1}");
                break;

            case "2":
                double kelvin = celsius + 273.15;
                Console.WriteLine($"Celsius: {celsius}, Kelvin: {kelvin:F2}");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void SortNumbers()
    {
        Console.Write("Enter numbers separated by commas (e.g., 9, 4, 7, 2, 5): ");
        string input = Console.ReadLine();
        int[] numbers = input.Split(',').Select(int.Parse).ToArray();

        Console.WriteLine("Choose sorting method:");
        Console.WriteLine("1 - Ascending");
        Console.WriteLine("2 - Descending");
        Console.Write("Enter your choice: ");
        string sortChoice = Console.ReadLine();

        switch (sortChoice)
        {
            case "1":
                Array.Sort(numbers);
                Console.WriteLine("Ascending Order: " + string.Join(", ", numbers));
                break;

            case "2":
                Array.Sort(numbers);
                Array.Reverse(numbers);
                Console.WriteLine("Descending Order: " + string.Join(", ", numbers));
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void CharacterFrequencyCount()
    {
        Console.Write("Enter a text: ");
        string input = Console.ReadLine();
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency[c] = 1;
            }
        }

        foreach (var pair in frequency)
        {
            Console.WriteLine($"'{pair.Key}': {pair.Value} time(s)");
        }
    }
}
