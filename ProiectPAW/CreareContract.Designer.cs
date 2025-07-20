namespace ProiectPAW
{
    partial class CreareContract
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
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataContract = new System.Windows.Forms.DateTimePicker();
            this.tbMateriale = new System.Windows.Forms.TextBox();
            this.tbFurnizori = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(265, 263);
            this.tbCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(160, 22);
            this.tbCantitate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Creare Contract";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introducere furnizor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Introducere material:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(348, 556);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salvare";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantitate dorita:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data:";
            // 
            // dtpDataContract
            // 
            this.dtpDataContract.Location = new System.Drawing.Point(165, 324);
            this.dtpDataContract.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataContract.Name = "dtpDataContract";
            this.dtpDataContract.Size = new System.Drawing.Size(260, 22);
            this.dtpDataContract.TabIndex = 12;
            // 
            // tbMateriale
            // 
            this.tbMateriale.Location = new System.Drawing.Point(322, 207);
            this.tbMateriale.Margin = new System.Windows.Forms.Padding(4);
            this.tbMateriale.Name = "tbMateriale";
            this.tbMateriale.Size = new System.Drawing.Size(160, 22);
            this.tbMateriale.TabIndex = 13;
            // 
            // tbFurnizori
            // 
            this.tbFurnizori.Location = new System.Drawing.Point(322, 149);
            this.tbFurnizori.Margin = new System.Windows.Forms.Padding(4);
            this.tbFurnizori.Name = "tbFurnizori";
            this.tbFurnizori.Size = new System.Drawing.Size(160, 22);
            this.tbFurnizori.TabIndex = 14;
            // 
            // CreareContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 684);
            this.Controls.Add(this.tbFurnizori);
            this.Controls.Add(this.tbMateriale);
            this.Controls.Add(this.dtpDataContract);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCantitate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreareContract";
            this.Text = "CreareContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataContract;
        private System.Windows.Forms.TextBox tbMateriale;
        private System.Windows.Forms.TextBox tbFurnizori;
    }
}