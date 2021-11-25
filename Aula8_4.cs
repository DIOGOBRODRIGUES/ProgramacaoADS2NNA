using System;

namespace aula82nmaparte4
{
    class Program
    {
        static void Main(string[] args)
        {

            float media = calcularMedia(18.5f, 2);
            Console.WriteLine("A média é " + media);
            Console.ReadKey();
        }

        static float calcularMedia(float soma, int cont)
        {
            float media;
            media = soma / cont;

            return media;
        }
    }
}
