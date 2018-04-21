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
    public partial class Frm_ADD_Users : Form
    {
        PL.Frm_Users GridUser = new Frm_Users();
        BL.Cls_User Cls_User = new BL.Cls_User();
        public Frm_ADD_Users()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNom.Text.Trim()))
            {
                MessageBox.Show("Saisie Nom", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNom.Focus();
                return;
            }
           
            if (String.IsNullOrEmpty(txtPss.Text.Trim()))
            {
                MessageBox.Show("Saisie Mot de passe", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPss.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNumTel.Text.Trim()))
            {
                MessageBox.Show("Saisie Num Tel", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumTel.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtType.Text.Trim()))
            {
                MessageBox.Show("Saisie Type utilisateur", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtType.Focus();
                return;
            } 
            Cls_User.ADD_USER(txtNom.Text, txtPss.Text, txtNumTel.Text, txtType.Text);
            MessageBox.Show("Terminer avec succée","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
           // GridUser.dataGridView1.DataSource = Cls_User.Get_All_Users();
        }

        private void txtNumTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
        {
                            
              //  txtType.CharacterCasing = CharacterCasing.Upper;
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
            
        }
    }
}
