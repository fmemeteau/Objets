using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class CL_Papillon : CL_Stade
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Je peux voler !");
        }

        public override CL_Stade SeMetamorphoser()
        {
            return this;
        }
    }
}
