using CL_CompteBancaire;

namespace PR_CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte1 = new CompteBancaire("Fabian", 684564652, 30000, 200);
            CompteBancaire compte2 = new CompteBancaire();
            compte1.AfficherLesInformationsDuCompte();
            Console.WriteLine("\n\n");
            compte2.AfficherLesInformationsDuCompte();
            Console.WriteLine("\n\n");

            compte1.TransfererVersUnCompte(compte2, 18000);

            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");

            compte1.AfficherLesInformationsDuCompte();
            Console.WriteLine("\n\n");
            compte2.AfficherLesInformationsDuCompte();


            compte1.SoldeSuperieur(compte2);
            
        }
    }
}