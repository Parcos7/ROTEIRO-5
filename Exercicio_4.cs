using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a data e hora do compromisso (dd/MM/yyyy HH:mm): ");
        DateTime dataCompromisso = DateTime.Parse(Console.ReadLine());

        DateTime agora = DateTime.Now;
        TimeSpan diferenca = dataCompromisso - agora;
        
        int diasRestantes = (int)Math.Ceiling(diferenca.TotalDays);
        string diaSemanaPT = dataCompromisso.ToString("dddd", new System.Globalization.CultureInfo("pt-BR"));

        string mensagem = string.Format(
            "Olá, {0}!\n" +
            "Seu compromisso será em {1} dias, na {2}.\n" +
            "Data marcada: {3:dd/MM/yyyy} às {3:HH:mm}",
            nome,
            diasRestantes,
            diaSemanaPT,
            dataCompromisso
        );

        Console.WriteLine("\n" + mensagem);
        
        Console.ReadKey();
    }
}
