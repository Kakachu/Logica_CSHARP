using System;

namespace _1036_FormulaDeBaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double raiz1, raiz2, delta;
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);
            delta = Math.Pow(b, 2.0) - 4 * a * c;
            if (delta < 0.00 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                raiz1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                raiz2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + raiz1.ToString("F5"));
                Console.WriteLine("R2 = " + raiz2.ToString("F5"));
            }

        }
    }
}
