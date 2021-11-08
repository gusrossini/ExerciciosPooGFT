using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Classes
{
    class Guerreiro : Personagem
    {
        public List<string> Habilidades { get; set; }

        public Guerreiro() { }

        public Guerreiro(string nome, int vida, int mana, double xp,
            int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        public int ataque()
        {
            return (Forca * Level) + new Random().Next(0, 300);
        }
        public void novaHabilidade(string habilidade)
        {
            Habilidades.Add(habilidade);
        }
    }
}
