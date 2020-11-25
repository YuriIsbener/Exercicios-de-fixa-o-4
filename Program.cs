using System;

namespace Exercicios_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int[] numeros = new int[10];
            int menor = 0, maior = 0;

            Console.WriteLine( "Informe 10 números inteiros:" );

            for( int i = 0; i < 10; i++ )
            {

                Console.WriteLine( ( i + 1 ) + "º número:" );
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if( i == 0 )
                {
                    menor = numeros[0];
                    maior = numeros[0];
                }

                if( numeros[i] < menor )
                {

                    menor = numeros[i];

                }
                else if( numeros[i] > maior )
                {
                    maior = numeros[i];
                }

            }

            Console.WriteLine( "O menor número é:" + menor );
            Console.WriteLine( "O maior número é:" + maior );
        }
    }
}
