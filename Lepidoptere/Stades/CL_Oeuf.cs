using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class CL_Oeuf : CL_Stade
    {
       
        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne peux pas me déplacer");
        }

        public override CL_Stade SeMetamorphoser()
        {
            return new CL_Chenille();
        }

    }
}
