using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_vetores_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int [N];
            int[] B = new int [N];
            int[] C = new int [N];
            int soma;

            string[] s = Console.ReadLine().Split(' ');
            string[] s1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(s[i]);
                B[i] = int.Parse(s1[i]);
                soma = A[i] + B[i];
                C[i] = soma;
                Console.Write(C[i] + " ");
            }
            Console.WriteLine();


        }
    }
}
