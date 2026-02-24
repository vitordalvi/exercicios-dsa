namespace exercicio19.entities
{
    // Classe ItemPedido
    class ItemPedido
    {
        private Produto produto;
        private int quantidade;

        public void SetProduto(Produto p) { produto = p; }
        public void SetQuantidade(int q) { quantidade = q; }

        public double Subtotal()
        {
            return produto.GetPreco() * quantidade;
        }
    }
}
