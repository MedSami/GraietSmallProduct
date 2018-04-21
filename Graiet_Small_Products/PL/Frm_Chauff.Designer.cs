namespace Graiet_Small_Products.PL
{
    partial class Frm_Chauff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifierChauffeur = new System.Windows.Forms.Button();
            this.btnSortir = new System.Windows.Forms.Button();
            this.btnSupprimerChauffeur = new System.Windows.Forms.Button();
            this.btnAjoutChauffeur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(899, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifierChauffeur);
            this.groupBox2.Controls.Add(this.btnSortir);
            this.groupBox2.Controls.Add(this.btnSupprimerChauffeur);
            this.groupBox2.Controls.Add(this.btnAjoutChauffeur);
            this.groupBox2.Location = new System.Drawing.Point(19, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les operations";
            // 
            // btnModifierChauffeur
            // 
            this.btnModifierChauffeur.Location = new System.Drawing.Point(241, 33);
            this.btnModifierChauffeur.Name = "btnModifierChauffeur";
            this.btnModifierChauffeur.Size = new System.Drawing.Size(162, 42);
            this.btnModifierChauffeur.TabIndex = 3;
            this.btnModifierChauffeur.Text = "Modifier Chauffeur";
            this.btnModifierChauffeur.UseVisualStyleBackColor = true;
            this.btnModifierChauffeur.Click += new System.EventHandler(this.btnModifierChauffeur_Click);
            // 
            // btnSortir
            // 
            this.btnSortir.Location = new System.Drawing.Point(677, 33);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(198, 42);
            this.btnSortir.TabIndex = 2;
            this.btnSortir.Text = "Sortir";
            this.btnSortir.UseVisualStyleBackColor = true;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // 
            // btnSupprimerChauffeur
            // 
            this.btnSupprimerChauffeur.Location = new System.Drawing.Point(459, 33);
            this.btnSupprimerChauffeur.Name = "btnSupprimerChauffeur";
            this.btnSupprimerChauffeur.Size = new System.Drawing.Size(162, 42);
            this.btnSupprimerChauffeur.TabIndex = 1;
            this.btnSupprimerChauffeur.Text = "Supprimer Chauffeur";
            this.btnSupprimerChauffeur.UseVisualStyleBackColor = true;
            this.btnSupprimerChauffeur.Click += new System.EventHandler(this.btnSupprimerChauffeur_Click);
            // 
            // btnAjoutChauffeur
            // 
            this.btnAjoutChauffeur.Location = new System.Drawing.Point(20, 33);
            this.btnAjoutChauffeur.Name = "btnAjoutChauffeur";
            this.btnAjoutChauffeur.Size = new System.Drawing.Size(162, 42);
            this.btnAjoutChauffeur.TabIndex = 0;
            this.btnAjoutChauffeur.Text = "Ajouter Nouveau Chauffeur";
            this.btnAjoutChauffeur.UseVisualStyleBackColor = true;
            this.btnAjoutChauffeur.Click += new System.EventHandler(this.btnAjoutChauffeur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 272);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Chauffeurs";
            // 
            // Frm_Chauff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Chauff";
            this.Text = "Frm_Chauff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModifierChauffeur;
        private System.Windows.Forms.Button btnSortir;
        private System.Windows.Forms.Button btnSupprimerChauffeur;
        private System.Windows.Forms.Button btnAjoutChauffeur;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}