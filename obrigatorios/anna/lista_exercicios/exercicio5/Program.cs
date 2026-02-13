//Crie um programa que exiba para o usuário qual é a área de um retângulo.
//Para implementar esse programa você deverá seguir as seguintes regras:
//•	O usuário deverá informar para o programa o valor da base e altura do retângulo/quadrado.
//•	É obrigatório criar/utilizar uma classe para representar o retângulo/quadrado.
//•	A base e a altura informada pelo usuário deveram ser representadas na classe como propriedades.
//•	O objeto deverá possuir um método que exiba os dados de todas as suas propriedades.

class Retângulo
{
    public double Altura;
    public double Base;
    public double Area;

    public void CalcularArea()
    {
        Area = Base * Altura;
    }

    public void ExibirInformação()
    {
        Console.WriteLine($"Base: {Base}");
        Console.WriteLine($"Altura:{Altura}");
        Console.WriteLine($"Area{Area}");

    }
}
class Progam
{
    static void Main()
    {
        Retângulo r = new Retângulo();

        Console.WriteLine("Digite o valor da base:");
        r.Base = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da altura: ");
        r.Altura = double.Parse(Console.ReadLine());

        r.CalcularArea();
        r.ExibirInformação();

    }
}