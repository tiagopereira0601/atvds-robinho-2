using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    private int Quantidade;

    public Produto(string nome, double preco, int quantidadeInicial = 0)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidadeInicial;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Quantidade += quantidade;
            Console.WriteLine($"{quantidade} unidades adicionadas ao estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade deve ser positiva.");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= Quantidade)
        {
            Quantidade -= quantidade;
            Console.WriteLine($"{quantidade} unidades removidas do estoque.");
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente ou inválida para remoção.");
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}\nPreço: R${Preco:F2}\nQuantidade em estoque: {Quantidade}");
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Celular", 3500.00, 10);

        produto.ExibirDetalhes();
        produto.AdicionarEstoque(5);
        produto.ExibirDetalhes();
        produto.RemoverEstoque(3);
        produto.ExibirDetalhes();
        produto.RemoverEstoque(20);
    }
}

