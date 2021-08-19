using System;

namespace _1009_SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, vendas, salarioTotal;
            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());
            salarioTotal = vendas * 15 / 100 + salarioFixo;
            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2"));
        }
    }
}
