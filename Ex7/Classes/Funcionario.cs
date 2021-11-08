using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7.Classes
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public double Bonificacao()
        {
            return Salario;
        }
    }
}
