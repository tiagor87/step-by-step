using System;
using StepByStep.ConsoleApp.Feso;
using StepByStep.ConsoleApp.PedidoOnline;
using StepByStep.ConsoleApp.PessoasDesaparecidas;
using StepByStep.ConsoleApp.Shared;

namespace StepByStep.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPessoa professor = new Professor("Tiago Resende");
            IPessoa aluno = new Aluno("Brenno");
            IPessoa coordenador = new Coordenador("Laion");

            var pedido1 = new Pedido(professor);
            var pedido2 = new Pedido(aluno);
            var pedido3 = new Pedido(coordenador);
            
            var desaparecido = new Desaparecido("Tiago");
            var pedido4 = new Pedido(desaparecido);

            Console.WriteLine("Hello " + professor);
            Console.WriteLine("Hello " + aluno);
            Console.WriteLine("Hello " + coordenador);
        }
    }
}
