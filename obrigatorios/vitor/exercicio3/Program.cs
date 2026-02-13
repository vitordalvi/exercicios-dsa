//O    programa a	seguir estranhamente	sempre	escreve	“A	distancia	e:	1.0”.	Identifique onde	
//está	o	defeito.
//import java.util.Scanner;
//public class Distancia
//{
//    public static void main(String[] args)
//    {
//        Scanner teclado = new Scanner(System.in);
//        double x1, y1, x2, y2, distancia;

//        System.out.println("Entre com as coordenadas x e y dos pontos nesta ordem:");
//        x1 = teclado.nextFloat();
//        y1 = teclado.nextFloat();
//        x2 = teclado.nextFloat();
//        y2 = teclado.nextFloat();

//        distancia = Math.pow(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2), 1 / 2);
//        System.out.println("A distância é: " + distancia);
//    }
//}


class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite as coordenadas do ponto (x1): ");

        if (!double.TryParse(Console.ReadLine(), out double x1))
        {
            Console.Write($"O valor {x1} é inválido. Insira um valor numérico: ");
        }

        Console.Write("Insira as coordenadas do segundo ponto (x2): ");

        if (!double.TryParse(Console.ReadLine(), out double x2))
        {
            Console.Write($"O valor {x2} é inválido. Insira um valor numérico: ");
        }

        Console.Write("Insira as coordenadas do segundo ponto (y1): ");

        if (!double.TryParse(Console.ReadLine(), out double y1))
        {
            Console.Write($"O valor {y1} é inválido. Insira um valor numérico: ");
        }

        Console.Write("Insira as coordenadas do segundo ponto (y2): ");

        if (!double.TryParse(Console.ReadLine(), out double y2))
        {
            Console.Write($"O valor {y2} é inválido. Insira um valor numérico: ");
        }

        // A fórmula no programa da lista está errada, porque 1/2 não é 0 em c#/java, então a alternativa pode ser usar o Math.Sqrt() ou elevar por 0.5
        double dist = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2), 0.5);

        Console.WriteLine($"A distância é: {dist:F2}");
    }
}