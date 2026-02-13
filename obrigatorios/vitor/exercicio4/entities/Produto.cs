using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio4.entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public double GetPrecoTotal()
        {
            if (Quantidade >= 11 && Quantidade <= 21)
            {
                Preco *= 0.9;
            }

            else if (Quantidade >= 21 && Quantidade <= 50)
            {
                Preco *= 0.8;
            }

            else if (Quantidade >= 50)
            {
                Preco *= 0.75;
            }

            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return $"Nome: {GetNome()}, Valor total: {GetPrecoTotal()}";
        }
    }
}
