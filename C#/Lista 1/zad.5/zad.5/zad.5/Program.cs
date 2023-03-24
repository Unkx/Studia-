using System;

namespace Loop
{
    class WhileLoop
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= a)
            {
                int result = a * i;
                Console.WriteLine(result);
                i++;

            }
        }
    }
}