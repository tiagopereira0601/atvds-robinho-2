using System;

class Aluno
{
    public string RA { get; set; }
    public string Nome { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double NotaFinal { get; private set; }

    public void ReceberDados()
    {
        Console.Write("Digite o RA do aluno: ");
        RA = Console.ReadLine();

        Console.Write("Digite o nome do aluno: ");
        Nome = Console.ReadLine();

        Console.Write("Digite a nota da prova: ");
        NotaProva = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota do trabalho: ");
        NotaTrabalho = double.Parse(Console.ReadLine());
    }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool CalcularNotaFinal()
    {
        double mediaParaAprovacao = 6.0;

        if (NotaFinal >= mediaParaAprovacao)
        {
            Console.WriteLine("Aluno aprovado!");
            return true;
        }
        else
        {
            double notaNecessaria = (12 - NotaFinal);
            Console.WriteLine($"Aluno precisa de {notaNecessaria:F2} na prova final.");
            return false;
        }
    }

    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota Final do aluno {Nome} (RA: {RA}): {NotaFinal:F2}");
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.ReceberDados();
        aluno.CalcularMedia();
        aluno.ImprimirNotaFinal();
        aluno.CalcularNotaFinal();
    }
}