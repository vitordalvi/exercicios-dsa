class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Insira um número: ");

        if (!long.TryParse(Console.ReadLine(), out long num))
        {
            Console.Write("Valor inválido. Digite um valor numérico: ");
        }

        Console.WriteLine($"A quantidade de dígitos do número é: {Convert.ToString(num).Length}");
    }
}