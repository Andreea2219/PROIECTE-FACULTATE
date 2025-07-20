namespace ProiectPAW
{
    partial class FormularAprovizionare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAdaugaFurnizor = new System.Windows.Forms.Button();
            this.btnAdaugaMaterial = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnListaFurnizori = new System.Windows.Forms.Button();
            this.btnListaMateriale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnImprimareContract = new System.Windows.Forms.Button();
            this.btnPrevizualizareContract = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbContracte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugaFurnizor
            // 
            this.btnAdaugaFurnizor.Location = new System.Drawing.Point(237, 121);
            this.btnAdaugaFurnizor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugaFurnizor.Name = "btnAdaugaFurnizor";
            this.btnAdaugaFurnizor.Size = new System.Drawing.Size(128, 28);
            this.btnAdaugaFurnizor.TabIndex = 4;
            this.btnAdaugaFurnizor.Text = "Adauga furnizor";
            this.btnAdaugaFurnizor.UseVisualStyleBackColor = true;
            this.btnAdaugaFurnizor.Click += new System.EventHandler(this.btnAdaugaFurnizor_Click_1);
            // 
            // btnAdaugaMaterial
            // 
            this.btnAdaugaMaterial.Location = new System.Drawing.Point(237, 183);
            this.btnAdaugaMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugaMaterial.Name = "btnAdaugaMaterial";
            this.btnAdaugaMaterial.Size = new System.Drawing.Size(128, 28);
            this.btnAdaugaMaterial.TabIndex = 5;
            this.btnAdaugaMaterial.Text = "Adauga material";
            this.btnAdaugaMaterial.UseVisualStyleBackColor = true;
            this.btnAdaugaMaterial.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 245);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Creare contract";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(412, 248);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Lista contracte";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnListaFurnizori
            // 
            this.btnListaFurnizori.Location = new System.Drawing.Point(412, 121);
            this.btnListaFurnizori.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaFurnizori.Name = "btnListaFurnizori";
            this.btnListaFurnizori.Size = new System.Drawing.Size(128, 28);
            this.btnListaFurnizori.TabIndex = 8;
            this.btnListaFurnizori.Text = "Lista furnizori";
            this.btnListaFurnizori.UseVisualStyleBackColor = true;
            this.btnListaFurnizori.Click += new System.EventHandler(this.btnListaFurnizori_Click);
            // 
            // btnListaMateriale
            // 
            this.btnListaMateriale.Location = new System.Drawing.Point(412, 180);
            this.btnListaMateriale.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaMateriale.Name = "btnListaMateriale";
            this.btnListaMateriale.Size = new System.Drawing.Size(128, 28);
            this.btnListaMateriale.TabIndex = 9;
            this.btnListaMateriale.Text = "Lista materiale";
            this.btnListaMateriale.UseVisualStyleBackColor = true;
            this.btnListaMateriale.Click += new System.EventHandler(this.btnListaMateriale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Furnizori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Materiale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contracte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(594, 56);
            this.label4.TabIndex = 13;
            this.label4.Text = "Activitate de Aprovizionare";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(119, 502);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(564, 178);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnImprimareContract
            // 
            this.btnImprimareContract.Location = new System.Drawing.Point(556, 265);
            this.btnImprimareContract.Name = "btnImprimareContract";
            this.btnImprimareContract.Size = new System.Drawing.Size(158, 23);
            this.btnImprimareContract.TabIndex = 15;
            this.btnImprimareContract.Text = "Imprimare Contract";
            this.btnImprimareContract.UseVisualStyleBackColor = true;
            this.btnImprimareContract.Click += new System.EventHandler(this.btnImprimareContract_Click);
            // 
            // btnPrevizualizareContract
            // 
            this.btnPrevizualizareContract.Location = new System.Drawing.Point(556, 236);
            this.btnPrevizualizareContract.Name = "btnPrevizualizareContract";
            this.btnPrevizualizareContract.Size = new System.Drawing.Size(158, 23);
            this.btnPrevizualizareContract.TabIndex = 16;
            this.btnPrevizualizareContract.Text = "Previzualizare Contract";
            this.btnPrevizualizareContract.UseVisualStyleBackColor = true;
            this.btnPrevizualizareContract.Click += new System.EventHandler(this.btnPrevizualizareContract_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 44);
            this.label5.TabIndex = 17;
            this.label5.Text = "  Drag&Drop \r\n\"contracte.txt\":";
            // 
            // tbContracte
            // 
            this.tbContracte.AllowDrop = true;
            this.tbContracte.Location = new System.Drawing.Point(604, 156);
            this.tbContracte.Name = "tbContracte";
            this.tbContracte.Size = new System.Drawing.Size(161, 22);
            this.tbContracte.TabIndex = 18;
            // 
            // FormularAprovizionare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ProiectPAW.Properties.Resources.constructii;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(805, 692);
            this.Controls.Add(this.tbContracte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrevizualizareContract);
            this.Controls.Add(this.btnImprimareContract);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListaMateriale);
            this.Controls.Add(this.btnListaFurnizori);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAdaugaMaterial);
            this.Controls.Add(this.btnAdaugaFurnizor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularAprovizionare";
            this.Text = "FormularAprovizionare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAdaugaFurnizor;
        private System.Windows.Forms.Button btnAdaugaMaterial;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnListaFurnizori;
        private System.Windows.Forms.Button btnListaMateriale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnImprimareContract;
        private System.Windows.Forms.Button btnPrevizualizareContract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbContracte;
    }
}