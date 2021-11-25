using System;

namespace aula82nma
{
    class Program
    {     

        static void Main(string[] args)
        {
            linha();
            Console.WriteLine("Hello World!");
            linha();
            //adicao();
            
        }

        // primeiro método
        static void adicao()
        {
            int a, b, c;
            a = 100;
            b = 200;

            c = a + b;

            Console.WriteLine("o valor de c = " + c);
        }

        //segundo método
        static void linha()
        {
            Console.WriteLine("**************************");
        }
    }
}
