using System;

namespace aula82nmaparte5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            z = somaDobro(x, y); // parâmetros reais
            Console.WriteLine(" A soma do dobro do numeros {0} e {1} é {2} ", x, y, z);
            Console.ReadKey();
       }

        static int somaDobro(int num1, int num2)// parâmetros formais
        {
            int soma;
            num1 = num1 * 2;
            num2 = num2 * 2;

            soma = num1 + num2;
            return soma;
        }
    }
}
