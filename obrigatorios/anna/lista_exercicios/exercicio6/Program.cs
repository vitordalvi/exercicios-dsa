//•	Um construtor sem parâmetros, que cria um ponto nas coordenadas (0,0);
//•	Um construtor que recebe dois parâmetros de coordenadas X e Y;
//•	Um construtor que inicializa o ponto através das coordenadas de um outro ponto recebido como parâmetro.

class Ponto
{
    public int X;
    public int Y;

    public Ponto()
    {
        Y = 0;
        X = 0;
    }

    public Ponto(int x, int y)
    {
        X = x;
        Y = y;
    }

    //Ele cria um ponto novo copiando as coordenadas de outro ponto.
    public Ponto(Ponto newPonto)
    {
        X = newPonto.X;
        Y = newPonto.Y;
    }
}