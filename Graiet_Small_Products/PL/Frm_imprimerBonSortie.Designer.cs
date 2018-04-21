namespace Graiet_Small_Products.PL
{
    partial class Frm_imprimerBonSortie
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
            this.btnImprimer = new System.Windows.Forms.Button();
            this.txtNumeroBonDeSortie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(254, 25);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(95, 38);
            this.btnImprimer.TabIndex = 0;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // txtNumeroBonDeSortie
            // 
            this.txtNumeroBonDeSortie.Location = new System.Drawing.Point(44, 35);
            this.txtNumeroBonDeSortie.Name = "txtNumeroBonDeSortie";
            this.txtNumeroBonDeSortie.Size = new System.Drawing.Size(204, 20);
            this.txtNumeroBonDeSortie.TabIndex = 1;
            this.txtNumeroBonDeSortie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroBonDeSortie_KeyPress);
            // 
            // Frm_imprimerBonSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 83);
            this.Controls.Add(this.txtNumeroBonDeSortie);
            this.Controls.Add(this.btnImprimer);
            this.MaximizeBox = false;
            this.Name = "Frm_imprimerBonSortie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimer Bon De Sortie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.TextBox txtNumeroBonDeSortie;
    }
}