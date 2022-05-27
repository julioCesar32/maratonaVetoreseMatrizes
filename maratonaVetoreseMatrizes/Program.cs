using System;
using System.Globalization;

namespace acima_diagonal
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercio 1 - Acima diagonal");
            Console.WriteLine("");

            int N, i, j, soma;

            Console.WriteLine("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

          

            for ( i = 0; i < N; i++)
            {
                for ( j = 0; j < N; j++)
                {
                    Console.WriteLine("Elemento ["+ i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            soma = 0;
            for ( i = 0; i < N; i++)
            {
                for ( j = i + 1; j < N; j++) 
                {
                    soma = soma + mat[i, j];
                }
                 
            }

            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);

            Console.ReadLine();
        }
    }
}

