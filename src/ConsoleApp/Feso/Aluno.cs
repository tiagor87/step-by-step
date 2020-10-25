namespace StepByStep.ConsoleApp.Feso
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }

        protected override string ObterTipo()
        {
            return "Aluno";
        }
    }
}
