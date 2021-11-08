using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7.Classes
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public double BonificacaoVendedor()
        {
            return Bonificacao() + 3000.00;
        }
    }
}
