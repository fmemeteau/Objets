using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CL_Point
{
    public class Point
    {
        float x, y;

        // Les 2 constructeurs classiques (sans celui de copie)
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }


        // Copier un point existant afin de créer un point symétrique selon l'axe des abscisses (z = 'a'), des ordonnées(z = 'o')
        // ou l'origine (z = '0')
        /*public Point(Point pointACopierAxeOrdonnees, char z)
        {
            if (z == 'o')
            {
                this.x = pointACopierAxeOrdonnees.x - 2 * pointACopierAxeOrdonnees.x;
                this.y = pointACopierAxeOrdonnees.y;
            }

            else if (z == 'a')
            {
                this.x = pointACopierAxeOrdonnees.x;
                this.y = pointACopierAxeOrdonnees.y - 2 * pointACopierAxeOrdonnees.y;
            }
            
            else if (z == '0')
            {
                this.x = pointACopierAxeOrdonnees.x - 2 * pointACopierAxeOrdonnees.x;
                this.y = pointACopierAxeOrdonnees.y - 2 * pointACopierAxeOrdonnees.y;
            }
            else
            {
                throw new Exception("Veuillez saisir 'a' pour abscisses , 'o' pour ordonnées ou '0' pour l'origine !");
            }
        }*/

        public Point CreerUnPointSymetriqueOrdonnee()
        {
            return new Point(this.x*-1, this.y);
        }

        public Point CreerUnPointSymetriqueAbscisse()
        {
            return new Point(this.x, this.y*-1);
        }

        public Point CrerUnPointSymetriqueOrigine()
        {
            return new Point(this.x * -1, this.y * -1);
        }


        public void Permutation()
        {
            float buffer = this.x;
            this.x = this.y;
            this.y = buffer;
        }

        public string AfficherCoordonnees()
        {
            return "Le point x se situe en " + this.x + ".\n" + "Le point y se situe en " + this.y + ".";
        }
    }
}
