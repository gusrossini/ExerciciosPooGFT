using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex4_Ex5_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoa = new List<Pessoa>();
            listaPessoa.Add(new Pessoa("João", 15));
            listaPessoa.Add(new Pessoa("Leandro", 21));
            listaPessoa.Add(new Pessoa("Paulo", 17));
            listaPessoa.Add(new Pessoa("Jessica", 18));

            //pessoa mais velha
            var listaOrdenada = listaPessoa.OrderByDescending(p => p.Idade).ToList();
            Console.WriteLine("Pessoa mais velha:");
            Console.WriteLine($"{listaOrdenada[0].Nome}, {listaOrdenada[0].Idade} anos");

            //removendo menores de 18 anos 
            Console.WriteLine("\nRemovendo menores de 18 anos");
            Console.WriteLine("Lista atualizada: ");
            for (int i = 0; i < listaPessoa.Count; i++)
            {
                if (listaPessoa[i].Idade < 18)
                {
                    listaPessoa.Remove(listaPessoa[i]);
                }
            }

            foreach (Pessoa p in listaPessoa)
            {
                Console.WriteLine($"{p.Nome}, {p.Idade} anos");
            }

            //checando existencia
            Console.WriteLine("\nVerificar se Jessica esta na lista:");
            Console.WriteLine(listaPessoa.Exists(p => p.Nome == "Jessica"));


        }
    }
}
