using System;

namespace Aula3EntradaSaidaADS2NMA
{
    class Aula3
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;

            Console.WriteLine("Qual o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade? ");
            idade = int.Parse(Console.ReadLine());

            bool maiorIdade = idade >= 18;

            Console.WriteLine("Seu nome é {0}, sua idade é {1}. Maior de idade? {2} ", nome, idade, maiorIdade);
        }
    }
}
