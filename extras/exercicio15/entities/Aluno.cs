
namespace exercicio15.entities
{
    public class Aluno
    {
        private double Nota;
        private bool Status;

        public Aluno(double nota)
        {
            this.Nota = nota;
        }


        public void SetNota(double nota)
        {
            this.Nota = nota;
        }

        public void RemoveNota(double nota)
        {
            this.Nota -= nota;
        }

        public double GetNota()
        {
            return this.Nota;
        }

        public void VerificarStatus()
        {
            if (Nota >= 6)
            {
                Console.WriteLine($"A sua nota é {Nota}. Você foi aprovado!");
            } 
            else if (Nota >= 4 && Nota < 6)
            {
                Console.WriteLine($"A sua nota é {Nota}. Você está em Verificação Suplementar.");
            }
            else
            {
                Console.WriteLine("Você está reprovado.");
            }
        }

        public bool UpdateStatus()
        {
            if (Nota < 6)
            {
                return false;
            }

            return true;
        }
    }
}
