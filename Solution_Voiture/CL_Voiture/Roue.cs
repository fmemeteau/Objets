using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Roue
    {
        private decimal dimensionPneuEnMm;

        private bool tourne;

        // constructeurs
        public Roue()
        {
            tourne = false;
            dimensionPneuEnMm = 205;

        }
        public Roue(bool tourne, decimal dimensionPneuEnMm)
        {
            this.tourne = tourne;
            this.dimensionPneuEnMm = dimensionPneuEnMm;
        }

        public Roue(Roue roueACopier)
        {
            this.tourne = roueACopier.tourne;
            this.dimensionPneuEnMm = roueACopier.dimensionPneuEnMm;
        }
        
        
        public bool Tourner()
        {
            if(this.tourne)
            {
                return false;
            }
            else
            {
                this.tourne = true;
                return true;
            }

        }

     
        public bool SArreter()
        {
            if(this.tourne)
            {
                this.tourne = false;

                return  true;
            }
            else
            {
                return false;
            }
        }

    }
}
