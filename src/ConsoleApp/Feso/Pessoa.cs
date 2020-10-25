using StepByStep.ConsoleApp.Shared;

namespace StepByStep.ConsoleApp.Feso
{

    // Tipos de acesso: public, protected, private
    public abstract class Pessoa : IPessoa
    {
        // Construtor
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        // Propriedade
        public string Nome { get; }

        public override string ToString()
        {
            return $"{this.ObterTipo()} {this.Nome}";
        }

        protected abstract string ObterTipo();
    }
}
