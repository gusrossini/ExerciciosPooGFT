using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Classes
{
    class VideoGame : Produto, IImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        public VideoGame() { }

        public VideoGame(string nome, double preco, int quantidade, string marca,
            string modelo, bool isUsado) : base(nome, preco, quantidade)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public double calculaImposto()
        {
            if (this.IsUsado == true)
            {
                Console.WriteLine($"Imposto {this.Nome} {this.Modelo} usado, R${this.Preco}");
                return this.Preco * 0.45;
            }
        }
    }
}
