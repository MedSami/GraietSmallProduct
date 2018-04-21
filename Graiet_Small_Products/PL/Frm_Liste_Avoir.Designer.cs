namespace Graiet_Small_Products.PL
{
    partial class Frm_Liste_Avoir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAvoir = new System.Windows.Forms.Button();
            this.btnSortie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecherche);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Avoirs";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(31, 36);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(179, 20);
            this.txtRecherche.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAvoir
            // 
            this.btnAvoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvoir.Location = new System.Drawing.Point(302, 123);
            this.btnAvoir.Name = "btnAvoir";
            this.btnAvoir.Size = new System.Drawing.Size(104, 38);
            this.btnAvoir.TabIndex = 1;
            this.btnAvoir.Text = "Avoir";
            this.btnAvoir.UseVisualStyleBackColor = true;
            // 
            // btnSortie
            // 
            this.btnSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortie.Location = new System.Drawing.Point(302, 167);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(104, 38);
            this.btnSortie.TabIndex = 2;
            this.btnSortie.Text = "Bon de Sortie";
            this.btnSortie.UseVisualStyleBackColor = true;
            // 
            // Frm_Liste_Avoir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 496);
            this.Controls.Add(this.btnSortie);
            this.Controls.Add(this.btnAvoir);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_Liste_Avoir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Liste_Avoir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtRecherche;
        public System.Windows.Forms.Button btnAvoir;
        public System.Windows.Forms.Button btnSortie;
    }
}