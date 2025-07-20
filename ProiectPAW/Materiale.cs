using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class Materiale
    {
        private string nume;
        private int cantitate;
        private int pret;

        public Materiale(string nume, int cantitate, int pret)
        {
            this.nume = nume;
            this.cantitate = cantitate;
            this.pret = pret;
        }

        public string Nume { get => nume; }
        public int Cantitate { get => cantitate; }  
        
    }
}
