using System;

namespace _1020_IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, resto, diasConvertidos;
            dias = int.Parse(Console.ReadLine());

            diasConvertidos = dias / 365;
            Console.WriteLine(diasConvertidos + " ano(s)");

            resto = dias % 365;
            diasConvertidos = resto / 30;
            Console.WriteLine(diasConvertidos + " mes(es)");

            diasConvertidos = resto % 30;
            Console.WriteLine(diasConvertidos + " dia(s)");
        }
    }
}
