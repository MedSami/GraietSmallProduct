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
    public partial class Chauffeurs : Form
    {
        BL.Cls_Chauffeur chauf = new BL.Cls_Chauffeur();
        public Chauffeurs()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = chauf.Get_All_Drivers();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
