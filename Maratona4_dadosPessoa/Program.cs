using System;
using System.Globalization;

namespace dados_Pesoa;

class program
{
    static void Main(string[] args)
    {




        int N, i, contMulheres, contHomens;
        double menorAltura, maiorAltura, soma, media;

        Console.WriteLine("Quantas pessoas serao digitadas? ");
        N = int.Parse(Console.ReadLine());
        char[] generos = new char[N];
        double[] alturas = new double[N];


        for(i = 0; i <  N ; i++)
        {
            Console.Write("Altura da " + (i + 1) + "ª pessoa: ");
            alturas[i] = double.Parse(Console.ReadLine());
            Console.Write("Genero da "+ (i + 1)+ "ª pessoa: ");
            generos[i] = char.Parse(Console.ReadLine());
        }


        menorAltura = alturas[0];
        maiorAltura = alturas[0];

        for(i = 0; i < N ; i++)
        {
            if (alturas[i] > maiorAltura)
            {
                maiorAltura = alturas[i];
            }

            if (alturas[i] < menorAltura)
            {
                menorAltura = alturas[i];
            }
        }
            
        Console.WriteLine("Menor altura = " + menorAltura.ToString("F"));
        Console.WriteLine("Maior altura = " + maiorAltura.ToString("F"));


        soma = 0;
        contMulheres = 0;
        for(i = 0; i < N ; i++)
        {
            if(generos[i] == 'F')
            {
                soma += alturas[i];
                contMulheres += 1;
            }
        
        }
        if(contMulheres == 0)
        {
            Console.WriteLine("Impossivel calcular a altura media das mulheres");
        }

        media = soma / contMulheres;
        Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F"));

        contHomens = N - contMulheres;
        Console.WriteLine("Numero de homens = "+ contHomens);
    }
}


