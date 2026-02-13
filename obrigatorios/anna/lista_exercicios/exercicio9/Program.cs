class Lampada
{
    public int Potencia;
    public int Voltagem;
    public bool Ligada;
    public bool Queimada;

    public Lampada(int potencia, int voltagem)
    {
        Potencia = potencia;
        Voltagem = voltagem;
        Ligada = false;
        Queimada = false;
    }

    public void Ligar()
    {
        if (Queimada)
        {
            Console.WriteLine("A lâmpada está queimada e não pode ser ligada.");
            return;
        }

        Random random = new Random();
        int chance = random.Next(1, 101); // 1 até 100

        if (chance <= 15)
        {
            Queimada = true;
            Ligada = false;
            Console.WriteLine("A lâmpada queimou ao ser ligada!");
        }
        else
        {
            Ligada = true;
            Console.WriteLine("A lâmpada foi ligada.");
        }
    }

    public void Desligar()
    {
        if (!Queimada)
        {
            Ligada = false;
            Console.WriteLine("A lâmpada foi desligada.");
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Estado da lâmpada:");
        Console.WriteLine(Ligada ? "Ligada" : "Desligada");
        Console.WriteLine(Queimada ? "Queimada" : "Funcionando");
        Console.WriteLine($"Potência: {Potencia}W");
        Console.WriteLine($"Voltagem: {Voltagem}V");
        Console.WriteLine("---------------------");
    }
}

class Teste
{
    static void Main()
    {
        Lampada lampada = new Lampada(60, 220);

        lampada.MostrarEstado();

        lampada.Ligar();

        lampada.MostrarEstado();
    }
}