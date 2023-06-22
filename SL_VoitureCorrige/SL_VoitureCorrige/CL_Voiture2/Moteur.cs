using System;
namespace CL_Voiture2
{
	public class Moteur
	{

		private bool enMarche;

		public bool EnMarche { get => enMarche; private set => enMarche = value; }

		public Moteur() : this(false)
		{
		}

		public Moteur(bool enMarche)
		{
			this.enMarche = enMarche;
		}

		public Moteur(Moteur moteurACloner) : this(moteurACloner.enMarche)
		{
		}

		public bool Demarrer()
		{
			if(!enMarche)
			{
				enMarche = true;
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool SArreter()
		{
			if(enMarche)
			{
				enMarche = false;
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EntrainerRoues(Roue roue1, Roue roue2)
		{
			if(enMarche)
			{
				//Demande aux 2 roues de tourner via la méthode Tourner() de la classe Roue. Le résultat (true/false) est enregistré et vérifie
				//si les 2 roues peuvent tourner ou non
				bool ok1 = roue1.Tourner();
				bool ok2 = roue2.Tourner();
				//if(roue1.Tourner() && roue2.Tourner()) est une autre manière d'écrire la condition
				if(ok1 && ok2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}
	}
}

