// Classe Produto
class Produto
{
    private string nome;
    private double preco;
    private int estoque;

    public void SetNome(string n) { nome = n; }
    public string GetNome() { return nome; }

    public void SetPreco(double p) { preco = p; }
    public double GetPreco() { return preco; }

    public void SetEstoque(int e) { estoque = e; }
    public int GetEstoque() { return estoque; }
}

