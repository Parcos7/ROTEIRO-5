using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, digite 5 números decimais.");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine($"\n--- Resultados para: {numero} ---");
            Console.WriteLine($"Original:          {numero}");
            Console.WriteLine($"Math.Round:        {Math.Round(numero)}");
            Console.WriteLine($"Math.Floor:        {Math.Floor(numero)}");
            Console.WriteLine($"Math.Ceiling:      {Math.Ceiling(numero)}");
            Console.WriteLine($"Math.Truncate:     {Math.Truncate(numero)}");
            Console.WriteLine("---------------------------------\n");
        }

        Console.ReadKey();
    }
}
