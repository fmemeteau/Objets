using System.Runtime.CompilerServices;

namespace CL_Fraction
{
    public class Fraction
    {
        int numerateur, denominateur;

        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 1;
        }

        public Fraction(int _numerateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = 1;
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }

        public string AfficherLaFraction()
        {
            string result;
            
            if(denominateur==1)
            {
                result = numerateur.ToString();
            }
            else
            {
                result = numerateur.ToString() + "/" + denominateur.ToString();
            }
            return result;
        }
    }
}