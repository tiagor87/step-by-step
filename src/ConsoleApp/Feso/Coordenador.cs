namespace StepByStep.ConsoleApp.Feso
{
    public class Coordenador : Professor
    {
        public Coordenador(string nome) : base(nome)
        {
        }

        protected override string ObterTipo()
        {
            return "Coordenador";
        }
    }
}
