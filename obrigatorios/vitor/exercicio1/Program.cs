// Determine as raízes de uma equação de 2° grau: ax² + bx + c = 0
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o valor de A: ");
        string a = Console.ReadLine();
        double anum = parseFuncao(a);

        Console.Write("Digite o valor de B: ");
        string b = Console.ReadLine();
        double bnum = parseFuncao(b);

        Console.Write("Digite o valor de C: ");
        string c = Console.ReadLine();
        double cnum = parseFuncao(c);

        calculoFuncao(anum, bnum, cnum);
    }

    static double parseFuncao(string x)
    {
        double num;

        // Se a pessoa enviar um "X" ou "x", automaticamente vira 1 ou -1
        if (x.ToLower() == "x")
        {
            num = 1;

        }
        else if (x.ToLower() == "-x")
        {
            num = -1;

            // Validação do tipo inserido na string
        }
        else if (double.TryParse(x, out num))
        {
        }
        // Caso o tipo esteja incorreto, por exemplo, booleano, é enviado uma mensagem de erro
        else
        {
            Console.WriteLine("Valor inválido");
        }

        // Retorna o valor em double 
        return num;
    }

    static void calculoFuncao(double a, double b, double c)
    {

        // Formula do delta
        double delta = Math.Pow(b, 2) - 4 * (a * c);


        // Se delta for 0 ou negativo, não tem raiz
        if (delta <= 0)
        {
            Console.WriteLine($"O valor de delta é: {delta}");
        }
        // Se tiver raiz, cai para bhaskara
        else
        {
            double n1 = ((b * -1) + Math.Sqrt(delta)) / 2 * a;
            double n2 = ((b * -1) - Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine($"{a}, {b}, {c}, {Math.Sqrt(delta)}");
            Console.WriteLine($"Valor de delta: {delta}, raízes: \n{n1}\n{n2}");
        }

    }
}