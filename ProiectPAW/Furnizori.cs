using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class Furnizori
    {
        private int id;
        private string nume;
        private string email;
        private int telefon;
        private Materiale material;

        public Furnizori(int id, string nume, string email, int telefon, Materiale material)
        {
            this.id = id;
            this.nume = nume;
            this.email = email;
            this.telefon = telefon;
            this.material = material;
        }
        public string Nume { get => nume; }
        public Materiale Material { get => material; }

    }
}
