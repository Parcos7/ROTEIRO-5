using System;

class Program
{
    static void Main()
    {
        string p1Nome = "Monitor"; double p1Preco = 1200.50; int p1Qtd = 2;
        string p2Nome = "Teclado"; double p2Preco = 150.00;  int p2Qtd = 5;
        string p3Nome = "Mouse";   double p3Preco = 89.99;   int p3Qtd = 3;

        double total1 = p1Preco * p1Qtd;
        double total2 = p2Preco * p2Qtd;
        double total3 = p3Preco * p3Qtd;

        double subtotal = total1 + total2 + total3;
        double taxaDesconto = 0.10; // 10%
        double valorDesconto = subtotal * taxaDesconto;
        double totalFinal = subtotal - valorDesconto;

        Console.WriteLine("{0,-15} {1,10} {2,10} {3,15}", "Produto", "Preço", "Qtd", "Total Item");
        Console.WriteLine(new string('-', 55));

        Console.WriteLine("{0,-15} {1,10:C2} {2,10:N0} {3,15:C2}", p1Nome, p1Preco, p1Qtd, total1);
        Console.WriteLine("{0,-15} {1,10:C2} {2,10:N0} {3,15:C2}", p2Nome, p2Preco, p2Qtd, total2);
        Console.WriteLine("{0,-15} {1,10:C2} {2,10:N0} {3,15:C2}", p3Nome, p3Preco, p3Qtd, total3);

        Console.WriteLine(new string('-', 55));

        Console.WriteLine($"SUBTOTAL:           {subtotal,34:F2}");
        Console.WriteLine($"DESCONTO ({taxaDesconto:P0}):    {valorDesconto,34:F2}");
        Console.WriteLine(new string('=', 55));
        Console.WriteLine($"TOTAL FINAL:        {totalFinal,34:C2}");

        Console.ReadKey();
    }
}
