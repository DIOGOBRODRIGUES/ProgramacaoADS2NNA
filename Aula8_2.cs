using System;

namespace aula82nmaparte2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroLinhas;
            Console.WriteLine("Escreve o número de linhas a imprimir");
            numeroLinhas = int.Parse(Console.ReadLine());
            for(int i = 0; i < numeroLinhas; i++)
            {
                linha();
            }
            
            Console.ReadKey();
        }

        static void linha()
        {
            int i;
            for (i = 1; i<= 20; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        
    }
}
