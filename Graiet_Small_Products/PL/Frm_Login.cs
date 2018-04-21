using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graiet_Small_Products.PL
{
    public partial class Frm_Login : Form
    {
        BL.CLS_Login log = new BL.CLS_Login();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        { if (txt_name.Text.Length==0){
            MessageBox.Show("Champ Nom est vide !!");
            txt_name.Focus();
            return;
        } if (txt_password.Text.Length == 0)
        {
            MessageBox.Show("Champ Password est vide !!");
            txt_password.Focus();
            return;
        }
            DataTable dt = log.Login(txt_name.Text, txt_password.Text);
            if (dt.Rows.Count > 0 && Convert.ToString(dt.Rows[0][4]) == "ADMIN")
            {
                Frm_Main.getMainForm.utilisateursToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.articlesToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.categorieToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.clientsToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.collerBdToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.copierBDToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.chauffeursToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.avoirToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.gestionDuChauffeurToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.bonDeSortieToolStripMenuItem.Enabled = true;
                Program.SalesMan = dt.Rows[0]["Name_User"].ToString();
                this.Close();
            }
            else if (dt.Rows.Count > 0 && Convert.ToString(dt.Rows[0][4]) == "USER")
            {
               // Frm_Main.getMainForm.utilisateursToolStripMenuItem.Enabled = true;
               // Frm_Main.getMainForm.articlesToolStripMenuItem.Enabled = true;
               // Frm_Main.getMainForm.categorieToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.clientsToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.gestionCommandeToolStripMenuItem.Visible = true;
                Frm_Main.getMainForm.gestionClientsToolStripMenuItem.Visible = false;
               // Frm_Main.getMainForm.collerBdToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.copierBDToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.fichierToolStripMenuItem.Enabled = true;
                Frm_Main.getMainForm.settingsServerConnectionToolStripMenuItem.Visible = false;

                Program.SalesMan = dt.Rows[0]["Name_User"].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Not Connected");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
