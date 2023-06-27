using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CL_CompteBancaire
{
    public class CompteBancaire
    {
        private string nomProprietaire;
        private int numeroCompteCourant;
        private decimal solde;
        private decimal montantDecouvertAutorise;

        public CompteBancaire()
        {
            Random rnd = new Random();
            nomProprietaire = "John Doe";
            numeroCompteCourant = rnd.Next(1, 1000000);
            solde = 0;
            montantDecouvertAutorise = 0;
        }

        public CompteBancaire(string nomProprietaire, int numeroCompteCourant, decimal solde, decimal montantDecouvertAutorise)
        {
            this.nomProprietaire = nomProprietaire;
            this.numeroCompteCourant = numeroCompteCourant;
            this.solde = solde;
            this.montantDecouvertAutorise = montantDecouvertAutorise;
        }

        public CompteBancaire(CompteBancaire CompteBancaireACopier)
        {
            this.nomProprietaire = CompteBancaireACopier.nomProprietaire;
            this.numeroCompteCourant = CompteBancaireACopier.numeroCompteCourant;
            this.solde = CompteBancaireACopier.solde;
            this.montantDecouvertAutorise = CompteBancaireACopier.montantDecouvertAutorise;
        }

       /* public string NomProprietaire { get => nomProprietaire; private set => nomProprietaire = value; }
        public decimal Solde { get => solde; private set => solde = value; }
        public int NumeroCompteCourant { get => numeroCompteCourant; private set => numeroCompteCourant = value; }
        public decimal DecouvertAutorise { get => montantDecouvertAutorise; private set => montantDecouvertAutorise = value; } */

        public string AfficherLesInformationsDuCompte()
        {
            return "Nom du bénéficiaire : " + this.nomProprietaire + "\n" + "Numéro de compte : " + this.numeroCompteCourant.ToString() 
                + "\n" + "Solde : " + this.solde.ToString() + "\n" + "Découvert maximal autorisé : " + this.montantDecouvertAutorise.ToString();
        }
        /*public override string ToString()
        {
            return this.AfficherLesInformationsDuCompte();
        } */

        public void CrediterLeCompte(int montant)
        {
            solde = solde + montant;
        }

        public bool DebiterLeCompte(int montant)
        {
            if(solde - montant >= montantDecouvertAutorise)
            {
                solde = solde - montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransfererVersUnCompte(CompteBancaire autreCompte, int montant)
        {
            if(this.solde - montant >= montant)
            {
                this.DebiterLeCompte(montant);
                autreCompte.CrediterLeCompte(montant);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool SoldeSuperieur(CompteBancaire autreCompte)
        {
            if (this.solde > autreCompte.solde)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}