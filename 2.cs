using System;

class ContaBancaria
{
    public string NumeroConta { get; set; }
    public string Titular { get; set; }
    private double Saldo;

    public ContaBancaria(string numeroConta, string titular, double saldoInicial = 0)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser positivo.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual da conta ({NumeroConta}) de {Titular}: R${Saldo:F2}");
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("45294-6", "RAISSA MARQUES", 1000.00);

        conta.ExibirSaldo();
        conta.Depositar(500);
        conta.ExibirSaldo();
        conta.Sacar(300);
        conta.ExibirSaldo();
        conta.Sacar(1500);
    }
}

