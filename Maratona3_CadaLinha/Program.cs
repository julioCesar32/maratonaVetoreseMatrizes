using System;
using System.Globalization;

namespace CadaLinha
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercio 3 - Cada Linha");
            Console.WriteLine("");

            int N, i, j, maior;
            Console.WriteLine("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];


            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA:");
            for (i = 0; i < N; i++)
            {
                maior = mat[i, 0];
                for (j = 1; j < N; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}