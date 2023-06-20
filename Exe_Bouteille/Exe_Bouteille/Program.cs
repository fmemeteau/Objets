namespace Exe_Bouteille.Contenant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CL_Bouteille Vittel = new CL_Bouteille();
            CL_Bouteille BlueprintCoca = new CL_Bouteille("coca", false, 1f, 0.5f);
            CL_Bouteille Orangina = new CL_Bouteille("orangina", true, 1.5f, 1f);
            CL_Bouteille Coca = new CL_Bouteille(BlueprintCoca);

            Coca.Ouvrir();
            Orangina.Fermer();
            Orangina.RetirerDuContenu(0.5f); // Impossible de vider, la bouteille d'Orangina a été fermée

            
            Console.WriteLine(Coca.BouteilleToString());
            Console.WriteLine(Orangina.BouteilleToString());
        }
    }
}