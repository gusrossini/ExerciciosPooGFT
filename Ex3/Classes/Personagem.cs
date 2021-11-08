using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Classes
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public double Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public Personagem() { }

        public Personagem(string nome, int vida, int mana, double xp,
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

        public virtual void lvlUp()
        {
            Level = Level + 1;
            Vida = Vida + 100;
            Mana = Mana + 50;
            Inteligencia = Inteligencia + 30;
            Forca = Forca + 20;
        }

        public virtual int Ataque()
        {
            Random random = new Random();
            int ataque = random.Next(0, 300);
            return ataque;
        }

    }
}
