using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Classes
{
    public class Livro : Produto, IImposto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }

        public Livro() { }

        public Livro(string nome, double preco, int quantidade, string autor, string tema,
             int qtdPag) : base(nome, preco, quantidade)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;            
        }

        public double calculaImposto()
        {
            if(this.Tema == "educativo")
            {
                Console.WriteLine($"Não há incidencia de imposto em livros educativos");
                return 0.0;
            }
            else
            {
                Console.WriteLine($"R$ {this.Preco * 0.1}");
                return this.Preco * 0.1;
            }
        }
    }
}
