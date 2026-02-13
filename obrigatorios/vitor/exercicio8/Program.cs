//Calcule a	série	de	Fibonacci	para	um	número	inteiro	não	negativo	informado	pelo	usuário.	
//A	 série	 de	 Fibonacci	 inicia	 com	 os	 números	 F0 =	 0 e	 F1 =	 1, e	 cada	 número	 posterior	
//equivale	à	soma	dos	dois	números	anteriores (Fn =	Fn-1 +	Fn-2).	Por	exemplo, caso	o	usuário	
//informe	o	número	9, o	resultado	seria:	0,	1,	1,	2,	3,	5,	8,	13,	21,	34.

class Program
{
    public static void Main(string[] args)
    {
        int numero;

        Console.Write("Insira um número inteiro positivo: ");

        if (!int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero <= 0)
            {
                Console.Write("O número precisa ser positivo.");
            }

            Console.Write("O valor precisa ser numérico: ");
        }

        int a = 0;
        int b = 1;

        for (int i = 0; i < numero; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;

            Console.WriteLine(a);
        }
    }
}