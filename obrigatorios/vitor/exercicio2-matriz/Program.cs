// Calcule	a	distância	entre	dois	pontos	num espaço	de	3	dimensões 
class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
        };

        int linha1 = -1;
        int linha2 = -1;

        int coluna1 = -1;
        int coluna2 = -1;

        Console.WriteLine("Digite o valor do primeiro ponto: ");

        if (!int.TryParse(Console.ReadLine(), out int primeiroNumero))
        {
            Console.WriteLine("Valor inválido. Insira um valor numérico: ");
        }

        Console.WriteLine("Digite o valor do segundo ponto: ");

        if (!int.TryParse(Console.ReadLine(), out int segundoNumero))
        {
            Console.WriteLine("Valor inválido. Insira um valor numérico: ");
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == primeiroNumero)
                {
                    linha1 = i;
                    coluna1 = j;
                }

                if (matriz[i, j] == segundoNumero)
                {
                    linha2 = i;
                    coluna2 = j;
                }
            }
        }

        if (linha1 == -1)
        {
            Console.WriteLine($"O primeiro número não foi encontrado.");
        }
        else if (linha2 == -1)
        {
            Console.WriteLine("O segundo número não foi encontrado.");
        }


        double dist = (linha1 - linha2) - (linha2 - linha1);

        if (dist < 0)
        {
            dist = dist * -1;
        }

        Console.WriteLine($"A distância entre os números é: {dist}");
    }
}