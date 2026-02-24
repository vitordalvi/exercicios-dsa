namespace exercicio19.entities
{
    // Classe Pedido
    class Pedido
    {
        private ItemPedido[] itens = new ItemPedido[10];
        private int quantidadeItens = 0;
        private string formaPagamento;

        public void SetFormaPagamento(string f) { formaPagamento = f; }

        public void AdicionarItem(ItemPedido item)
        {
            itens[quantidadeItens] = item;
            quantidadeItens++;
        }

        public double CalcularTotal()
        {
            double total = 0;
            for (int i = 0; i < quantidadeItens; i++)
            {
                total += itens[i].Subtotal();
            }
            return total;
        }
    }
}
