using System;

class Program
{
    static void Main(string[] args)
    {
        // Ponto A
        Console.WriteLine("Digite as coordenadas do ponto A:");

        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("z1: ");
        double z1 = double.Parse(Console.ReadLine());

        // Ponto B
        Console.WriteLine("\nDigite as coordenadas do ponto B:");

        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("z2: ");
        double z2 = double.Parse(Console.ReadLine());

        // Fórmula da distância 3D
        double distancia = Math.Sqrt(
            Math.Pow(x2 - x1, 2) +
            Math.Pow(y2 - y1, 2) +
            Math.Pow(z2 - z1, 2)
        );

        Console.WriteLine($"\nDistância entre os pontos: {distancia:F2}");
    }
}