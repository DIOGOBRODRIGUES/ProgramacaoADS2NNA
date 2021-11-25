using System;

namespace aula82nmaparte3
{
  
    class Program
    {
        float diogo;// variavel global 
        static void Main(string[] args)
        {
            float a, x, y, z;
            Console.WriteLine("Digite o valor de X: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y: ");
            y = float.Parse(Console.ReadLine());
            //z vai armazenar o valor da soma entre x e y
            z = soma(x, y); // parâmetros reais
            Console.WriteLine("o valor da soma é " + z);
            Console.ReadKey();

            
        }

        static float soma(float a, float b) // parâmetros formais
        {
            float aux;// variavel local
            aux = a + b;
            a = 10;
            return aux;
        }
    }
}
