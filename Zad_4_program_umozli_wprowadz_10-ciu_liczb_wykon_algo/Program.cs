using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Tablica na 10 liczb wprowadzonych przez użytkownika
        int[] numbers = new int[10];

        // Pobranie 10 liczb od użytkownika
        Console.WriteLine("Wprowadź 10 liczb:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            // Parsujemy liczby do tablicy - przyjmujemy tylko liczby całkowite
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Niepoprawna wartość, wprowadź liczbę całkowitą: ");
            }
        }

        // Obliczenia na tablicy
        int suma = numbers.Sum();                // Suma elementów
        int iloczyn = numbers.Aggregate(1, (acc, val) => acc * val); // Iloczyn elementów
        double srednia = numbers.Average();       // Średnia elementów
        int minimum = numbers.Min();              // Wartość minimalna
        int maksimum = numbers.Max();             // Wartość maksymalna

        // Wyświetlanie wyników
        Console.WriteLine("\nWyniki:");
        Console.WriteLine($"Suma elementów: {suma}");
        Console.WriteLine($"Iloczyn elementów: {iloczyn}");
        Console.WriteLine($"Średnia wartość: {srednia}");
        Console.WriteLine($"Wartość minimalna: {minimum}");
        Console.WriteLine($"Wartość maksymalna: {maksimum}");
    }
}
