//Os números de Fibonacci são uma sequência de números definidas recursivamente.
//O primeiro elemento da sequência é 0 e o segundo é 1.
//Os outros elementos são calculados somando os dois antecessores.
//Crie um programa que exiba os primeiros 30 números da série de Fibonacci.

class Program
{
    public static void Main(string[] args)
    {
        long a = 0;
        long b = 1;

        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 0; i <= 30; i++)
        {
            long proximo = a + b;
            Console.WriteLine(proximo);

            a = b;
            b = proximo;
        }

    }
}