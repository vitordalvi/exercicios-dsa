// Classe do corpo celeste
class CorpoCeleste
{
    public double Massa;      // Massa
    public double Densidade;  // Densidade
    public double X;          // Posição X
    public double Y;          // Posição Y

    // Construtor
    public CorpoCeleste(double massa, double densidade, double x, double y)
    {
        Massa = massa;
        Densidade = densidade;
        X = x;
        Y = y;
    }

    // Método que calcula o raio
    public double CalcularRaio()
    {
        double volume = Massa / Densidade;
        return Math.Pow((3 * volume) / (4 * Math.PI), 1.0 / 3.0);
    }
}
// Cria um array para guardar 10 corpos celestes
CorpoCeleste[] corpos = new CorpoCeleste[10];

// Preenche o array
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Corpo " + (i + 1));

    double massa = double.Parse(Console.ReadLine());
    double densidade = double.Parse(Console.ReadLine());
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());

    // Guarda o objeto dentro do array
    corpos[i] = new CorpoCeleste(massa, densidade, x, y);
}

// Assume que o primeiro é o maior
CorpoCeleste maiorMassa = corpos[0];
CorpoCeleste maiorRaio = corpos[0];

// Procura maior massa e maior raio
for (int i = 0; i < 10; i++)
{
    if (corpos[i].Massa > maiorMassa.Massa)
        maiorMassa = corpos[i];

    if (corpos[i].CalcularRaio() > maiorRaio.CalcularRaio())
        maiorRaio = corpos[i];
}

// Maior distância no eixo X
double maiorDistancia = 0;

for (int i = 0; i < 10; i++)
{
    for (int j = i + 1; j < 10; j++)
    {
        double dist = Math.Abs(corpos[i].X - corpos[j].X);

        if (dist > maiorDistancia)
            maiorDistancia = dist;
    }
}

// Mostra resultados
Console.WriteLine("Maior massa: " + maiorMassa.Massa);
Console.WriteLine("Maior raio: " + maiorRaio.CalcularRaio());
Console.WriteLine("Maior distância no eixo X: " + maiorDistancia);