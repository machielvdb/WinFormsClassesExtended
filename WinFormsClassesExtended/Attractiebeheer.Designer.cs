namespace WinFormsClassesExtended
{
    partial class Attractiebeheer
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
            this.lbAttracties = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblKleur = new System.Windows.Forms.Label();
            this.lblMinLeeftijd = new System.Windows.Forms.Label();
            this.lblMaxLeetijd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAttracties
            // 
            this.lbAttracties.FormattingEnabled = true;
            this.lbAttracties.Location = new System.Drawing.Point(13, 13);
            this.lbAttracties.Name = "lbAttracties";
            this.lbAttracties.Size = new System.Drawing.Size(120, 212);
            this.lbAttracties.TabIndex = 0;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(140, 13);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(140, 42);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(140, 71);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderen.TabIndex = 3;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(139, 97);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(0, 13);
            this.lblNaam.TabIndex = 4;
            // 
            // lblKleur
            // 
            this.lblKleur.AutoSize = true;
            this.lblKleur.Location = new System.Drawing.Point(139, 110);
            this.lblKleur.Name = "lblKleur";
            this.lblKleur.Size = new System.Drawing.Size(0, 13);
            this.lblKleur.TabIndex = 5;
            // 
            // lblMinLeeftijd
            // 
            this.lblMinLeeftijd.AutoSize = true;
            this.lblMinLeeftijd.Location = new System.Drawing.Point(139, 123);
            this.lblMinLeeftijd.Name = "lblMinLeeftijd";
            this.lblMinLeeftijd.Size = new System.Drawing.Size(0, 13);
            this.lblMinLeeftijd.TabIndex = 6;
            // 
            // lblMaxLeetijd
            // 
            this.lblMaxLeetijd.AutoSize = true;
            this.lblMaxLeetijd.Location = new System.Drawing.Point(139, 136);
            this.lblMaxLeetijd.Name = "lblMaxLeetijd";
            this.lblMaxLeetijd.Size = new System.Drawing.Size(0, 13);
            this.lblMaxLeetijd.TabIndex = 7;
            // 
            // Attractiebeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 248);
            this.Controls.Add(this.lblMaxLeetijd);
            this.Controls.Add(this.lblMinLeeftijd);
            this.Controls.Add(this.lblKleur);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lbAttracties);
            this.Name = "Attractiebeheer";
            this.Text = "Attractiebeheer";
            this.Load += new System.EventHandler(this.Attractiebeheer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAttracties;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblKleur;
        private System.Windows.Forms.Label lblMinLeeftijd;
        private System.Windows.Forms.Label lblMaxLeetijd;
    }
}