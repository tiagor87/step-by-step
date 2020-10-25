using StepByStep.ConsoleApp.Shared;

namespace StepByStep.ConsoleApp.PedidoOnline
{
    public class Pedido
    {
        public Pedido(IPessoa consumidor)
        {
            Consumidor = consumidor;
        }

        public IPessoa Consumidor { get; }
    }
}
