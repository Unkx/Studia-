using System;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main(string[] args)
    {
        int max = 0; // zmienna przechowująca maksymalną wartość
        int n; // zmienna przechowująca kolejną wczytywaną liczbę

        do
        {
            Console.Write("Podaj liczbę (0 kończy wprowadzanie): ");
            n = int.Parse(Console.ReadLine());

            if (n > max) // jeśli aktualna liczba jest większa od dotychczasowej maksymalnej wartości
            {
                max = n; // aktualizuj maksymalną wartość
            }
        } while (n != 0); // kontynuuj wczytywanie liczb dopóki nie zostanie podana liczba 0

        Console.WriteLine("Największa liczba to : " + max ); // zwróć maksymalną wartość

    }
}