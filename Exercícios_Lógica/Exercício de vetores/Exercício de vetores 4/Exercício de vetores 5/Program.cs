using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_vetores_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];
            double[] abaixo = new double[N];

            double media = 0;
            double soma = 0;

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i]);
                soma = soma + vet[i];
                if (vet[i] % 2 == 0)
                {
                    media = soma / N;
                }
            }


            Console.WriteLine(media.ToString("F3"));

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i]);
                }
            }
            
        }

    }
}

