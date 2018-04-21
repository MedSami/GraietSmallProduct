namespace Graiet_Small_Products.PL
{
    partial class Frm_ARTICLES
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSortir = new System.Windows.Forms.Button();
            this.btnImpArticles = new System.Windows.Forms.Button();
            this.btnSupprimerArticle = new System.Windows.Forms.Button();
            this.btnModiferArticle = new System.Windows.Forms.Button();
            this.btnAjoutArticle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(459, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(751, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Chercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Articles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSortir);
            this.groupBox2.Controls.Add(this.btnImpArticles);
            this.groupBox2.Controls.Add(this.btnSupprimerArticle);
            this.groupBox2.Controls.Add(this.btnModiferArticle);
            this.groupBox2.Controls.Add(this.btnAjoutArticle);
            this.groupBox2.Location = new System.Drawing.Point(22, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les operations";
            // 
            // btnSortir
            // 
            this.btnSortir.Location = new System.Drawing.Point(760, 33);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(198, 27);
            this.btnSortir.TabIndex = 6;
            this.btnSortir.Text = "Sortir";
            this.btnSortir.UseVisualStyleBackColor = true;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // 
            // btnImpArticles
            // 
            this.btnImpArticles.Location = new System.Drawing.Point(556, 33);
            this.btnImpArticles.Name = "btnImpArticles";
            this.btnImpArticles.Size = new System.Drawing.Size(198, 27);
            this.btnImpArticles.TabIndex = 4;
            this.btnImpArticles.Text = "Inventaire";
            this.btnImpArticles.UseVisualStyleBackColor = true;
            this.btnImpArticles.Click += new System.EventHandler(this.btnImpArticles_Click);
            // 
            // btnSupprimerArticle
            // 
            this.btnSupprimerArticle.Location = new System.Drawing.Point(384, 33);
            this.btnSupprimerArticle.Name = "btnSupprimerArticle";
            this.btnSupprimerArticle.Size = new System.Drawing.Size(162, 27);
            this.btnSupprimerArticle.TabIndex = 2;
            this.btnSupprimerArticle.Text = "Supprimer Article";
            this.btnSupprimerArticle.UseVisualStyleBackColor = true;
            this.btnSupprimerArticle.Click += new System.EventHandler(this.btnSupprimerArticle_Click);
            // 
            // btnModiferArticle
            // 
            this.btnModiferArticle.Location = new System.Drawing.Point(215, 33);
            this.btnModiferArticle.Name = "btnModiferArticle";
            this.btnModiferArticle.Size = new System.Drawing.Size(162, 27);
            this.btnModiferArticle.TabIndex = 1;
            this.btnModiferArticle.Text = "Modifier Article";
            this.btnModiferArticle.UseVisualStyleBackColor = true;
            this.btnModiferArticle.Click += new System.EventHandler(this.btnModiferArticle_Click);
            // 
            // btnAjoutArticle
            // 
            this.btnAjoutArticle.Location = new System.Drawing.Point(46, 33);
            this.btnAjoutArticle.Name = "btnAjoutArticle";
            this.btnAjoutArticle.Size = new System.Drawing.Size(162, 27);
            this.btnAjoutArticle.TabIndex = 0;
            this.btnAjoutArticle.Text = "Ajouter Nouveau Article";
            this.btnAjoutArticle.UseVisualStyleBackColor = true;
            this.btnAjoutArticle.Click += new System.EventHandler(this.btnAjoutArticle_Click);
            // 
            // Frm_ARTICLES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Frm_ARTICLES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTICLES";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSortir;
        private System.Windows.Forms.Button btnImpArticles;
        private System.Windows.Forms.Button btnSupprimerArticle;
        private System.Windows.Forms.Button btnModiferArticle;
        private System.Windows.Forms.Button btnAjoutArticle;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}