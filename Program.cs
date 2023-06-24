using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
            • Exemplu: citim ,9,0 Afisam : 0 9
         */

            Console.WriteLine("introduceti primul numar");
            int numar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti al doilea numar");
            int numar2 = int.Parse(Console.ReadLine());

            if (numar1 <numar2)
                Console.WriteLine(numar1 + "," + numar2);
            else
                Console.WriteLine(numar2 + "," + numar1);
        }
    }
}
