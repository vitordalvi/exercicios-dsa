//Para  cada produto	 informado	 (nome, preço	 e	 quantidade), escreva	 o	 nome	 do	 produto	
//comprado	 e	 o	 valor	 total	 a	 ser	 pago, considerando	 que	 são	 oferecidos	 descontos	 pelo	
//número	de	unidades	compradas, segundo	a	tabela	abaixo:	
//a.Até  10  unidades: valor total
//b.de   11 a    20	unidades: 10 % de  desconto
//c.de   21  a   50	unidades: 20 % de  desconto
//d.acima de  50	unidades: 25 % de  desconto

using exercicio4.entities;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Insira o nome do produto: ");
        string nomeProduto = Console.ReadLine();

        Console.Write("Insira o preço do produto: ");

        if (!double.TryParse(Console.ReadLine(), out double precoProduto))
        {
            Console.WriteLine("Valor inválido. Insira um valor numérico: ");
        }

        Console.Write("Insira a quantidade de produtos: ");

        if (!int.TryParse(Console.ReadLine(), out int quantidadeProdutos))
        {
            Console.Write("Valor inválido. Insira um valor inteiro: ");
        }

        Produto produto = new Produto(nomeProduto, precoProduto, quantidadeProdutos);

        Console.WriteLine(produto.ToString());
    }
}
