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
    public partial class Frm_Inventaire : Form
    {
        BL.CLS_Articles cls_artc = new BL.CLS_Articles();
        public Frm_Inventaire()
        {
            InitializeComponent();
            comboBox1.DataSource = cls_artc.Get_All_Categories();
            comboBox1.DisplayMember = "Name_Categorie";
            comboBox1.ValueMember = "ID_Categorie";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            Repport.RPT_Inventaire myRpt = new Repport.RPT_Inventaire();
            myRpt.SetParameterValue("@nomCat", selected);
            Repport.Frm_Repport_Article MYRPT = new Repport.Frm_Repport_Article();
            MYRPT.crystalReportViewer1.ReportSource = myRpt;
            MYRPT.ShowDialog();
        }
    }
}
