//Implemente um programa no qual o usuário deverá informar o nome e a idade de três pessoas.
//O programa deverá informar o nome da pessoa que possuir a maior idade.
//Regras que deverão ser seguidas para a implementação do algoritmo:
//•	É obrigatório o uso de classe para representar uma pessoa e ela deverá possuir como propriedades (características) um nome e uma idade.
//•	A classe deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e a idade da pessoa em questão.
//•	Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que irá receber o nome e a idade de uma pessoa.


class Pessoa
{
    public string Nome;
    public int Idade;
    public int Maior = 0;

    public Pessoa()
    {
        Nome = "nome";
        Idade = 0;
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirInformação()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Maior);
    }
}
class Program
{
    static void Main()
    {

        Pessoa p = new Pessoa();

        Console.WriteLine("Digite o nome e a idade de 3 pessoas para saber quem tem a maior idade:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite o nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Idade dessa pessoa: ");
            p.Idade = int.Parse(Console.ReadLine());

            if (p.Idade > p.Maior)
            {
                p.Maior = p.Idade;
            }



        }
        p.ExibirInformação();
    }
}