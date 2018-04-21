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
    public partial class Frm_Chauff : Form
    {
        BL.Cls_Chauffeur chauffeur = new BL.Cls_Chauffeur();
        private static Frm_Chauff frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Chauff getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Chauff();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                } return frm;
            }
        }
        public Frm_Chauff()
        {
            InitializeComponent();
            if (frm == null) frm = this;
            this.dataGridView1.DataSource = chauffeur.Get_All_Drivers();
        }


        private void btnAjoutChauffeur_Click(object sender, EventArgs e)
        {
            PL.Frm_Add_Chauffeur AddChauffeur=new PL.Frm_Add_Chauffeur();
            AddChauffeur.ShowDialog();
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModifierChauffeur_Click(object sender, EventArgs e)
        {
            Frm_Add_Chauffeur frmAddChauffeur = new Frm_Add_Chauffeur();
            frmAddChauffeur.idChauf =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmAddChauffeur.txtNomChauffeur.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmAddChauffeur.txtMatriculeChauffeur.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmAddChauffeur.txtNumeroTelChaufeur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            frmAddChauffeur.Text = "Modifier Chauffeur";
            frmAddChauffeur.btnValider.Text = "Modifier " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmAddChauffeur.state = "update";
            frmAddChauffeur.ShowDialog();
        }

        private void btnSupprimerChauffeur_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                chauffeur.Delete_Chauffeur(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Delete Done", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = chauffeur.Get_All_Drivers();
            }
            else
            {
                MessageBox.Show("Delete not effected", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
        }
    }
}
