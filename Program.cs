using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a program:");
        Console.WriteLine("1. Simple calculator");
        Console.WriteLine("2. Sum all numbers from 1 to a given number");
        Console.WriteLine("3. Check if a number is even or odd");
        Console.Write("Enter the program number: ");
        
        string choice = Console.ReadLine();
        
        if (choice == "1")
        {
            Console.Write("Enter the first number: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Enter the second number: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.Write("Enter an operation (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine($"Result: {num1 + num2}");
                            break;
                        case "-":
                            Console.WriteLine($"Result: {num1 - num2}");
                            break;
                        case "*":
                            Console.WriteLine($"Result: {num1 * num2}");
                            break;
                        case "/":
                            if (num2 != 0)
                                Console.WriteLine($"Result: {num1 / num2}");
                            else
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            break;
                        default:
                            Console.WriteLine("Invalid operation.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }
        }
        else if (choice == "2")
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");
            }
            else
            {
                Console.WriteLine("Please enter a valid positive number.");
            }
        }
        else if (choice == "3")
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                    Console.WriteLine($"{number} is even.");
                else
                    Console.WriteLine($"{number} is odd.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid program choice.");
        }
    }
}
