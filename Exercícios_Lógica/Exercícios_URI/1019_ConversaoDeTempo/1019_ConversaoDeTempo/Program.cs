using System;

namespace _1019_ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int horas, minutos, segundos, resto;
            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
