using System;

namespace _1134_TiposDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int tipoCombustivel = int.Parse(Console.ReadLine());
            while (tipoCombustivel != 4)
            {
                switch (tipoCombustivel)
                {
                    case 1:
                        alcool++;
                        break;

                    case 2:
                        gasolina++;
                        break;

                    case 3:
                        diesel++;
                        break;
                }
                tipoCombustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
