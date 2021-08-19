using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_vetores_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];
            double maior= 0;
            int posi = 0;

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i<N;i++){
                vet[i] = double.Parse(s[i]);
                if (vet[i] >= maior)
                {
                    maior = vet[i];  
                }
             if (vet[i] >= maior)
                {
                    posi = posi + 1;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posi);
        }
    }
}
