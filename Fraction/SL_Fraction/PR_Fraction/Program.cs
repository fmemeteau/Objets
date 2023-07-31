
using CL_Fraction;

namespace PR_Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();

            Fraction f2 = new Fraction(2);

            Fraction f3 = new Fraction(10, 5);

            f3.AfficherLaFraction();

            Console.WriteLine(f3.AfficherLaFraction());
        }
    }
}