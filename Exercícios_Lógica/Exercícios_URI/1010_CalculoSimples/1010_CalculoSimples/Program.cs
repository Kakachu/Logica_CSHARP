using System;

namespace _1010_CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, qnt1, cod2, qnt2;
            double vlr1, vlr2, total;

            String[] vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            qnt1 = int.Parse(vet[1]);
            vlr1 = double.Parse(vet[2]);

            String[] vet2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet2[0]);
            qnt2 = int.Parse(vet2[1]);
            vlr2 = double.Parse(vet2[2]);
            total = vlr1 * qnt1 + vlr2 * qnt2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
