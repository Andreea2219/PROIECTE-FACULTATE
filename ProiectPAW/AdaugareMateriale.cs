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
    public partial class AdaugareMateriale : Form
    {
        public AdaugareMateriale()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Preluam datele introduse de utilizator in textBoxuri
                string nume = tbNume.Text;
                string cantitate = tbCantitate.Text;
                string pret = tbPret.Text;

                //Verificam daca toate campurile sunt completate
                if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(cantitate) ||
                    string.IsNullOrWhiteSpace(pret))
                {
                    MessageBox.Show("Toate câmpurile trebuie completate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Scriem informatiile materialului in fisierul materiale.txt
                using (StreamWriter sw = new StreamWriter("materiale.txt", true))
                {
                    sw.WriteLine($"{nume},{cantitate},{pret}");
                }
                MessageBox.Show("Datele materialului au fost salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
