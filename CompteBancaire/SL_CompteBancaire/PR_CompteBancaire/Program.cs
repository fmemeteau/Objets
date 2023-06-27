using CL_CompteBancaire;

namespace PR_CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte1 = new CompteBancaire("Fabian", 684564652, 30000, 200);
            CompteBancaire compte2 = new CompteBancaire();

            Console.WriteLine(compte1.AfficherLesInformationsDuCompte());

            compte1.TransfererVersUnCompte(compte2, 18000);


            compte1.SoldeSuperieur(compte2);

    


        }
    }
}