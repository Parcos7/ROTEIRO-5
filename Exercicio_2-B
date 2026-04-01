using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o CPF (pode usar pontos e traços): ");
        string cpfBruto = Console.ReadLine();

        string cpfLimpo = cpfBruto.Trim()
                                  .Replace(".", "")
                                  .Replace("-", "")
                                  .Replace(" ", "");

        if (cpfLimpo.Length == 11)
        {
            bool começaComZero = cpfLimpo.StartsWith("0");
            Console.WriteLine($"Começa com zero? {começaComZero}");

            string parte1 = cpfLimpo.Substring(0, 3);
            string parte2 = cpfLimpo.Substring(3, 3);
            string parte3 = cpfLimpo.Substring(6, 3);
            string parte4 = cpfLimpo.Substring(9, 2);

            string cpfFormatado = $"{parte1}.{parte2}.{parte3}-{parte4}";

            Console.WriteLine("\nCPF Processado:");
            Console.WriteLine($"Apenas números: {cpfLimpo}");
            Console.WriteLine($"Formatado:      {cpfFormatado}");
        }
        else
        {
            Console.WriteLine($"\nErro: O CPF deve conter exatamente 11 dígitos numéricos. (Digitados: {cpfLimpo.Length})");
        }

        Console.ReadKey();
    }
}
