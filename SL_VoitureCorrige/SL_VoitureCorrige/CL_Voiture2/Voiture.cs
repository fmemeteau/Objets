using System;
namespace CL_Voiture2
{
	public class Voiture
	{
		private string marque;
		private List<Roue> ses4Roues;
		private Moteur sonMoteur;

		//Est basé sur le constructeur v3. Le client n'aura d'autres mots à donner sur la création des Roue et Moteur que leurs caractéristiques.
		//Le constructeur se charge de créer les objets.
		//Le constructeur v3 se trouve basé sur le constructeur des v1 et v2. C'est dans celui-ci seulement que se trouve le code intelligent.
		public Voiture()
		:this("Dacia", "205/55R16 91V", false, false)
		{
		}

		//Les v1 et v2 dans le programme. C'est le client qui crée les objets Roue et Moteur dans le programme
		//Sont rajoutées la condition imposant la création par le client de 4 roues ainsi que le message d'exception.
		//Throw envoie à l'écran l'exception créée
		public Voiture(string marque, List<Roue> ses4Roues, Moteur sonMoteur)
		{
			if (ses4Roues != null & ses4Roues.Count == 4)
			{
				this.marque = marque;
				this.ses4Roues = ses4Roues;
				this.sonMoteur = sonMoteur;
			}
			else
			{
				throw new Exception("Une voiture a 4 roues !");
			}
		}

		//La v3. Ce constructeur crée les objets Roue et Moteur à l'intérieur de lui-même. Le client n'a plus qu'à donner les caractéristiques
		//des Roue et Moteur dans le programme
		public Voiture(string marque, string dimensionPneu, bool tourne, bool enMarche)
		:this(marque,
				  new List<Roue> {  new Roue(dimensionPneu, tourne),
									new Roue(dimensionPneu, tourne),
									new Roue(dimensionPneu, tourne),
									new Roue(dimensionPneu, tourne)},
					new Moteur(enMarche)
                  )
		{
		}

		public Voiture(Voiture voitureACopier)
		{

		}

		public bool Demarrer()
		{
			//Codage par propagation. Démarrer la voiture active la méthode Démarrer() du moteur
			return sonMoteur.Demarrer();
		}

		public bool Avancer()
		{
			return sonMoteur.EntrainerRoues(ses4Roues[0], ses4Roues[1]);
		}
	}
}

