using System;

namespace _1046_TempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int inicioHora = int.Parse(vet[0]);
            int fimHora = int.Parse(vet[1]);
            int duracao = (24 - inicioHora) + fimHora;
            if (inicioHora >= fimHora)
            {
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }

            else if ((inicioHora == 0) && (fimHora == 0))
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + (fimHora - inicioHora) + " HORA(S)");
            }
        }
    }
}
