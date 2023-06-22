using CL_Voiture2;

namespace ConsoleVoiture2;
class Program
{
    static void Main(string[] args)
    {
       
        Roue michelin = new Roue();
        Roue michelin2 = new Roue(michelin);

        // test de la méthode Faire Tourner la roue. Le premier la démarre, donc true
        // le second essaie de la faire tourner, ce qu'elle fait déjà via ok. Renvoie donc false
        /*bool ok = michelin.Tourner();
        bool ok2 = michelin.Tourner();*/

        Moteur m = new Moteur();
        bool okm = m.Demarrer();

        bool okk = m.EntrainerRoues(michelin, michelin2);

        //L'objet est créé en créant nous-même les objets le composant
        Voiture v = new Voiture("Peugeot", new List<Roue> { new Roue(), new Roue(), new Roue(), new Roue(), new Roue() }, new Moteur());

        //Ici, créer la voiture en utilisant les objets créés plus haut
        Voiture v2 = new Voiture("Peugeot", new List<Roue> { michelin, michelin2, new Roue(), new Roue() }, m);

        //L'objet est créé en ne donnant que des caractéristiques. C'est à l'intérieur du constructeur que sont créés les objets Roue et Moteur
        Voiture v3 = new Voiture("Peugeot", "205/55R16 91V", false, false);
    }
}

