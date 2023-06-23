using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Moteur
    {
        // attributs
        private bool enMarche;

        
        // constructeurs
        public Moteur()
        {
            enMarche = false;
        }

        public Moteur(bool enMarche)
        {
            this.enMarche = enMarche;
        }


        public Moteur(Moteur moteurACopier)
        {
            this.enMarche = moteurACopier.enMarche;
        } 

        public bool Demarrer()
        {
            if(this.enMarche)
            {
                return false;
            }
            else
            {
                this.enMarche = true;
                return true;
            }
        }

     
        public bool Eteindre()
        {
            if(this.enMarche)
            {
                this.enMarche = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
