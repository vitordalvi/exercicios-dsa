//Faça um	método	que	calcule	a	média	de	um	aluno	de	acordo	com	o	critério	definido	neste	
//curso.	Além	disso, faça	um	outro	método	que	informe	o	status	do	aluno	de	acordo	com	a	
//tabela	a	seguir:
//Nota acima	de	6	à “Aprovado”
//Nota	entre	4	e	6	à Conceito	“Verificação	Suplementar”
//Nota	abaixo	de	4	à Conceito	“Reprovado”

using exercicio15.entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write($"Digite a sua nota: ");
        double nota;

        if (!double.TryParse(Console.ReadLine(), out nota))
        {
            if (nota < 0)
            {
                Console.Write("Você não pode ficar com a nota negativa.");
            }

            Console.Write("O valor precisa ser numérico: ");
        }


        Aluno aluno = new Aluno(nota);

        aluno.VerificarStatus();
    }
}