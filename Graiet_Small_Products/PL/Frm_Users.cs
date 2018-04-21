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
    public partial class Frm_Users : Form
    {
        
        BL.Cls_User Users = new BL.Cls_User();
        public Frm_Users()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Users.Get_All_Users();
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            PL.Frm_ADD_Users Add_User = new Frm_ADD_Users();
            Add_User.ShowDialog();
            this.dataGridView1.DataSource = Users.Get_All_Users();
        }

        private void btnSupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Users.DELETE_USER(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Delete Done", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete not effected", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.dataGridView1.DataSource = Users.Get_All_Users();

        }
    }
}
