using Lepidoptere.Stades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    public class CL_Lepidoptère
    {
        // attribut
        private CL_Stade stadeCourant;

        // constructeur
        public CL_Lepidoptère() 
        {
            this.stadeCourant = new CL_Oeuf();
        }

        // méthodes
        public void SeDeplacer()
        {
            this.stadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            this.stadeCourant.SeMetamorphoser();
        }

    }
}
