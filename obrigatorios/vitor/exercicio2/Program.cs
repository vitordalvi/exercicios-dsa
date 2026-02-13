// Calcule	a	distância	entre	dois	pontos	num espaço	de	3	dimensões 
// fórmula 3d -> d = sqrt((x2 - x1)² + (y2 - y1)² + (z2 - z1)²)²)
// fórmula 2d -> d = sqrt((x2 -x1)² + (y2 - y1)²)²)

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Insira as coordenadas do primeiro ponto (x1): ");

        // Validação do dado de entrada -> Se não for um tipo double, envia um erro e pede nova entrada de dados
        if (!double.TryParse(Console.ReadLine(), out double x1))
        {
            Console.Write($"O valor {x1} é inválido. Insira um valor numérico: ");
        }

        Console.Write("Insira as coordenadas do segundo ponto (x2): ");

        // Validação do dado de entrada -> Se não for um tipo double, envia um erro e pede nova entrada de dados
        if (!double.TryParse(Console.ReadLine(), out double x2))
        {
            Console.Write($"O valor {x2} é inválido. Insira um valor numérico: ");
        }

        Console.Write("Insira as coordenadas do primeiro ponto (y1): ");

        if (!double.TryParse(Console.ReadLine(), out double y1))
        {
            Console.Write($"O valor {y1} é inválido. Insira um valor numérico: ");
        }

        Console.Write("Insira as coordenadas do segundo ponto (y2): ");

        // Validação do dado de entrada -> Se não for um tipo double, envia um erro e pede nova entrada de dados
        if (!double.TryParse(Console.ReadLine(), out double y2))
        {
            Console.Write($"O valor {y2} é inválido. Insira um valor numérico: ");
        }


        Console.Write("Insira as coordenadas do primeiro ponto (z1): ");

        // Validação do dado de entrada -> Se não for um tipo double, envia um erro e pede nova entrada de dados
        if (!double.TryParse(Console.ReadLine(), out double z1))
        {
            Console.Write($"O valor {z1} é inválido. Insira um valor numérico: ");
        }

        Console.Write("Insira as coordenadas do segundo ponto (x2): ");

        // Validação do dado de entrada -> Se não for um tipo double, envia um erro e pede nova entrada de dados
        if (!double.TryParse(Console.ReadLine(), out double z2))
        {
            Console.Write($"O valor {z2} é inválido. Insira um valor numérico: ");
        }

        // Calculo usando a fórmula da distância três dimensões
        double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        // Resultado da fórmula da distância com formatação de dois números decimais
        Console.WriteLine($"O valor da distância é: {dist:F2}");
    }
}