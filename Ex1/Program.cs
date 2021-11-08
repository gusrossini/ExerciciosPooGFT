using Ex1;
using System;

namespace ExerciciosGFT
{
    class Program
    {
        static void Main(string[] args)
        {
            var veiculo = new Veiculo("fiat", "uno", "axo-0786", "prata", 95000, false, 12, 0, 9000);

            Console.WriteLine($"Marca: {veiculo.Marca} \nModelo: {veiculo.Modelo} \nPlaca: {veiculo.Placa} \nCor: {veiculo.Cor}" +
                $"\nQuilometragem: {veiculo.Km} quilometros rodados \nTanque: {veiculo.LitrosCombustivel}L \nPreço: R${veiculo.Preco}");
            Console.WriteLine($"\nLigado: {veiculo.IsLigado}");

            //alterar cor
            Console.WriteLine("\nALterando a cor do veiculo...");
            veiculo.pintar("vermelho");
            Console.WriteLine($"Cor do veiculo: {veiculo.Cor}");

            //ligar
            Console.WriteLine("\nDando a partida...");
            Console.WriteLine($"Ligado: {veiculo.ligar()}");

            //acelerar
            Console.WriteLine($"\nVelocidade: {veiculo.Velocidade}KM/h");
            Console.WriteLine("Acelerando...");
            Console.WriteLine($"Velocidade: {veiculo.Acelerar()}KM/h \nVelocidade: {veiculo.Acelerar()}KM/h \nVelocidade: {veiculo.Acelerar()}KM/h");

            //abastecer
            Console.WriteLine("\nAbastacendo 30 litros");
            veiculo.Abastecer(30);
            Console.WriteLine($"Tanque: {veiculo.LitrosCombustivel}L");

            //frear
            Console.WriteLine("\nFreando...");
            Console.WriteLine($"Velocidade: {veiculo.frear()}KM/h");

            //desligar
            Console.WriteLine("\nDesligar o veículo");
            veiculo.desligar();
            Console.WriteLine($"Ligado: {veiculo.IsLigado}");

        }
    }
}
