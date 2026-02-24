namespace exercicio22.entities
{
    // Classe Emprestimo
    class Emprestimo
    {
        private Livro livro;
        private Pessoa pessoa;
        private string data;

        public void RealizarEmprestimo(Livro l, Pessoa p, string d)
        {
            if (l.GetDisponivel())
            {
                livro = l;
                pessoa = p;
                data = d;
                l.SetDisponivel(false);
            }
        }
    }
}
