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
    public partial class Frm_Add_Categorie : Form
    {
        BL.Cls_Categories clsCategorie = new BL.Cls_Categories();
        public Frm_Add_Categorie()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtCategorie.Text.Length.Equals(0)) {
                MessageBox.Show("Champ Categorie Vide !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategorie.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = clsCategorie.VerifCategorie(txtCategorie.Text);
            if (dt.Rows.Count > 0)
            { MessageBox.Show("Categorie deja exist", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                clsCategorie.Add_Categorie(txtCategorie.Text);
                MessageBox.Show("Ajout terminer avec succée", "Ajout Categorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_Categories.getMainForm.dataGridView1.DataSource = clsCategorie.Get_All_Categories();
            }
        }
    }
}
