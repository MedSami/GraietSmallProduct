namespace Graiet_Small_Products.PL
{
    partial class Frm_Clients
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
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnAjoutClient = new System.Windows.Forms.Button();
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
            this.groupBox2.Controls.Add(this.btnSupprimerClient);
            this.groupBox2.Controls.Add(this.btnAjoutClient);
            this.groupBox2.Location = new System.Drawing.Point(34, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 107);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les operations";
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
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(411, 33);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(162, 42);
            this.btnSupprimerClient.TabIndex = 1;
            this.btnSupprimerClient.Text = "Supprimer Client";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnAjoutClient
            // 
            this.btnAjoutClient.Location = new System.Drawing.Point(146, 33);
            this.btnAjoutClient.Name = "btnAjoutClient";
            this.btnAjoutClient.Size = new System.Drawing.Size(162, 42);
            this.btnAjoutClient.TabIndex = 0;
            this.btnAjoutClient.Text = "Ajouter Nouveau Client";
            this.btnAjoutClient.UseVisualStyleBackColor = true;
            this.btnAjoutClient.Click += new System.EventHandler(this.btnAjoutClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les ClientClients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // Frm_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Frm_Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSortir;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnAjoutClient;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}