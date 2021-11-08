using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Classes
{
    public class Loja
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }

        public Loja() { }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames = videoGames;
        }

        public void listaLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("Não existem livros em estoque");
            }
            else
            {
                Console.WriteLine($"Livros disponíveis:");
                foreach (Livro livro in Livros)
                {
                    Console.WriteLine($"Título: {livro.Nome}, preço: R${livro.Preco}, quantidade em estoque:{livro.Quantidade}");
                }
            }
        }

        public double calculaPatrimonio()
        {
            var ValorEstoqueLivros = Livros.Sum(v => v.Preco * 1.Quantidade);
            var ValorEstoqueVideoGames = VideoGames.Sum(v => v.Preco * v.Quantidade);
            Console.WriteLine($"Patrimonio total da loja: R${ValorEstoqueLivros + ValorEstoqueVideoGames}");
            return ValorEstoqueLivros + ValorEstoqueLivros;
        }
    }
}
