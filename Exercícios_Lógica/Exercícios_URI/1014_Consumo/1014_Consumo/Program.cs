using System;

namespace _1014_Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
                int X = int.Parse(Console.ReadLine());
                double Y = double.Parse(Console.ReadLine());
                double kml;
                kml = X / Y;
                Console.WriteLine(kml.ToString("F3") + " km/l");
            }
        }
    }
