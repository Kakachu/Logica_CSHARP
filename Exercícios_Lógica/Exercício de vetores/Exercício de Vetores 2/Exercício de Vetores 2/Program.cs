using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Vetores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int N = int.Parse(Console.ReadLine());
                double[] vet = new double[N];
                double[] pares = new double[N];
            int soma = 0;

            string[] s = Console.ReadLine().Split(' ');

                for (int i = 0; i < N; i++)
                {
                    vet[i] = double.Parse(s[i]);
                if (vet[i] % 2 == 0)
                {
                    pares[i] = vet[i];
                    soma++;
                    } 
                }
                for(int i = 0; i < N; i++)
            {
                Console.Write(pares[i] + " ");

                
            }
            Console.ReadLine();
            Console.WriteLine(soma);
        }
    }
}
    

