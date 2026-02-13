// Considere	 os	 programas	 a	 seguir,	 que	 leem um	 código	 repetidamente	 e	 imprimem o	
//código lido	até	que	o	código	lido	seja	igual	a	-1.	O	código	-1	não	deve	ser	impresso.	
// Qual	das	duas	soluções	é	a	correta?	
// Como	a	solução	incorreta	poderia	ser	corrigida?
//Programa A
//import java.util.Scanner;
//public class Codigo
//{
//    public static void main(String[] args)
//    {
//        Scanner teclado = new Scanner(System.in);
//        int codigo;

//        System.out.println("Informe o código: ");
//        codigo = teclado.nextInt();
//        while (codigo != -1)
//        {
//            System.out.println("Código: " + codigo);
//            System.out.println("Informe o código: ");
//            codigo = teclado.nextInt();
//        }
//    }
//}
//Programa B
//import java.util.Scanner;
//public class Codigo
//{
//    public static void main(String[] args)
//    {
//        Scanner teclado = new Scanner(System.in);
//        int codigo;

//        do
//        {
//            System.out.print("Informe o código: ");
//            codigo = teclado.nextInt();
//            System.out.println("Código: " + codigo);
//        } while (codigo != -1);
//    }
//}

// Acho que o 1 deve dar um loop infinito, então suponho que o 2 deve ser o correto
// Fiz da forma abaixo mas não sei se é o pedido do exercício
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o código: ");
        string cod = Console.ReadLine();

        while (cod != "-1")
        {
            Console.Write("Tente novamente: ");
            string tentativa = Console.ReadLine();

            if (tentativa == "-1")
            {
                Console.WriteLine("Você acertou!");
                break;
            }
        }
    }
}
