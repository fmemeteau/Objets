using System;
namespace CL_Voiture2
{
	public class Roue
	{
		private string dimensionPneu;
		private bool tourne;

		//Propriété, c'est un accesseur. Permet d'accéder et de modifier (en débugage) les valeurs des attributs privés
		public string DimensionPneu { get => dimensionPneu; private set => dimensionPneu = value; }
		public bool Tourne { get => tourne; private set => tourne = value; }

		/*public Roue()
		{
			this.dimensionPneu = "205/55R16 91V";
			this.tourne = false;
		}*/

		//Constructeur qui va se baser sur celui mi-classique mi-défaut. Remplace celui par défaut.Le : indique que l'on se base sur un autre constructeur
		// = les dépendances entre constructeurs !
		// L'un ou l'autre des par défaut mais pas les 2
		public Roue(): this("205/55R16 91V")
		{
		}


        public Roue(string dimensionPneu, bool tourne)
		{
			this.dimensionPneu = dimensionPneu;
			this.tourne = tourne;
		}

		//constructeur mi-classique mi-défaut, ne permet de modifier que la dimension du Pneu
		public Roue(string dimensionPneu)
		{
			this.dimensionPneu = dimensionPneu;
			this.tourne = false;
		}

		public Roue(Roue roueACloner): this(roueACloner.dimensionPneu, roueACloner.tourne)
		{
		}

		public bool Tourner()
		{
			if(!tourne)
			{
				tourne = true;
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool SArreter()
		{
			if(tourne)
			{
				tourne = false;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

