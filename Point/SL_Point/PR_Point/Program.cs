using CL_Point;
//using System.Drawing;



namespace PR_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(7, 15);

            

            Console.WriteLine(p1.AfficherCoordonnees() + "\n");
        
            p1.Permutation();

            p1.CrerUnPointSymetriqueOrigine();

            Console.WriteLine(p1.AfficherCoordonnees() + "\n");

        }
    }
}