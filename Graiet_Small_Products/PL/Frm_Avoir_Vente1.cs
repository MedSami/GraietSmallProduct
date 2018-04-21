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
    public partial class Frm_Avoir_Vente1 : Form
    {
        BL.Cls_Orders order = new BL.Cls_Orders();
        DataTable dt = new DataTable();
       
        void CreateDataTable()
        {
            dt.Columns.Add("Référence");
            dt.Columns.Add("Désignation");
            dt.Columns.Add("Quantité");
            dataGridView1.DataSource = dt;
        }
        void ClearData()
        {
            ClearBox();
            txtDateLiv.Clear();
            txtIdClient.Clear();
            txtNomClient.Clear();
           // txtNumBon.Clear();
            txtNumeroTel.Clear();
            txtSalesMan.Clear();
            txtSearchChauf.Clear();
            dt.Clear();
            dataGridView1.DataSource = null;

            btnImprimer.Enabled = true;
            btnEnregistrer.Enabled = false;

        }
    /*    void ResizeDGV()
        {
            this.dataGridView1.RowHeadersWidth = 36;
            this.dataGridView1.Columns[0].Width = 132;
            this.dataGridView1.Columns[1].Width = 421;
            this.dataGridView1.Columns[2].Width = 148;
        }
        */
        public Frm_Avoir_Vente1()
        {
            InitializeComponent();
            CreateDataTable();
           // ResizeDGV();
        }

        void ClearBox()
        {
            txtQte.Clear();
            txtRef.Clear();
            txtDesignation.Clear();
            //btnBrowse.Focus();
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtQte.Text.Trim()))
                {
                    MessageBox.Show("Saisie Quantite", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

              /*  if (order.VERIF_QT(Convert.ToInt32(txtRef.Text), Convert.ToInt32(txtQte.Text)).Rows.Count < 1)
                {
                    MessageBox.Show(" Stock Non DISPONIBLE", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtRef.Text)
                    {
                        MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString() + " Exist deja", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ClearBox();
                        return;
                    }

                }
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = txtRef.Text; ;
                row.Cells[1].Value = txtDesignation.Text; ;
                row.Cells[2].Value = txtQte.Text;
                dataGridView1.Rows.Add(row);
               */
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                DataRow drToAdd = dataTable.NewRow();

                drToAdd[0] = txtRef.Text;
                drToAdd[1] = txtDesignation.Text;
                drToAdd[2] = txtQte.Text;
                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
                ClearBox();
          
                
            }
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtDesignation.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                txtQte.Focus();
            }
            catch
            {
                return;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (txtNumeroTel.Text == string.Empty || txtSearchChauf.Text == string.Empty || dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Remplir TT les champs SVP", " Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            order.Add_Order_Avoir_Vente(txtDateLiv.Text, Convert.ToInt32(txtIdClient.Text), Convert.ToInt32(txtNumBon.Text), txtSalesMan.Text, txtSearchChauf.Text);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                order.ADD_ORDER_DETAILS_Avoir_Vente(Convert.ToInt32(this.dataGridView1.Rows[i].Cells[0].Value.ToString()), Convert.ToInt32(txtNumBon.Text),
                    Convert.ToInt32(this.dataGridView1.Rows[i].Cells[2].Value.ToString()));
            {
            }
            MessageBox.Show("Enregistrement terminer avec succée", " Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            int IDORDER = Convert.ToInt32(order.Get_last_Num_OrderForPrintAvoirVente().Rows[0][0]);

            Repport.AvoirVente Rpt_Orders = new Repport.AvoirVente();
            Repport.Frm_Repport_Article frmRepport = new Repport.Frm_Repport_Article();
            Rpt_Orders.SetDataSource(order.GET_ORDER_DETAILSForPrint_Avoir_Vente(IDORDER));
            frmRepport.crystalReportViewer1.ReportSource = Rpt_Orders;
            frmRepport.ShowDialog();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aucun Article selectionner", " Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            PL.Frm_Custmers frmCust = new Frm_Custmers();
            frmCust.ShowDialog();
            this.txtIdClient.Text = frmCust.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtNomClient.Text = frmCust.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.txtNumeroTel.Text = frmCust.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.txtDateLiv.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void btnSearchChauf_Click(object sender, EventArgs e)
        {

            PL.Chauffeurs frmChauf = new PL.Chauffeurs();
            frmChauf.ShowDialog();
            this.txtSearchChauf.Text = frmChauf.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumeroTel.Text == string.Empty || txtSearchChauf.Text == string.Empty || dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Remplir TT les champs SVP", " Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            order.Modifier_bon_sortie(txtDateLiv.Text, Convert.ToInt32(txtIdClient.Text), Convert.ToInt32(txtNumBon.Text), txtSalesMan.Text, txtSearchChauf.Text);
          
            MessageBox.Show("Modification terminer avec succée", " Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
