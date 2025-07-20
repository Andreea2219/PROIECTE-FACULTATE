using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class Contracte
    {
        private int nrContract;
        private Furnizori furnizor;
        private Materiale material;
        private int cantitate;
        private DateTime dataContract;

        public Contracte(int nrContract, Furnizori furnizor, Materiale material, int cantitate, DateTime dataContract)
        {
            this.nrContract = nrContract;
            this.furnizor = furnizor;
            this.material = material;
            this.cantitate = cantitate;
            this.dataContract = dataContract;
        }

    }
}
