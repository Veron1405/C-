using System;

class Program
{
    static void Main()
    {
        CalcularSalarioDiario();
        CalcularBombonsComprados();
        CalcularTotalBombons();
        CalcularCaixasUsadas();
        CalcularPrecoFinalComDesconto();
    }

    static void CalcularSalarioDiario()
    {
        decimal salarioPorHora = 35.00m;
        int horasPorDia = 8;

        decimal salarioDiario = salarioPorHora * horasPorDia;

        Console.WriteLine("Joaquim deve receber R$ " + salarioDiario.ToString("F2") + " ao final do dia.");
    }

    static void CalcularBombonsComprados()
    {
        int unidadesCompradas = 16;
        Console.WriteLine("Pamela comprou " + unidadesCompradas + " bombons.");
    }

    static void CalcularTotalBombons()
    {
        int caixasCompradas = 16;
        int bombonsPorCaixa = 27;

        int totalBombons = caixasCompradas * bombonsPorCaixa;

        Console.WriteLine("Pamela agora tem " + totalBombons + " bombons.");
    }

    static void CalcularCaixasUsadas()
    {
        int totalGarrafas = 300;
        int garrafasPorCaixa = 20;

        int caixasUsadas = totalGarrafas / garrafasPorCaixa;

        Console.WriteLine("A loja usou " + caixasUsadas + " caixas para acomodar todas as garrafas.");
    }

    static void CalcularPrecoFinalComDesconto()
    {
        decimal precoInstalacao = 300.00m;
        decimal precoLimpeza = 150.00m;
        decimal precoManutencao = 499.99m;

        decimal descontoPromocao = 50.00m;

        Console.Write("Digite a quantidade de serviços de instalação: ");
        int quantidadeInstalacao = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de serviços de limpeza: ");
        int quantidadeLimpeza = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de serviços de manutenção: ");
        int quantidadeManutencao = int.Parse(Console.ReadLine());

        decimal totalSemDesconto = (quantidadeInstalacao * precoInstalacao) +
                                   (quantidadeLimpeza * precoLimpeza) +
                                   (quantidadeManutencao * precoManutencao);

        decimal totalComDesconto = totalSemDesconto - descontoPromocao;

        Console.WriteLine("O cliente deve pagar: R$ " + totalComDesconto.ToString("F2"));
    }
}
