namespace WinFormsClassesExtended
{
    partial class Personeelbeheer
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
            this.lbWerknemers = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblGeslacht = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWerknemers
            // 
            this.lbWerknemers.FormattingEnabled = true;
            this.lbWerknemers.Location = new System.Drawing.Point(12, 12);
            this.lbWerknemers.Name = "lbWerknemers";
            this.lbWerknemers.Size = new System.Drawing.Size(130, 160);
            this.lbWerknemers.TabIndex = 0;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(150, 13);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Nieuw";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(150, 43);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(150, 73);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderen.TabIndex = 3;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(148, 99);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(0, 13);
            this.lblNaam.TabIndex = 4;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(148, 121);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 13);
            this.lblDatum.TabIndex = 5;
            // 
            // lblGeslacht
            // 
            this.lblGeslacht.AutoSize = true;
            this.lblGeslacht.Location = new System.Drawing.Point(148, 144);
            this.lblGeslacht.Name = "lblGeslacht";
            this.lblGeslacht.Size = new System.Drawing.Size(0, 13);
            this.lblGeslacht.TabIndex = 6;
            // 
            // Personeelbeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 186);
            this.Controls.Add(this.lblGeslacht);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lbWerknemers);
            this.Name = "Personeelbeheer";
            this.Text = "Personeelbeheer";
            this.Load += new System.EventHandler(this.Personeelbeheer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWerknemers;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblGeslacht;
    }
}