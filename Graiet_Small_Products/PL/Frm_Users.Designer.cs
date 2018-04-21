namespace Graiet_Small_Products.PL
{
    partial class Frm_Users
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSortir = new System.Windows.Forms.Button();
            this.btnSupprimerUtilisateur = new System.Windows.Forms.Button();
            this.btnAjoutUtilisateur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSortir);
            this.groupBox2.Controls.Add(this.btnSupprimerUtilisateur);
            this.groupBox2.Controls.Add(this.btnAjoutUtilisateur);
            this.groupBox2.Location = new System.Drawing.Point(22, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1203, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les operations";
            // 
            // btnSortir
            // 
            this.btnSortir.Location = new System.Drawing.Point(896, 39);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(231, 48);
            this.btnSortir.TabIndex = 2;
            this.btnSortir.Text = "Sortir";
            this.btnSortir.UseVisualStyleBackColor = true;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // 
            // btnSupprimerUtilisateur
            // 
            this.btnSupprimerUtilisateur.Location = new System.Drawing.Point(586, 39);
            this.btnSupprimerUtilisateur.Name = "btnSupprimerUtilisateur";
            this.btnSupprimerUtilisateur.Size = new System.Drawing.Size(189, 48);
            this.btnSupprimerUtilisateur.TabIndex = 1;
            this.btnSupprimerUtilisateur.Text = "Supprimer Utilisateur";
            this.btnSupprimerUtilisateur.UseVisualStyleBackColor = true;
            this.btnSupprimerUtilisateur.Click += new System.EventHandler(this.btnSupprimerUtilisateur_Click);
            // 
            // btnAjoutUtilisateur
            // 
            this.btnAjoutUtilisateur.Location = new System.Drawing.Point(276, 39);
            this.btnAjoutUtilisateur.Name = "btnAjoutUtilisateur";
            this.btnAjoutUtilisateur.Size = new System.Drawing.Size(189, 48);
            this.btnAjoutUtilisateur.TabIndex = 0;
            this.btnAjoutUtilisateur.Text = "Ajouter Nouveau Utilisateur";
            this.btnAjoutUtilisateur.UseVisualStyleBackColor = true;
            this.btnAjoutUtilisateur.Click += new System.EventHandler(this.btnAjoutUtilisateur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(14, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1219, 328);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les ClientClients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Frm_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Users";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSortir;
        private System.Windows.Forms.Button btnSupprimerUtilisateur;
        private System.Windows.Forms.Button btnAjoutUtilisateur;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}