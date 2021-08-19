 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_vetores_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            double media = 0;
            int soma = 0;

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
                soma = soma + vet[i];
                if (vet[i] % 2 == 0)
                {
                    media = soma / N;
                }
            }
            Console.WriteLine(media.ToString("F1"));
        }
    }
}
