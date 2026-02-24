namespace exercicio20.entities
{
// Classe Contato
class Contato
    {
        private string nome;
        private string telefone;

        public void SetNome(string n) { nome = n; }
        public string GetNome() { return nome; }

        public void SetTelefone(string t) { telefone = t; }
        public string GetTelefone() { return telefone; }
    }
}
