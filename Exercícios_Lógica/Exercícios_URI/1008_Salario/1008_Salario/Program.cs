using System;

namespace _1008_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numf = int.Parse(Console.ReadLine());
            int numh = int.Parse(Console.ReadLine());
            double salarioh = double.Parse(Console.ReadLine());
            double salariof;
            salariof = numh * salarioh;
            Console.WriteLine("NUMBER = " + numf);
            Console.WriteLine("SALARY = U$ " + salariof.ToString("F2"));
        }
    }
}
