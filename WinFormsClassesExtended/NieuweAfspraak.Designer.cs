namespace WinFormsClassesExtended
{
    partial class NieuweAfspraak
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReden = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpUur = new System.Windows.Forms.DateTimePicker();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reden";
            // 
            // tbReden
            // 
            this.tbReden.Location = new System.Drawing.Point(49, 64);
            this.tbReden.Name = "tbReden";
            this.tbReden.Size = new System.Drawing.Size(200, 20);
            this.tbReden.TabIndex = 5;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(49, 12);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 6;
            // 
            // dtpUur
            // 
            this.dtpUur.Location = new System.Drawing.Point(49, 38);
            this.dtpUur.Name = "dtpUur";
            this.dtpUur.Size = new System.Drawing.Size(200, 20);
            this.dtpUur.TabIndex = 7;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(11, 90);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(238, 23);
            this.btnToevoegen.TabIndex = 8;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // NieuweAfspraak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 121);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.dtpUur);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbReden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NieuweAfspraak";
            this.Text = "NieuweAfspraak";
            this.Load += new System.EventHandler(this.NieuweAfspraak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReden;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpUur;
        private System.Windows.Forms.Button btnToevoegen;
    }
}