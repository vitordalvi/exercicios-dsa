using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio22.entities
{
    // Classe Livro
    class Livro
    {
        private string titulo;
        private string autor;
        private bool disponivel = true;

        public void SetTitulo(string t) { titulo = t; }
        public string GetTitulo() { return titulo; }

        public void SetAutor(string a) { autor = a; }
        public string GetAutor() { return autor; }

        public bool GetDisponivel() { return disponivel; }
        public void SetDisponivel(bool d) { disponivel = d; }
    }
}
