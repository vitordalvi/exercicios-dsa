//Crie um programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação.
//O programa deverá exibir na tela para o usuário quantos cachorros, gatos e peixes foram informados.
//Regras que deverão ser seguidas para a implementação do algoritmo:
//•	Os únicos tipos de animais válidos são cachorro, gato e peixe.


class Progam
{
    static void Main()
    {
        int cachorro = 0;
        int gato = 0;
        int peixe = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o nome do {i} animal: ");
            string nome = Console.ReadLine();

            Console.Write($"Digite a raça do animal: ");
            string raça = Console.ReadLine();


            if (raça == "cachorro")
            {
                cachorro++;

            }

            else if (raça == "gato")
            {
                gato++;
            }

            else if (raça == "peixe")
            {
                peixe++;
            }

            else
            {
                Console.WriteLine("Raça invalida!");
            }
        }
        Console.WriteLine($"Foram informados {cachorro} cachorros, {gato} gatos e {peixe} peixes");

    }
}