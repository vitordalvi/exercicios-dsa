using System;

// Extrato
class Extrato
{
    public DateTime Data;
    public double Valor;

    public Extrato(DateTime data, double valor)
    {
        Data = data;
        Valor = valor;
    }
}

// Cartão
class Cartao
{
    public string Numero;
    public string Validade;

    public Cartao(string numero, string validade)
    {
        Numero = numero;
        Validade = validade;
    }
}

// Conta
class Conta
{
    private string nomeCliente;
    private int numeroConta;
    private double saldo;

    private Extrato[] extratos = new Extrato[1000];
    private int indiceExtrato = 0;

    public Cartao Cartao;

    public Conta(string nome, int numero, double saldoInicial, Cartao cartao)
    {
        nomeCliente = nome;
        numeroConta = numero;
        saldo = saldoInicial;
        Cartao = cartao;
    }

    public void Depositar(double valor)
    {
        saldo += valor;
        extratos[indiceExtrato] = new Extrato(DateTime.Now, valor);
        indiceExtrato++;
    }

    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            extratos[indiceExtrato] = new Extrato(DateTime.Now, -valor);
            indiceExtrato++;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public double ObterSaldo()
    {
        return saldo;
    }

    public int ObterNumero()
    {
        return numeroConta;
    }

    public string ObterNomeCliente()
    {
        return nomeCliente;
    }

    public void MostrarExtrato()
    {
        Console.WriteLine("Extrato:");
        for (int i = 0; i < indiceExtrato; i++)
        {
            Console.WriteLine($"{extratos[i].Data} | {extratos[i].Valor}");
        }
    }
}

// Rodar
class Program
{
    static void Main()
    {
        Conta c1 = new Conta("Ana", 1, 1000, new Cartao("1111", "12/26"));
        Conta c2 = new Conta("Bruno", 2, 500, new Cartao("2222", "11/25"));
        Conta c3 = new Conta("Carlos", 3, 200, new Cartao("3333", "10/24"));

        c1.Depositar(200);
        c1.Sacar(100);

        c2.Sacar(50);
        c2.Depositar(300);

        c3.Depositar(100);
        c3.Sacar(50);

        Conta[] contas = { c1, c2, c3 };

        Console.WriteLine("SAQUE COM CARTÃO");
        Console.Write("Digite o número do cartão: ");
        string numero = Console.ReadLine();

        Console.Write("Digite a validade do cartão: ");
        string validade = Console.ReadLine();

        foreach (Conta c in contas)
        {
            if (c.Cartao.Numero == numero && c.Cartao.Validade == validade)
            {
                Console.Write("Digite o valor do saque: ");
                double valor = double.Parse(Console.ReadLine());
                c.Sacar(valor);
            }
        }

        Console.WriteLine("\nRelatório final");
        foreach (Conta c in contas)
        {
            Console.WriteLine($"Conta: {c.ObterNumero()}");
            Console.WriteLine($"Titular: {c.ObterNomeCliente()}");
            Console.WriteLine($"Saldo: {c.ObterSaldo()}");
            c.MostrarExtrato();
            Console.WriteLine("");
        }
    }
}