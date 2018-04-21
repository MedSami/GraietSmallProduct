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
    public partial class Frm_Liste_Article : Form
    {
        BL.CLS_Articles clsArticle = new BL.CLS_Articles();
        public Frm_Liste_Article()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = clsArticle.Get_All_Product();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
