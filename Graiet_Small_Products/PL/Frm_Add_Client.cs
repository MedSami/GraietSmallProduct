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
    public partial class Frm_Add_Client : Form
    {
        BL.Cls_Custmers Clients = new BL.Cls_Custmers();
        public Frm_Add_Client()
        {
            InitializeComponent();
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Clients.ADD_CLIENT(txtNom.Text, txtNumTel.Text);
            MessageBox.Show("Terminer avec succée","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        
        }
    }
}
