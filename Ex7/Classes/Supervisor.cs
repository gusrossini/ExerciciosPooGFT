using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7.Classes
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public double BonificacaoSupervisor()
        {
            return Bonificacao() + 5000.00;
        }
    }
}
