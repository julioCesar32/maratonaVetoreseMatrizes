using System;
using System.Globalization;

namespace alturas
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercio 2 - Alturas");
            Console.WriteLine("");

            int N, i, cont;
            Console.WriteLine("Quantas pessoas serao digitadas? ");
            N = int.Parse(Console.ReadLine());

            double soma, media, porcentagem;
            string[] nome = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Dados da "+ (i + 1) + "ª pessoa:");
                Console.WriteLine("Nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine());
            }



            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma += alturas[i];
            }

            media = soma / N;
            Console.WriteLine();
            Console.WriteLine("Altura media: " + media.ToString("F"));

            cont = 0;
            for(i = 0; i < N; i++)
            {
                if(idades[i] < 16)
                {
                    cont += 1;
                }
            }


            porcentagem = cont * 100 / N;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F") + "%");


           for(i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}