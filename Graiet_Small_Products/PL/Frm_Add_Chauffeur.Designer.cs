namespace Graiet_Small_Products.PL
{
    partial class Frm_Add_Chauffeur
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
            this.txtNomChauffeur = new System.Windows.Forms.TextBox();
            this.txtMatriculeChauffeur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroTelChaufeur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSortir = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom & Prenom";
            // 
            // txtNomChauffeur
            // 
            this.txtNomChauffeur.Location = new System.Drawing.Point(123, 61);
            this.txtNomChauffeur.Name = "txtNomChauffeur";
            this.txtNomChauffeur.Size = new System.Drawing.Size(204, 20);
            this.txtNomChauffeur.TabIndex = 1;
            // 
            // txtMatriculeChauffeur
            // 
            this.txtMatriculeChauffeur.Location = new System.Drawing.Point(123, 106);
            this.txtMatriculeChauffeur.Name = "txtMatriculeChauffeur";
            this.txtMatriculeChauffeur.Size = new System.Drawing.Size(204, 20);
            this.txtMatriculeChauffeur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Martricule ";
            // 
            // txtNumeroTelChaufeur
            // 
            this.txtNumeroTelChaufeur.Location = new System.Drawing.Point(123, 153);
            this.txtNumeroTelChaufeur.Name = "txtNumeroTelChaufeur";
            this.txtNumeroTelChaufeur.Size = new System.Drawing.Size(204, 20);
            this.txtNumeroTelChaufeur.TabIndex = 5;
            this.txtNumeroTelChaufeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelChaufeur_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Tel";
            // 
            // btnSortir
            // 
            this.btnSortir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortir.Location = new System.Drawing.Point(189, 220);
            this.btnSortir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(171, 45);
            this.btnSortir.TabIndex = 7;
            this.btnSortir.Text = "Sortir";
            this.btnSortir.UseVisualStyleBackColor = true;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(10, 220);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(171, 45);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // Frm_Add_Chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 281);
            this.Controls.Add(this.btnSortir);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtNumeroTelChaufeur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatriculeChauffeur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomChauffeur);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Add_Chauffeur";
            this.Text = "rm_Add_Chauffeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNomChauffeur;
        public System.Windows.Forms.TextBox txtMatriculeChauffeur;
        public System.Windows.Forms.TextBox txtNumeroTelChaufeur;
        public System.Windows.Forms.Button btnSortir;
        public System.Windows.Forms.Button btnValider;
    }
}