using System;
Console.Write("Lets Convert Your Dollar to Sum Enter how much dollars you Have:");

int ConvertedDollar = System.Convert.ToInt32(Console.ReadLine());

ConvertedDollar *= 12400;
System.Console.WriteLine(ConvertedDollar);

int ConvertedSum = ConvertedDollar;
Console.WriteLine($"converted your dollars to {ConvertedSum} sums");