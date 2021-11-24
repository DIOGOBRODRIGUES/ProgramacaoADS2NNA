using System;

namespace GameProf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mapa = new int[5, 5];
            int l, c, acertos = 0;


            //Gerar posições do submarino

            Console.WriteLine("Gerando Submarinos");
            for (int i = 1; i <= 5; i++)
            {
                Random r = new Random();
                l = r.Next(1, 5);
                c = r.Next(1, 5);

                mapa[l, c] = 1;

                //esperar 4 segundos para gerar o próximo 
                System.Threading.Thread.Sleep(400);

            }

            Console.Clear();

            //Gerando mapa

            for(int i = 1; i <= 5; i++)
            {
                //Desenha linha
                Console.SetCursorPosition(0, i * 2);
                Console.Write(i);

                //Desenha Coluna
                Console.SetCursorPosition(i *3, 0);
                Console.Write(i);
            }

            //fluxo principal 
            do
            {
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("Digite a linha");
                l = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite a coluna");
                c = Int32.Parse(Console.ReadLine());
                Console.SetCursorPosition(c * 3, l * 2);
                if (mapa[l - 1, c - 1] == 1)
                {
                    Console.Write("X");
                    acertos++;
                }
                else
                {
                    Console.Write("~");
                }
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("                   ");
                Console.WriteLine("                   ");
            } while (acertos != 5);
            Console.ReadKey();
        }
    }
}
