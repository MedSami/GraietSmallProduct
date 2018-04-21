namespace Graiet_Small_Products.PL
{
    partial class Frm_Settings_Server
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
            this.txtNomServer = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.rbSqlServer = new System.Windows.Forms.RadioButton();
            this.txtPss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Serveur :";
            // 
            // txtNomServer
            // 
            this.txtNomServer.Location = new System.Drawing.Point(128, 31);
            this.txtNomServer.Name = "txtNomServer";
            this.txtNomServer.Size = new System.Drawing.Size(191, 22);
            this.txtNomServer.TabIndex = 1;
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(128, 74);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(191, 22);
            this.txtBD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de donnée:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mode d\'accès :";
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Location = new System.Drawing.Point(118, 157);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(158, 19);
            this.rbWindows.TabIndex = 5;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Windows Authentication";
            this.rbWindows.UseVisualStyleBackColor = true;
            this.rbWindows.CheckedChanged += new System.EventHandler(this.rbWindows_CheckedChanged);
            // 
            // rbSqlServer
            // 
            this.rbSqlServer.AutoSize = true;
            this.rbSqlServer.Location = new System.Drawing.Point(118, 196);
            this.rbSqlServer.Name = "rbSqlServer";
            this.rbSqlServer.Size = new System.Drawing.Size(166, 19);
            this.rbSqlServer.TabIndex = 6;
            this.rbSqlServer.Text = "Sql Server Authentication";
            this.rbSqlServer.UseVisualStyleBackColor = true;
            this.rbSqlServer.CheckedChanged += new System.EventHandler(this.rbSqlServer_CheckedChanged);
            // 
            // txtPss
            // 
            this.txtPss.Location = new System.Drawing.Point(126, 289);
            this.txtPss.Name = "txtPss";
            this.txtPss.ReadOnly = true;
            this.txtPss.Size = new System.Drawing.Size(191, 22);
            this.txtPss.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mot de passe:";
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Location = new System.Drawing.Point(126, 246);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.ReadOnly = true;
            this.txtNomUtilisateur.Size = new System.Drawing.Size(191, 22);
            this.txtNomUtilisateur.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nom Utilisateur :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(63, 370);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(101, 36);
            this.btnEnregistrer.TabIndex = 11;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(175, 369);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(101, 36);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Frm_Settings_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 435);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtPss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomUtilisateur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbSqlServer);
            this.Controls.Add(this.rbWindows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomServer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Settings_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNomServer;
        public System.Windows.Forms.TextBox txtBD;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton rbWindows;
        public System.Windows.Forms.RadioButton rbSqlServer;
        public System.Windows.Forms.TextBox txtPss;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNomUtilisateur;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.Button btnAnnuler;
    }
}