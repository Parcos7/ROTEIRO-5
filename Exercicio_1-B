using System;

class Program
{
    static void Main()
    {
        Console.Write("Capital inicial: ");
        double capital = double.Parse(Console.ReadLine());

        Console.Write("Taxa de juros mensal (em %): ");
        double taxa = double.Parse(Console.ReadLine()) / 100;

        Console.Write("Número de meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Meta de lucro: ");
        double metaLucro = double.Parse(Console.ReadLine());

        double montanteFinal = capital * Math.Pow(1 + taxa, meses);
        double lucro = montanteFinal - capital;
        double lucroArredondado = Math.Round(lucro, 2);

        Console.WriteLine($"\nMontante final: {montanteFinal:C2}");
        Console.WriteLine($"Lucro: {lucroArredondado:C2}");

        if (lucroArredondado >= metaLucro)
        {
            Console.WriteLine("O lucro superou a meta!");
        }
        else
        {
            Console.WriteLine("O lucro não superou a meta.");
        }

        Console.ReadKey();
    }
}
