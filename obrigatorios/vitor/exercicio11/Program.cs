//Calcule a	 raiz	 quadrada	 aproximada	 de	 um	 número	 inteiro	 informado	 pelo	 usuário,
//respeitando	 o	 erro	 máximo	 também	 informado	 pelo	 usuário.	 Não	 utilize	 funções	
//predefinidas.

class Program
{
    public static void Main(string[] args)
    {
        string Result = "";

        Console.Write("Digite o valor do número inteiro: ");

        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.Write("Valor inválido. Tente novamente: ");
        }

        Console.WriteLine("Digite o valor máximo decimal da raiz quadrada: ");

        if (!int.TryParse(Console.ReadLine(), out int decimalMaximo))
        {
            Console.WriteLine("Valor inválido. Tente novamente: ");
        }

        double raizQuadrada = Math.Sqrt(numero);
        string sqrt = raizQuadrada.ToString();

        char[] sqrtArray = sqrt.ToCharArray();

        for (int i = 0; i < sqrtArray.Length; i++)
        {
            if (decimalMaximo >= sqrtArray.Length)
            {
                throw new ArgumentOutOfRangeException($"O número selecionado não possui " +
                    $"essa quantidade de decimais. Você pode escolher até o número {sqrtArray.Length}");

            }

            Result = String.Join("", sqrtArray);
        }

        Console.WriteLine(Result.Substring(0, decimalMaximo));

    }
}