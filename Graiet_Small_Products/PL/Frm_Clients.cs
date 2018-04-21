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
    public partial class Frm_Clients : Form
    {
        BL.Cls_Custmers Client = new BL.Cls_Custmers();
        public Frm_Clients()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Client.Get_All_Custmer();
        }

        private void btnAjoutClient_Click(object sender, EventArgs e)
        {
            Frm_Add_Client addClient = new Frm_Add_Client();
            addClient.ShowDialog();
            this.dataGridView1.DataSource = Client.Get_All_Custmer();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Client.DeleteClient(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                MessageBox.Show("Delete Done", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete not effected", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.dataGridView1.DataSource = Client.Get_All_Custmer();
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
