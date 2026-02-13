// Crie um programa que exiba o seu nome na tela 100 vezes.

class Program 
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome");
        string nome = (Console.ReadLine());
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(nome);
        }
    }
}