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
    public partial class Frm_Custmers : Form
    {
        BL.Cls_Custmers cust = new BL.Cls_Custmers();
        public Frm_Custmers()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.Get_All_Custmer();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
