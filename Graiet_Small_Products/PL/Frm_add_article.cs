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
    public partial class Frm_add_article : Form
    {
        public string state = "add";
        public int OldQuantity;
           BL.CLS_Articles cls_artc = new BL.CLS_Articles();
           PL.Frm_ARTICLES Article = new Frm_ARTICLES();
        public Frm_add_article()
        {
            InitializeComponent();
            cmbCat.DataSource = cls_artc.Get_All_Categories();
            cmbCat.DisplayMember = "Name_Categorie";
            cmbCat.ValueMember = "ID_Categorie";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int Qt;
         
            if (state == "add")
            {
                if (txtReference.Text.Length.Equals(0)){
                MessageBox.Show("Champ Reference est vide !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReference.Focus();
                return;
                } if (txtNameArticle.Text.Length.Equals(0))
                {
                    MessageBox.Show("Champ Nom Article est vide !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNameArticle.Focus();
                    return;
                } if (txtQuantite.Text.Length.Equals(0))
                {
                    MessageBox.Show("Champ Quantité est vide !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantite.Focus();
                    return;
                } 
                cls_artc.Add_Article(txtNameArticle.Text, Convert.ToInt32(txtReference.Text),
                    Convert.ToInt32(txtQuantite.Text), Convert.ToInt32(cmbCat.SelectedValue));
                Article.dataGridView1.DataSource = cls_artc.Get_All_Article();
                MessageBox.Show("Add Completed", "Ajout Article", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                  if (txtReference.Text.Length.Equals(0)){
                MessageBox.Show("Champ Reference est vide !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReference.Focus();
                return;
                } if (txtNameArticle.Text.Length.Equals(0))
                {
                    MessageBox.Show("Champ Nom Article est vide !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNameArticle.Focus();
                    return;
                } if (txtQuantite.Text.Length.Equals(0))
                {
                    MessageBox.Show("Champ Quantité est vide !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantite.Focus();
                    return;
                }
                
                cls_artc.Update_Article(txtNameArticle.Text, Convert.ToInt32(txtReference.Text),
                        Convert.ToInt32(txtQuantite.Text), Convert.ToInt32(cmbCat.SelectedValue));
                Article.dataGridView1.DataSource = cls_artc.Get_All_Article();
                if (OldQuantity < Convert.ToInt32(txtQuantite.Text)) {
                     Qt = Convert.ToInt32(txtQuantite.Text) - OldQuantity;
                     cls_artc.Add_ArticleAvoirAchat(txtNameArticle.Text, txtReference.Text, Program.SalesMan,
                         Convert.ToInt32(txtQuantite.Text), "+"+Qt);
                }
                else if (OldQuantity > Convert.ToInt32(txtQuantite.Text))
                {
                     Qt = OldQuantity - Convert.ToInt32(txtQuantite.Text);
                     cls_artc.Add_ArticleAvoirAchat(txtNameArticle.Text, txtReference.Text, Program.SalesMan,
                         Convert.ToInt32(txtQuantite.Text), "-"+Qt);
                }
                else {
                     Qt = 0;
                     cls_artc.Add_ArticleAvoirAchat(txtNameArticle.Text, txtReference.Text, Program.SalesMan,
                         Convert.ToInt32(txtQuantite.Text), ""+Qt);
                }
                
              
            }
            Frm_ARTICLES.getMainForm.dataGridView1.DataSource = cls_artc.Get_All_Article();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void txtReference_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = cls_artc.VerifyRefArticle(Convert.ToInt32(txtReference.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Reference Deja Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReference.Focus();
                    txtReference.SelectionStart = 0;
                    txtReference.SelectionLength = txtReference.TextLength;
                }
            }
        }

        private void txtReference_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
        {
            e.Handled = true;
        }

        }

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
