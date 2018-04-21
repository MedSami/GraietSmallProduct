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
    public partial class ListeArticlesModifier : Form
    {
        BL.CLS_Articles clsArticle = new BL.CLS_Articles();
        public ListeArticlesModifier()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = clsArticle.GET_ALL_Article_Modified();
            this.dataGridView1.Columns[0].Visible = false;
            //this.dataGridView1.Columns[4].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
