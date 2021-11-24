using System;

namespace ConsoleApp6
{
    class Aula6
    {
        static void Main(string[] args)
        {
			/*
			//Exemplo 1-- For
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Bem vindo ao FOR i = " + i);
			}*/

			/*
				// Exemplo 2 --- Tabuada
				int n, r;
			Console.Write("Digite um numero: ");
			n = Int32.Parse(Console.ReadLine());

			for (int i = 1; i < 11; i++)
			{
				r = n * i;
				//Console.WriteLine($"{n} x {i} = {r}");
				Console.WriteLine("{0} x {1} = {2}", n, i, r);
			}*/

			// Exemplo 3 - while
			/*
			int i = 1;
			while(i <= 10)
            {
				Console.WriteLine("Bem vindo ao while i = " + i);
				i++;
			}
			*/

			// exemplo 4 -- while
			/*
			int t = 0, nc = 0, nu = 0;
			Random r = new Random();
			nc = r.Next(1, 10);

			while(nc != nu)
            {
				Console.WriteLine("Digite um numero ( 1 - 9)");
				nu = Int32.Parse(Console.ReadLine());
				t++;
            }
			Console.WriteLine("Parabéns, você acertou em {0} tentativas", t);
			Console.ReadKey();
			*/

			//exemplo 5 - do while
			/*int i = 1;
			do
			{
				Console.WriteLine("Bem vindo ao do while i = " + i);
				i++;
			} while (i <= 10);
			*/

			//exemplo 6  - do while
			/*
			int nd = 0, nm = 0;
			do
			{
				Console.WriteLine("Digite um número (para sair digite 0):");
				nd = Int32.Parse(Console.ReadLine());
				if(nd > nm)
                {
					nm = nd;
                }
			} while (nd != 0);

			Console.WriteLine("O maior número digitado foi: {0}", nm);
			Console.ReadKey();
			*/

			// exemplo 7 foreach
			/*
			foreach (char c in "Bem vindo ao foreach!")
            {
				Console.WriteLine(c);
            }*/

			//exemplo 8 
			/*
			string[] carros = new string[5] { "Fusca", "Gol", "Uno", "Saveiro", "Palio" };
			
			foreach(string modelo in carros)
            {
					Console.WriteLine("Modelo: {0}", modelo);
            }
			

			for(int i = 0; i < carros.Length; i++)
            {
				Console.WriteLine("Modelo: {0}", carros[i]);
			}

			Console.WriteLine("Modelo: {0}", carros[1]);

			Console.ReadKey();
			*/

			// soma de 10 números
			/*
			double soma = 0, valor = 0, media =0;

			for(int i = 0; i < 10; i++)
            {
				Console.WriteLine("Digite um número");
				valor = Int32.Parse(Console.ReadLine());
				soma += valor;
            }

			media = soma / 10;
			*/
		}// MAIN
    }//CLASS
}//namespace
