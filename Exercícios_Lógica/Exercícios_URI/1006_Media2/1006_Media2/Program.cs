using System;

namespace _1006_Media2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine()) * 2;
            double B = double.Parse(Console.ReadLine()) * 3;
            double C = double.Parse(Console.ReadLine()) * 5;
            double MEDIA = (A + B + C) / 10;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
        }
    }
}
