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
    public partial class Frm_Add_Chauffeur : Form
    {
        public string state = "add";
        public int idChauf;
        BL.Cls_Chauffeur Chauffeur = new BL.Cls_Chauffeur();
        public Frm_Add_Chauffeur()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                if (txtNomChauffeur.TextLength == 0)
                {
                    MessageBox.Show("Saisi Nom & Prenom Obligatoire", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomChauffeur.Focus();
                }
                else if (txtMatriculeChauffeur.TextLength == 0)
                {
                    MessageBox.Show("Saisi Matricule Obligatoire", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatriculeChauffeur.Focus();
                }
                else if (txtNumeroTelChaufeur.TextLength == 0)
                {
                    MessageBox.Show("Saisi Numero Tel Obligatoire", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumeroTelChaufeur.Focus();
                }
                else
                {
                    Chauffeur.Add_Chauffeur(txtNomChauffeur.Text, Convert.ToInt32(txtNumeroTelChaufeur.Text), txtMatriculeChauffeur.Text);
                    MessageBox.Show("Terminer avec succée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Chauffeur.Update_Chauffeur(idChauf, txtNomChauffeur.Text, Convert.ToInt32(txtNumeroTelChaufeur.Text), txtMatriculeChauffeur.Text);

            }
            Frm_Chauff.getMainForm.dataGridView1.DataSource = Chauffeur.Get_All_Drivers();


           
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumeroTelChaufeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
