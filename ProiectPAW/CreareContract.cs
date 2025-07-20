using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class CreareContract : Form
    {
        public CreareContract()
        {
            InitializeComponent();
        }
        
        private int ObtineCantitateDisponibila(string materialNume)
        {
            try
            {
                using (StreamReader sr = new StreamReader("materiale.txt")) //Deschide fisierul
                {
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        string[] valori = linie.Split(','); //Separa datele
                        if (valori.Length > 1 && valori[0] == materialNume) //Verifica daca materialul este cel dorit
                        {
                            return Convert.ToInt32(valori[1]); //Returneaza cantitatea disponibila
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea stocului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0; 
        }


        private bool VerificaFurnizorMaterial(Furnizori furnizor, string materialNume)
        {
                //Verifica daca furnizorul vinde materialul ales
                if (furnizor.Material.Nume == materialNume)
                {
                    return true; 
                }

            MessageBox.Show($"Furnizorul {furnizor.Nume} nu vinde materialul {materialNume}.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        private Furnizori ObtineFurnizorDinFisier(string numeFurnizor)
        {
            using (StreamReader sr = new StreamReader("furnizori.txt")) //Deschide fisierul
            {
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    string[] valori = linie.Split(','); //Separa datele
                    if (valori.Length > 4 && valori[1] == numeFurnizor) //Verifica daca exista furnizorul ales
                    {
                        Materiale material = new Materiale(valori[4], 0, 0); //Preluam materialul asociat
                        return new Furnizori(Convert.ToInt32(valori[0]), valori[1], valori[2],Convert.ToInt32(valori[3]),material);
                    }
                }
            }
            MessageBox.Show($"Furnizorul {numeFurnizor} nu a fost găsit în fișier!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        //Salvarea contractului in fisier
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica daca toate campurile sunt completate
                if (string.IsNullOrWhiteSpace(tbFurnizori.Text) || string.IsNullOrWhiteSpace(tbMateriale.Text))
                {
                    MessageBox.Show("Introduceți un furnizor și un material!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbCantitate.Text))
                {
                    MessageBox.Show("Introduceți o cantitate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string furnizorSelectat = tbFurnizori.Text;
                string materialSelectat = tbMateriale.Text;
                int cantitateSolicitata;

                //Verifica daca cantitatea este un numar valid
                if (!int.TryParse(tbCantitate.Text, out cantitateSolicitata) || cantitateSolicitata <= 0)
                {
                    MessageBox.Show("Introduceți o cantitate validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime dataContract = dtpDataContract.Value;

                //Verifica daca furnizorul exista in fisier
                Furnizori furnizorObiect = ObtineFurnizorDinFisier(furnizorSelectat);
                
                //Verifica daca furnizorul vinde materialul
                if (!VerificaFurnizorMaterial(furnizorObiect, materialSelectat))
                {
                    return;
                }


                int cantitateDisponibila = ObtineCantitateDisponibila(materialSelectat);
                
                //Verifica daca materialul este suficient in stoc
                if (cantitateDisponibila < cantitateSolicitata)
                {
                    MessageBox.Show($"Stoc insuficient pentru materialul {materialSelectat}. Disponibil: {cantitateDisponibila}, solicitat: {cantitateSolicitata}.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Scrie contractul in fisier
                using (StreamWriter sw = new StreamWriter("contracte.txt", true))
                {
                    sw.WriteLine($"{furnizorSelectat},{materialSelectat},{cantitateSolicitata},{dataContract:yyyy-MM-dd}");
                }

                MessageBox.Show("Contract salvat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea contractului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}