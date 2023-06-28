using CL_Voiture;
using System.Runtime.CompilerServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roue michelin = new Roue();
            Roue michel = new Roue(true, 210);
            Roue panama = new Roue(michelin);

            Moteur vroum = new Moteur();
            Moteur vroumPlusFort = new Moteur(true);
            Moteur vroumDeCourse = new Moteur(vroumPlusFort);

            vroum.Demarrer();


            vroum.Eteindre();
        }
    }
}