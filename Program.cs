using System;
using System.Collections.Generic;

public enum Grade
{
    A, B, C, D, E, F
}

public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int GradeLevel { get; set; }
    public Grade Grade { get; set; }

    public Student(string firstName, string lastName, int gradeLevel, Grade grade)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        GradeLevel = gradeLevel;
        Grade = grade;
    }
}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }

    public Car(string brand, string model, decimal price)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }
}

public class Boxer
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Weight { get; set; }

    public Boxer(string firstName, string lastName, int age, decimal weight)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Weight = weight;
    }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ali", "Veli", 9, Grade.A),
            new Student("Zafar", "Tashkent", 10, Grade.B),
            new Student("Nodir", "Yusufov", 11, Grade.C),
            new Student("Shaxzod", "Abdullayev", 9, Grade.A),
            new Student("Olim", "Rakhmonov", 10, Grade.D)
        };

        List<Car> cars = new List<Car>
        {
            new Car("Toyota", "Corolla", 18000m),
            new Car("Honda", "Civic", 20000m),
            new Car("Ford", "Fiesta", 15000m),
            new Car("BMW", "X5", 50000m),
            new Car("Audi", "A3", 22000m)
        };

        List<Boxer> boxers = new List<Boxer>
        {
            new Boxer("Shavkat", "Mirziyoyev", 28, 48),
            new Boxer("Abdulloh", "Iskandarov", 30, 55),
            new Boxer("Alisher", "Qodirov", 26, 95),
            new Boxer("Kamol", "Asqarov", 32, 72),
            new Boxer("Botir", "Shamsiev", 25, 91)
        };

        Console.WriteLine("Tanlang:");
        Console.WriteLine("1. O'quvchilarni bahosi bo'yicha filtrlash");
        Console.WriteLine("2. Avtomobillarni narx oraliqda filtrlash");
        Console.WriteLine("3. Bokschilarni vazniga qarab saralash");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Bahoni kiriting (A, B, C, D, E, F): ");
                string inputGrade = Console.ReadLine();
                if (Enum.TryParse(inputGrade, out Grade grade))
                {
                    Console.WriteLine($"Bahosi {grade} bo'lgan o'quvchilar:");
                    foreach (var student in students)
                    {
                        if (student.Grade == grade)
                        {
                            Console.WriteLine($"{student.FirstName} {student.LastName} - {student.GradeLevel}-sinf");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Noto'g'ri baho kiritildi.");
                }
                break;

            case 2:
                Console.Write("Birinchi narxni kiriting: ");
                decimal price1 = decimal.Parse(Console.ReadLine());

                Console.Write("Ikkinchi narxni kiriting: ");
                decimal price2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Narx oraliqda joylashgan avtomobillar:");
                foreach (var car in cars)
                {
                    if (car.Price >= price1 && car.Price <= price2)
                    {
                        Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Price: {car.Price:C}");
                    }
                }
                break;

            case 3:
                Console.WriteLine("Yengil vaznli bokschilar (50 kg gacha):");
                foreach (var boxer in boxers)
                {
                    if (boxer.Weight <= 50)
                    {
                        Console.WriteLine($"{boxer.FirstName} {boxer.LastName} - {boxer.Weight} kg");
                    }
                }

                Console.WriteLine("\nO'rta vaznli bokschilar (50 kg dan 76 kg gacha):");
                foreach (var boxer in boxers)
                {
                    if (boxer.Weight > 50 && boxer.Weight <= 76)
                    {
                        Console.WriteLine($"{boxer.FirstName} {boxer.LastName} - {boxer.Weight} kg");
                    }
                }

                Console.WriteLine("\nOg'ir vaznli bokschilar (90 kg va undan og'irlar):");
                foreach (var boxer in boxers)
                {
                    if (boxer.Weight >= 90)
                    {
                        Console.WriteLine($"{boxer.FirstName} {boxer.LastName} - {boxer.Weight} kg");
                    }
                }
                break;

            default:
                Console.WriteLine("Noto'g'ri tanlov.");
                break;
        }
    }
}
