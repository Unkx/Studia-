using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę całkowitą:");
        int liczba = int.Parse(Console.ReadLine());

        Console.Write("Dzielniki liczby " + liczba + " to: ");
        for (int i = 1; i <= liczba; i++)
        {
            if (liczba % i == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
