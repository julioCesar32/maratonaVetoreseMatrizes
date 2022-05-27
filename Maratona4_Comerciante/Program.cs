using System;
using System.Globalization;

namespace Comerciante
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercio 4 - Comerciante");
            Console.WriteLine("");

            int N, i, abaixo, entre, acima;

            Console.WriteLine("Serao digitados dados de quantos produtos? ");
            N = int.Parse(Console.ReadLine());

            double totalCompra, totalVenda, totalLucro, lucro, PercentualLucro;
            string[] nomes = new string[N];
            double[] precosCompra = new double[N];
            double[] precosVenda = new double[N];


            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Produto " + (i + 1));
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                precosCompra[i] = double.Parse(Console.ReadLine());
                Console.Write("Preco de venda: ");
                precosVenda[i] = double.Parse(Console.ReadLine());
            }



            abaixo = 0;
            entre = 0;
            acima = 0;
            for (i = 0; i < N; i++)
            {
                lucro = precosVenda[i] - precosCompra[i];
                PercentualLucro = lucro * 100.0 / precosCompra[i];

                if (PercentualLucro < 10)
                {
                    abaixo += 1;


                    if (PercentualLucro <= 20)
                    {
                        entre += 1;
                    }
                    else
                    {
                        acima += 1;
                    }
                }

                totalCompra = 0;
                totalVenda = 0;
                for (i = 0; i < N; i++)
                {
                    totalCompra = totalCompra + precosCompra[i];
                    totalVenda = totalVenda + precosVenda[i];
                }


                totalLucro = totalVenda - totalCompra;


                Console.WriteLine();
                Console.WriteLine("RELATORIO:");
                Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
                Console.WriteLine("Lucro entre 10% e 20%: " + entre);
                Console.WriteLine("Lucro acima de 20%: " + acima);
                Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F"));
                Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F"));
                Console.WriteLine("Lucro total: " + totalLucro.ToString("F"));

        }
        }
    }
}