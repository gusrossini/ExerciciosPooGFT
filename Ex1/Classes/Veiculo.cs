using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Veiculo
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public float Km { get; private set; }
        public bool IsLigado { get; private set; }
        public int LitrosCombustivel { get; private set; }
        public int Velocidade { get; private set; }
        public double Preco { get; private set; }
        

        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            IsLigado = isLigado;
            LitrosCombustivel = litrosCombustivel;
            Velocidade = velocidade;
            Preco = preco;
        }

        public int Acelerar()
        {
            Velocidade = Velocidade + 20;
            return Velocidade;
        }
        public int Abastecer(int litros)
        {
            if (litros < 60)
            {
                LitrosCombustivel = LitrosCombustivel + litros;
                return LitrosCombustivel;
            }
            return LitrosCombustivel;

        }
        public int frear()
        {
            Velocidade = Velocidade - 20;
            return Velocidade;
            Console.WriteLine($"Velocidade: {Velocidade}KM/h");

        }
        public string pintar(string cor)
        {
            Cor = cor;
            return cor;
        }

        public bool ligar()
        {
            if (IsLigado == false)
            {
                IsLigado = true;
                return IsLigado;
            }
            return IsLigado;
        }

        public int desligar()
        {
            while (Velocidade > 0)
            {
                frear();
                Console.WriteLine($"Velocidade: {Velocidade}KM/h");

                if (Velocidade == 0)
                {
                    IsLigado = false;
                }
            }

            return Velocidade;
        }

    }
}
