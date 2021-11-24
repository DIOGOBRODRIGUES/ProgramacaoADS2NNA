using System;

namespace Aula4_2NMA_ADS
{
    class Aula4
    {
        static void Main(string[] args)
        {
            /*// exemplo - 1 -------------------------------------------------------------------
            string clima = "chuvoso";

            if(clima == "chuvoso")
            {
                Console.WriteLine("Não saia, esta chovendo.");
            }
            
            else if(clima == "ensolarado")
            {
                Console.WriteLine("Va brincar la fora, o dia esta ensolarado.");
            }

            else
            {
                Console.WriteLine("Não foi possivel determinar o clima. Tente novamente.");
            }

            Console.ReadLine();
            //---------------------------------------------------------------------------------*/

            /* // exemplo 2 --------------------------------------------------------

             int numero;
             Console.WriteLine("Digite um número: ");
             numero = Int32.Parse(Console.ReadLine());

             if (numero == 1) 
             {
                 Console.WriteLine("O número digitado foi o número 1. ");
             }
             else
             {
                 Console.WriteLine("O número digitado não foi o número 1. ");
             }

             Console.ReadLine();
             //------------------------------------------------------------------------*/


            /*// exemplo 3 --------------------------------------------------
           
            double n1, n2, m;
            string msg;

            Console.Write("Digite a 1a. nota: ");
            n1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a 2a. nota: ");
            n2 = Double.Parse(Console.ReadLine());

            m = (n1 + n2) / 2;

            msg = (m >= 7) ? "passou" : "reprovou";

            Console.WriteLine("Você {0}", msg);

            Console.ReadKey();
            //----------------------------------------------------------------------------------- */

            /*//exemplo 4 -------------------------------------------------------------------------

            string clima = "nublado";

            switch (clima)
            {
                case "chuvoso":
                    Console.WriteLine("Não saia, esta chovendo.");
                    break;

                case "ensolarado":
                    Console.WriteLine("Va brincar la fora.");
                    break;

                case "nublado":
                    Console.WriteLine("Va brincar la fora, mas leve seu guarda-chuva.");
                    break;

                default:
                    Console.WriteLine("Não foi possivel determinar o clima.");
                    break;
            }

            Console.ReadKey();
            //-------------------------------------------------------------------------*/

            /*//exemplo 5 - ----------------------------------------------

            int mes = DateTime.Today.Month;
            switch(mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                case 9:
                    Console.WriteLine("Setembro");
                    break;

                default:
                    Console.WriteLine("Outro Mês");
                    break;
            }

            //----------------------------------------------------------------------*/1
        }
    }
}
