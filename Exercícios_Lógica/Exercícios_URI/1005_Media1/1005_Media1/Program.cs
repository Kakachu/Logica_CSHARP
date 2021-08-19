using System;

namespace _1005_Media1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine()) * 3.5;
            double B = double.Parse(Console.ReadLine()) * 7.5;
            double MEDIA = (A + B) / 11;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
        }
    }
}
