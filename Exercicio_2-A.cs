using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase (com espaços no início/fim e palavras separadas por vírgulas):");
        string entrada = Console.ReadLine();

        string fraseLimpa = entrada.Trim();
        Console.WriteLine($"\nFrase com Trim: '{fraseLimpa}'");

        string[] palavras = fraseLimpa.Split(',');
        Console.WriteLine("Palavras extraídas pelo Split:");
        foreach (string p in palavras)
        {
            Console.WriteLine($"- {p.Trim()}");
        }

        Console.Write("\nDigite uma palavra da frase que deseja substituir: ");
        string busca = Console.ReadLine();
        Console.Write("Digite a nova palavra: ");
        string substituta = Console.ReadLine();
        
        string fraseNova = fraseLimpa.Replace(busca, substituta);
        Console.WriteLine($"Frase após Replace: {fraseNova}");

        Console.Write("\nVerificar se a frase começa com qual palavra? ");
        string inicio = Console.ReadLine();
        bool comecaCom = fraseLimpa.StartsWith(inicio);
        Console.WriteLine($"Começa com '{inicio}'? {comecaCom}");

        Console.Write("Verificar se a frase termina com qual palavra? ");
        string fim = Console.ReadLine();
        bool terminaCom = fraseLimpa.EndsWith(fim);
        Console.WriteLine($"Termina com '{fim}'? {terminaCom}");

        Console.ReadKey();
    }
}
