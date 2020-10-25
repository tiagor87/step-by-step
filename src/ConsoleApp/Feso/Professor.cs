namespace StepByStep.ConsoleApp.Feso
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        protected override string ObterTipo()
        {
            return "Professor";
        }
    }
}
