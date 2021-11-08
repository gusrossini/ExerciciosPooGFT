using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Ex5_Ex6
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public Pessoa() { }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }


    }
}
