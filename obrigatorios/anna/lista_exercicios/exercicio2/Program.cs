//Crie um programa que exiba os números pares entre 1 e 100.

class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}