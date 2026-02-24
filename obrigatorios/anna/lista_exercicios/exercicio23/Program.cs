// Classe Pessoa
class Pessoa
{
    private string nome;
    private int idade;
    private Pessoa pai;
    private Pessoa mae;

    public void SetNome(string n) { nome = n; }
    public string GetNome() { return nome; }

    public void SetIdade(int i) { idade = i; }
    public int GetIdade() { return idade; }

    public void SetPai(Pessoa p) { pai = p; }
    public Pessoa GetPai() { return pai; }

    public void SetMae(Pessoa m) { mae = m; }
    public Pessoa GetMae() { return mae; }
}