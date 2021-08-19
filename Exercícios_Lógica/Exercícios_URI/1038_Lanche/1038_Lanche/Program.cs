using System;

namespace _1038_Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigoItem = int.Parse(vet[0]);
            int qnt = int.Parse(vet[1]);
            double preco;
            switch (codigoItem)
            {
                case 1:
                    preco = 4.00 * qnt;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2"));
                    break;

                case 2:
                    preco = 4.50 * qnt;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2"));
                    break;

                case 3:
                    preco = 5.00 * qnt;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2"));
                    break;

                case 4:
                    preco = 2.00 * qnt;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2"));
                    break;

                case 5:
                    preco = 1.50 * qnt;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2"));
                    break;
            }
        }
    }
}
