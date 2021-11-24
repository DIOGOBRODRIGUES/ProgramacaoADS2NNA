using System;

namespace Aula7ADSM
{
    class Aula7
    {
        static void Main(string[] args)
        {

            // exemplo 1 ***************************************************************
            /*
            int[] salarios = new int[10] { 78, 15, 27, 87, 56, 74, 12, 36, 98, 41 };

            int a = salarios[0];
            int b = salarios[5];
            Console.WriteLine(a + b);
            salarios[0] = 25;
            salarios[5] = 25;

            for(int i = 0; i < salarios.Length; i++)
            {
                Console.Write(salarios[i] + " ");
            }
            */

            //exemplo2 *********************************************
            /*
            int[,] matrizSalarios = new int[2, 3];
            matrizSalarios[0, 0] = 10;
            matrizSalarios[0, 1] = 20;
            matrizSalarios[0, 2] = 30;
            matrizSalarios[1, 0] = 40;
            matrizSalarios[1, 1] = 50;
            matrizSalarios[1, 2] = 60;

            for(int linha = 0; linha < 2; linha++)
            {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matrizSalarios[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
            */

            // Exemplo 3 ***********************************************
            int[,] mapa = new int[5,5];
            int l, c, acertos = 0;

            //Gerar posições do submarino
            Console.WriteLine("Gerando Submarinos...");
            for(int i = 1; i < 5; i++)
            {
                Random r = new Random();
                l = r.Next(1, 5);
                c = r.Next(1, 5);

                mapa[l, c] = 1;

                //espera 4 segundos para gerar o próximo
                System.Threading.Thread.Sleep(400);
            }

            Console.Clear();

            //Gerando mapa 

            for(int i = 1; i <= 5; i++)
            {
                //Desenhar linha
                Console.SetCursorPosition(0, i * 2);
                Console.Write(i);

                //Desenhar coluna
                Console.SetCursorPosition(i * 3, 0);
                Console.Write(i);
            }
            // fluxo principal
            do
            {
               Console.SetCursorPosition(0, 12);
               Console.WriteLine("Digite a linha: ");
               l = int.Parse(Console.ReadLine());
               Console.WriteLine("Digite a coluna: ");
               c = int.Parse(Console.ReadLine());
               Console.SetCursorPosition(c * 3, l * 2);
               if(mapa[l-1, c-1] == 1)
                {
                    Console.Write("X");
                    acertos++;
                }
                else
                {
                    Console.Write("~");
                }
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("            ");
                Console.WriteLine("            ");
            } while (acertos != 3);
            Console.ReadKey();
        }// main
    }// class
}//namespace
