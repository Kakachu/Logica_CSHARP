using System;

namespace _1015_DistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = int.Parse(Console.ReadLine());
            double kmh = int.Parse(Console.ReadLine());
            double gaso = (h * kmh) / 12;
            Console.WriteLine(gaso.ToString("F3"));
        }
    }
}
