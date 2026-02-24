using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio21.entities
{
    // Classe Pessoa
    class Pessoa
    {
        private string nome;
        private string cpf;

        public void SetNome(string n) { nome = n; }
        public string GetNome() { return nome; }

        public void SetCPF(string c) { cpf = c; }
        public string GetCPF() { return cpf; }
    }

}
