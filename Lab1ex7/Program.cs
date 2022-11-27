using System;

namespace Lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar */

            Console.WriteLine("Introduceti un numar: ");

            int numar = int.Parse(Console.ReadLine());

            if (numar % 2 == 0)
                Console.WriteLine("Numarul este par");
            else Console.WriteLine("Numarul este impar");

        }
    }
}
