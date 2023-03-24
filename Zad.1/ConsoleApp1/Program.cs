using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj długość boku sześcianu : ");
        int bok = int.Parse(Console.ReadLine());
        int objetosc = SzescianObjetosc(bok);
        int polePowierzchni = SzescianPolePowierzchni(bok);

        Console.WriteLine("Objętość sześcianu : {0}", objetosc);
        Console.WriteLine("Pole powierzchni sześcianu : {0}", polePowierzchni);

    }
    public static int SzescianObjetosc(int bok)
        {
            return bok * bok * bok;
        }
    public static int SzescianPolePowierzchni(int bok)
    {
        return 6 * bok * bok;
    }
}

