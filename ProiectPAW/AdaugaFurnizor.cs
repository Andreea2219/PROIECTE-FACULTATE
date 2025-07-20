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
    public partial class AdaugaFurnizor : Form
    {
        public AdaugaFurnizor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Convertim id-ul si telefonul in valori numerice
                int id = Convert.ToInt32(tbID1.Text);
                string nume = tbNume1.Text;
                string email = tbEmail1.Text;
                int telefon = Convert.ToInt32(tbTelefon1.Text);
                string materialNume = tbMateriale1.Text;

                //Verifica daca utilizatorul a completat toate campurile
                if (string.IsNullOrWhiteSpace(tbID1.Text) || string.IsNullOrWhiteSpace(nume) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(tbTelefon1.Text) || string.IsNullOrWhiteSpace(materialNume))
                {
                    MessageBox.Show("Toate câmpurile trebuie completate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Initializam furnizorul cu un singur material
                Materiale material = new Materiale(materialNume, 0, 0);
                Furnizori furnizor = new Furnizori(id, nume, email, telefon, material);

                //Scriem informatiile furnizorului in fisierul furnizori.txt
                using (StreamWriter sw = new StreamWriter("furnizori.txt", true))
                {
                    sw.WriteLine($"{id},{nume},{email},{telefon},{materialNume}");
                }
                
                MessageBox.Show("Datele furnizorului au fost salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch (FormatException)
            {
                MessageBox.Show("ID-ul și Telefonul trebuie să fie valori numerice valide!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
