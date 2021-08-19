using System;

namespace _1002_AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, raio, area;
            n = 3.14159;
            raio = double.Parse(Console.ReadLine());
            area = n * (raio * raio);
            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}
