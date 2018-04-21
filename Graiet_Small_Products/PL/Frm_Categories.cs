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
    public partial class Frm_Categories : Form
    {
        BL.Cls_Categories clsCategorie = new BL.Cls_Categories();
       // BL.CLS_Articles cls_article = new BL.CLS_Articles();
        private static Frm_Categories frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Categories getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Categories();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                } return frm;
            }
        }



        BL.Cls_Categories clsCategories = new BL.Cls_Categories();
        public Frm_Categories()
        {
            InitializeComponent();
            if (frm == null) frm = this;
            this.dataGridView1.DataSource = clsCategories.Get_All_Categories();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           
            Frm_Add_Categorie frmAddCategire = new Frm_Add_Categorie();
            frmAddCategire.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure", "!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                clsCategorie.Delete_Categorie(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show("Delete Done", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = clsCategories.Get_All_Categories();
            }
            else
            {
                MessageBox.Show("Delete not effected", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
