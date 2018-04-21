namespace Graiet_Small_Products.PL
{
    partial class Frm_Add_Client
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
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.btnSortir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(58, 173);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(171, 45);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero Tel :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(158, 60);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(202, 22);
            this.txtNom.TabIndex = 0;
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(161, 111);
            this.txtNumTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(202, 22);
            this.txtNumTel.TabIndex = 1;
            // 
            // btnSortir
            // 
            this.btnSortir.Location = new System.Drawing.Point(237, 173);
            this.btnSortir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(171, 45);
            this.btnSortir.TabIndex = 3;
            this.btnSortir.Text = "Sortir";
            this.btnSortir.UseVisualStyleBackColor = true;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // 
            // Frm_Add_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 271);
            this.Controls.Add(this.btnSortir);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Add_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Button btnSortir;
    }
}