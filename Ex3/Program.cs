using Ex3.Classes;
using System;

namespace Ex3
{
    public class Program
    {
        static void Main(string[] args)
        {

            //**************** incompleto ********************
            Mago mago1 = new Mago("Veigar", 850, 230, 0, 175, 80, 1);
            Guerreiro guerreiro1 = new Guerreiro("Renekton", 1200, 250, 0, 100, 180, 1);

            mago1.novaMagia("materia escura");
            guerreiro1.novaHabilidade("dominus");

            mago1.lvlUp();
            guerreiro1.lvlUp();

            Console.WriteLine(mago1);
            Console.WriteLine(guerreiro1);

        }
    }
}
