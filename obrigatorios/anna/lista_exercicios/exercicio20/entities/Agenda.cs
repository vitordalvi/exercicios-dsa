namespace exercicio20.entities
{
    // Classe Agenda
    class Agenda
    {
        private Contato[] contatos = new Contato[10];
        private int quantidade = 0;

        public void AdicionarContato(Contato c)
        {
            contatos[quantidade] = c;
            quantidade++;
        }
    }
}
