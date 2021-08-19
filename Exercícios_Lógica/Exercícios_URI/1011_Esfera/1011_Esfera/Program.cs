using System;

namespace _1011_Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double volume = (double)4.0 / 3 * pi * (Math.Pow(raio, 3.0));
            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
        }
    }
}
