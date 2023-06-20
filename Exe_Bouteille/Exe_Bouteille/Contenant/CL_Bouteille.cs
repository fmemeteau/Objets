using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_Bouteille.Contenant
{
    internal class CL_Bouteille
    {
        // Attributs
        private string contenuBouteille;
        private bool bouteilleOuverte;
        private float volumeMaxEnLitres;
        private float volumeActuelEnLitres;

        // Accesseurs Mutateurs
        public bool BouteilleOuverte { get => bouteilleOuverte; set => bouteilleOuverte = value; }
        public float VolumeMaxEnLitres { get => volumeMaxEnLitres; }
        public float VolumeActuelEnLitres { get => volumeActuelEnLitres; set => volumeActuelEnLitres = value; }
        public string ContenuBouteille { get => contenuBouteille; set => contenuBouteille = value;  }


        // Constructeurs
        public CL_Bouteille()
        {
            contenuBouteille = "eau";
            bouteilleOuverte = false;
            volumeMaxEnLitres = 1f;
            volumeActuelEnLitres = 0f;
        }

        public CL_Bouteille(string _contenuBouteille, bool _bouteilleOuverte, float _volumeMaxEnLitres, float _volumeActuelEnLitres)
        {
            this.contenuBouteille = _contenuBouteille;
            this.bouteilleOuverte = _bouteilleOuverte;
            this.volumeMaxEnLitres = _volumeMaxEnLitres;
            this.volumeActuelEnLitres = _volumeActuelEnLitres;
        }        

        public CL_Bouteille(CL_Bouteille BouteilleACopier)
        {
            this.contenuBouteille = BouteilleACopier.contenuBouteille;
            this.bouteilleOuverte = BouteilleACopier.bouteilleOuverte;
            this.volumeMaxEnLitres = BouteilleACopier.volumeMaxEnLitres;
            this.volumeActuelEnLitres = BouteilleACopier.volumeActuelEnLitres;
        }

        // Fonctions
        public bool Ouvrir()
        {
            if(!this.bouteilleOuverte) // if this.bouteilleOuverte = false
            {
                this.bouteilleOuverte = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Fermer()
        {
            if(this.bouteilleOuverte)
            {
                this.bouteilleOuverte = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RetirerDuContenu(float volumeAViderEnL)
        {
            if(volumeAViderEnL < volumeActuelEnLitres && bouteilleOuverte)
            {
                volumeActuelEnLitres = volumeActuelEnLitres - volumeAViderEnL;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AjouterDuContenu(float volumeARemplirEnL)
        {
            if(bouteilleOuverte && volumeActuelEnLitres < volumeMaxEnLitres)
            {
                volumeActuelEnLitres = volumeActuelEnLitres + volumeARemplirEnL;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Vider()
        {
            if(bouteilleOuverte && volumeActuelEnLitres > 0)
            {
                volumeActuelEnLitres = 0;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Remplir()
        {
            if(bouteilleOuverte && volumeActuelEnLitres < volumeMaxEnLitres)
            {
                volumeActuelEnLitres = volumeMaxEnLitres;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string BouteilleToString()
        {
            string bouteilleString = "----------------------------------------------- \n" +
                "Contenu bouteille : " + contenuBouteille + "\n" +
                "Est-elle ouverte ? " + bouteilleOuverte + "\n" +
                "Volume maxi en litres : " + volumeMaxEnLitres + "\n" +
                "Volume actuel en litres : " + volumeActuelEnLitres;

            return bouteilleString;
        }
    }
}
