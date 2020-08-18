namespace WinFormsClassesExtended
{
    partial class NieuweWerknemer
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.gbGeslacht.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(63, 9);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(200, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(63, 36);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 1;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(13, 9);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Text = "Naam";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(13, 37);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum";
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.Location = new System.Drawing.Point(16, 62);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(121, 55);
            this.gbGeslacht.TabIndex = 5;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht";
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(58, 19);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 1;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(6, 19);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 0;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(143, 62);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(116, 55);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // NieuweWerknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 122);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbNaam);
            this.Name = "NieuweWerknemer";
            this.Text = "NieuweWerknemer";
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.Button btnToevoegen;
    }
}