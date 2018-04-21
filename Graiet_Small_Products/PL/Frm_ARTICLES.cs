using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
namespace Graiet_Small_Products.PL
{
    public partial class Frm_ARTICLES : Form
    {
        BL.CLS_Articles cls_article = new BL.CLS_Articles();
        private static Frm_ARTICLES frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_ARTICLES getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_ARTICLES();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                } return frm;
            }
        }

        public Frm_ARTICLES()
        {
            InitializeComponent();
            if (frm == null) frm = this;
            this.dataGridView1.DataSource = cls_article.Get_All_Article();
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cls_article.SearchArticle(txtSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void btnAjoutArticle_Click(object sender, EventArgs e)
        {
            Frm_add_article frmAddArticle = new Frm_add_article();
            frmAddArticle.ShowDialog();
        }

        private void btnSupprimerArticle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_article.Delete_Article(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show("Delete Done", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cls_article.Get_All_Article();
            }else 
            {
                MessageBox.Show("Delete not effected", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModiferArticle_Click(object sender, EventArgs e)
        {
            Frm_add_article frmAddArticle = new Frm_add_article();
            frmAddArticle.txtReference.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmAddArticle.txtNameArticle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmAddArticle.txtQuantite.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmAddArticle.cmbCat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmAddArticle.Text = "Update Article";
            frmAddArticle.btnValider.Text = "Modifier " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmAddArticle.state = "update";
            frmAddArticle.OldQuantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            frmAddArticle.txtReference.ReadOnly = true;
            frmAddArticle.ShowDialog();
           
        }

        private void btnImpArticle_Click(object sender, EventArgs e)
        {
            Repport.Rpt_Article_Single myRpt = new Repport.Rpt_Article_Single();
            myRpt.SetParameterValue("@Ref", this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            Repport.Frm_Repport_Article MYRPT = new Repport.Frm_Repport_Article();
            MYRPT.crystalReportViewer1.ReportSource = myRpt;
            MYRPT.ShowDialog();
        }

        private void btnImpArticles_Click(object sender, EventArgs e)
        {
            PL.Frm_Inventaire inv = new Frm_Inventaire();
            inv.ShowDialog();
            /*Repport.Rpt_All_Articles myRpt = new Repport.Rpt_All_Articles();
           
            Repport.Frm_Repport_Article MYRPT = new Repport.Frm_Repport_Article();
            MYRPT.crystalReportViewer1.ReportSource = myRpt;
            MYRPT.crystalReportViewer1.RefreshReport();
            MYRPT.ShowDialog();*/
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Repport.Rpt_All_Articles myRpt = new Repport.Rpt_All_Articles();
            ExportOptions ExpOption = new ExportOptions();
            DiskFileDestinationOptions dfd = new DiskFileDestinationOptions();
            ExcelFormatOptions excelfo = new ExcelFormatOptions();
            dfd.DiskFileName = @"C:\graietArticles.xls";
            ExpOption = myRpt.ExportOptions;
            ExpOption.ExportDestinationType = ExportDestinationType.DiskFile;
            ExpOption.ExportFormatType = ExportFormatType.Excel;
            ExpOption.ExportFormatOptions = excelfo;
            ExpOption.ExportDestinationOptions = dfd;
            myRpt.Export();
            MessageBox.Show("Exported :)","good",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
