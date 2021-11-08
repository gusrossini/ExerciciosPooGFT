using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Classes
{
    class Mago : Personagem
    {
        public List<string> Magias { get; set; }

        public Mago() { }

        public Mago(string nome, int vida, int mana, double xp,
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
            return (Inteligencia * Level) + new Random().Next(0, 300);
        }
        public void novaMagia(string magia)
        {
            Magias.Add(magia);
        }
        
    }
}
