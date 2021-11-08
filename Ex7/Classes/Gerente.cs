using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7.Classes
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public double BonificacaoGerente()
        {
            return Bonificacao() + 10000.00;
        }
    }
}
