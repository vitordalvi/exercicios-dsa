//Calcule o	retorno	de	um	investimento	financeiro fazendo	as	contas	mês	a	mês, sem	usar	a	
//fórmula	 de	 juros	 compostos.	 O	 usuário	 deve	 informar	 quanto	 será	 investido	 por	 mês	 e	
//qual	será	a	taxa	de	juros	mensal.	O	programa	deve	informar	o	saldo	do	investimento	após	
//um	ano	(soma	das	aplicações	mês	a	mês considerando	os juros	compostos), e	perguntar	ao	
//usuário	 se	 ele	 deseja	 que	 seja	 calculado	 o	 ano	 seguinte, sucessivamente.	 Por	 exemplo,
//caso	o	usuário	deseje	investir	R$	100,00	por	mês, e	tenha	uma	taxa	de	juros	de	1%	ao	mês,
//o	programa	forneceria	a	seguinte	saída:

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Quanto será investido por mês?: ");

        if (!double.TryParse(Console.ReadLine(), out double investimentoMes))
        {
            Console.Write("Valor inválido. Insira novamente: ");
        }

        Console.Write("Qual será a taxa de juros mensal: ");

        if (!double.TryParse(Console.ReadLine(), out double porcentagemMes))
        {
            Console.Write("Valor inválido. Insira novamente: ");
        }

        double valorAtual = calc(investimentoMes, porcentagemMes);
        Console.WriteLine($"Saldo do investimento após 1 ano: {valorAtual}");

        Console.Write("Você deseja calcular mais um mês? (S/N): ");

        string op = Console.ReadLine().ToLowerInvariant();

        switch (op)
        {
            case "s":
                Console.WriteLine($"Digite o valor extra que será investido: ");

                if (!double.TryParse(Console.ReadLine(), out double valorExtra))
                {
                    Console.Write("Valor inválido. Tente inserir um valor numérico: ");
                }

                Console.WriteLine($"Digite o valor da porcentagem extra do que será investido: ");

                if (!double.TryParse(Console.ReadLine(), out double porcentagemExtra))
                {
                    Console.Write("Valor inválido. Tente inserir um valor numérico: ");
                }

                Console.WriteLine($"Resultado após mais um ano: {calcExtra(valorAtual, valorExtra, porcentagemExtra)}");
                break;

            case "n":
                Console.WriteLine("Programa finalizado.");
                break;

            default:
                Console.WriteLine("Entrada inválida. Tente novamente!");
                break;

        }
    }

    public static double calc(double investimentoMes, double porcentagemMes)
    {
        double valor = 0;
        double taxa = porcentagemMes / 100;

        for (int i = 1; i <= 12; i++)
        {
            valor += investimentoMes;
            valor += valor * taxa;
        }

        return valor;
    }

    public static double calcExtra(double valorAtual, double investimentoMes, double porcentagemMes)
    {
        double taxa = porcentagemMes / 100;

        for (int i = 1; i <= 12; i++)
        {
            valorAtual += investimentoMes;
            valorAtual += valorAtual * taxa;
        }

        return valorAtual;
    }
}