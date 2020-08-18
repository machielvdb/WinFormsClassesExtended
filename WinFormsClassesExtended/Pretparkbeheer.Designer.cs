namespace WinFormsClassesExtended
{
    partial class Pretparkbeheer
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
            this.btnWerknemers = new System.Windows.Forms.Button();
            this.btnAttracties = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWerknemers
            // 
            this.btnWerknemers.Location = new System.Drawing.Point(12, 25);
            this.btnWerknemers.Name = "btnWerknemers";
            this.btnWerknemers.Size = new System.Drawing.Size(96, 23);
            this.btnWerknemers.TabIndex = 0;
            this.btnWerknemers.Text = "Werknemers";
            this.btnWerknemers.UseVisualStyleBackColor = true;
            this.btnWerknemers.Click += new System.EventHandler(this.btnWerknemers_Click);
            // 
            // btnAttracties
            // 
            this.btnAttracties.Location = new System.Drawing.Point(12, 54);
            this.btnAttracties.Name = "btnAttracties";
            this.btnAttracties.Size = new System.Drawing.Size(96, 23);
            this.btnAttracties.TabIndex = 1;
            this.btnAttracties.Text = "Attracties";
            this.btnAttracties.UseVisualStyleBackColor = true;
            this.btnAttracties.Click += new System.EventHandler(this.btnAttracties_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(40, 9);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(0, 13);
            this.lblNaam.TabIndex = 2;
            // 
            // Pretparkbeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 111);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnAttracties);
            this.Controls.Add(this.btnWerknemers);
            this.Name = "Pretparkbeheer";
            this.Text = "Pretparkbeheer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWerknemers;
        private System.Windows.Forms.Button btnAttracties;
        private System.Windows.Forms.Label lblNaam;
    }
}