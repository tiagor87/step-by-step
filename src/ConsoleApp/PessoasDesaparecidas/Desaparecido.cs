using StepByStep.ConsoleApp.Shared;

namespace StepByStep.ConsoleApp.PessoasDesaparecidas
{
    public class Desaparecido : IPessoa
    {
        // Construtor
        public Desaparecido(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; }
    }
}
