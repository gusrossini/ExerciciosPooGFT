using Ex7.Classes;
using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario1 = new Vendedor("jeremias", 28, 1323.08);
            var funcionario2 = new Supervisor("Marisa", 34, 2521.85);
            var funcionario3 = new Gerente("Carla", 41, 3743.99);

            Console.WriteLine($"Funcionario: {funcionario1.Nome} \nIdade: {funcionario1.Idade} anos" +
                $"\nCargo: Vendedor \nSalario: R${funcionario1.Salario} \nSalario com bonificação: R${funcionario1.BonificacaoVendedor()}");

            Console.WriteLine($"\nFuncionario: {funcionario2.Nome} \nIdade: {funcionario2.Idade} anos" +
                $"\nCargo: Supervisor \nSalario: R${funcionario2.Salario} \nSalario com bonificação: R${funcionario2.BonificacaoSupervisor()}");

            Console.WriteLine($"\nFuncionario: {funcionario3.Nome} \nIdade: {funcionario3.Idade} anos" +
                $"\nCargo: Gerente \nSalario: R${funcionario3.Salario} \nSalario com bonificação: R${funcionario3.BonificacaoGerente()}");

        }
    }
}
