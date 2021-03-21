using System;

namespace Aula_de_PC1_MilhasKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhas;
            double km = 1.609;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("!Conversão de Milhas em Quilômetros!");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.ResetColor();

            Console.WriteLine("\n Agora, digite um valor em milhas para ser convertido:");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            milhas = double.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Tecle enter para abrir os resultados.");
            Console.ReadLine();
            Console.Clear();
            Console.Write($"Você converteu {milhas} milhas em {milhas * km} KM! ");
            Console.WriteLine("\n Tecle qualquer botão para sair");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
