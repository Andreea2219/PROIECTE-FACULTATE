using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectPAW
{
    public partial class FormularAprovizionare : Form
    {
        private PrintDocument printDocument = new PrintDocument(); //Obiect pentru imprimare
        private List<string> contracteDeImprimat = new List<string>(); //Lista pentru contracte
        
        public FormularAprovizionare()
        {
            InitializeComponent();

            //Seteaza evenimentul pentru imprimare
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            //Activeaza Drag&Drop pe tbContracte
            tbContracte.AllowDrop = true;
            tbContracte.DragEnter += new DragEventHandler(tbContracte_DragEnter);
            tbContracte.DragDrop += new DragEventHandler(tbContracte_DragDrop);

        }

        //Deschide formularul pentru adaugarea unui furnizor
        private void btnAdaugaFurnizor_Click_1(object sender, EventArgs e)
        {
            AdaugaFurnizor adaugaFurnizor = new AdaugaFurnizor();
            adaugaFurnizor.ShowDialog();
        }

        //Deschide fisierul furnizori.txt in notepad
        private void btnListaFurnizori_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", "furnizori.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fișierul furnizori.txt nu există. Salvează cel puțin un furnizor înainte de a-l vizualiza.", "Fișier lipsă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la deschiderea fișierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Deschide formularul pentru adaugarea materialelor
        private void button2_Click(object sender, EventArgs e)
        {
            AdaugareMateriale adaugareMateriale = new AdaugareMateriale();
            adaugareMateriale.ShowDialog();
        }

        //Deschide fisierul materiale.txt in notepad
        private void btnListaMateriale_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", "materiale.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fișierul materiale.txt nu există. Salvează cel puțin un material înainte de a-l vizualiza.", "Fișier lipsă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la deschiderea fișierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Deschide formularul pentru crearea unui contract
        private void button3_Click(object sender, EventArgs e)
        {
            CreareContract creareContract = new CreareContract();
            creareContract.ShowDialog();
        }

        //Deschide fisierul contracte.txt in notepad
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", "contracte.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fișierul contracte.txt nu există. Salvează cel puțin un contract înainte de a-l vizualiza.", "Fișier lipsă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la deschiderea fișierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Incarca datele materialelor si le afiseaza intr-un grafic
        private void Form1_Load(object sender, EventArgs e) 
        {
            chart1.Series.Clear(); //Sterge orice serie existenta in grafic
            Series serieMateriale = new Series("Materiale");
            serieMateriale.ChartType = SeriesChartType.Column; //Seteaza graficul ca tip coloana

            try
            {
                using (StreamReader sr = new StreamReader("materiale.txt")) //Deschide fisierul materiale.txt
                {
                    string linie;
                    bool primaLinie = true;

                    while ((linie = sr.ReadLine()) != null)
                    {
                        if (primaLinie)
                        {
                            primaLinie = false; // Sarim prima linie (antetul)
                            continue;
                        }

                        string[] valori = linie.Split(','); //Separam datele prin ,
                        if (valori.Length >= 2) //Verificam daca avem cel putin 2 valori: material si cantitate
                        {
                            string material = valori[0]; //Numele materialului
                            int cantitate = Convert.ToInt32(valori[1]); //Cantitatea disponibila

                            serieMateriale.Points.AddXY(material, cantitate); //Adauga datele in grafic
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea fișierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            chart1.Series.Add(serieMateriale);
        }

        //Citeste contractele din fisier si le formateaza pentru imprimare
        private void CitesteContracteDinFisier()
        {
            contracteDeImprimat.Clear(); //Curata lista pentru a evita duplicarea

            try
            {
                using (StreamReader sr = new StreamReader("contracte.txt")) //Deschide fisierul contracte.txt
                {
                    string linie;
                    bool primaLinie = true;
                    contracteDeImprimat.Add("Contracte:\n");
                    int nr = 1; //Numerotare contracte
                    while ((linie = sr.ReadLine()) != null)
                    {
                        if (primaLinie)
                        {
                            primaLinie = false;
                            continue;
                        }

                        string[] valori = linie.Split(','); // Separam elementele contractului
                        if (valori.Length == 4) // Verificam ca avem toate elementele
                        {
                            string contractFormatat = $"{nr}. Furnizor: {valori[0]}, Material: {valori[1]}, Cantitate: {valori[2]}, Data: {valori[3]}";
                            contracteDeImprimat.Add(contractFormatat); // Adaugam în lista formatat
                        }
                        nr++;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea contractelor: {ex.Message}", "Eroare");
            }
        }

        //Imprima contractele
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
            {
            Font font = new Font("Arial", 14); //Seteaza fontul pentru imprimare
            float yPosition = e.MarginBounds.Top; // Folosim marginea paginii
            float lineHeight = font.GetHeight(e.Graphics); //Inaltimea fiecarei linii de text

            yPosition += lineHeight; // Mutam pozitia pentru a nu suprapune textul debug

            if (contracteDeImprimat.Count == 0)
            {
                e.Graphics.DrawString("Nu există contracte disponibile pentru imprimare!", font, Brushes.Black, new PointF(e.MarginBounds.Left, yPosition));
                return; //Opresc imprimarea daca nu exista contracte
            }

            foreach (string contract in contracteDeImprimat)
            {
                e.Graphics.DrawString(contract, font, Brushes.Black, new PointF(e.MarginBounds.Left, yPosition));
                yPosition += lineHeight; //Muta textul mai jos pe pagina

                if (yPosition > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; //Activeaza paginile multiple daca textul depaseste marginea
                    return;
                }
            }
        }

        private void btnImprimareContract_Click(object sender, EventArgs e)
        {
            //Citeste contractele din fisier si le pregateste pentru imprimare
            CitesteContracteDinFisier();

            //Daca exista contracte de imprimat, deschide dialogul de imprimare
            if (contracteDeImprimat.Count > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                //Daca utilizatorul confirma imprimarea, incepe procesul
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }


        private void btnPrevizualizareContract_Click(object sender, EventArgs e)
        {
            //Citeste contractele din fisier si le pregateste pentru previzualizare
            CitesteContracteDinFisier();

            //Daca exista contracte deschide fereastra de previzualizare a imprimarii
            if (contracteDeImprimat.Count > 0)
            {
                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDocument;
                previewDialog.ShowDialog();
            }
        }


        private void tbContracte_DragEnter(object sender, DragEventArgs e)
        {
            //Verifica daca utilizatorul trage un fisier in aplicatie
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //Permite copierea fisierului prin Drag&Drop
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void tbContracte_DragDrop(object sender, DragEventArgs e)
        {
            //Preia lista de fisiere trase in aplicatie
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //Verifica daca fisierul este de tip .txt
            if (files.Length > 0 && Path.GetExtension(files[0]).Equals(".txt", StringComparison.OrdinalIgnoreCase))
            {
                //Citeste continutul fisierului si il afiseaza in textBox
                string content = File.ReadAllText(files[0]);
                tbContracte.Text = content;
                MessageBox.Show("Fișierul contracte.txt a fost încărcat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fișierul nu este de tip .txt!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
