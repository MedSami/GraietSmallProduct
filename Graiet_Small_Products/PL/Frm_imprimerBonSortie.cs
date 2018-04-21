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
    public partial class Frm_imprimerBonSortie : Form
    {
        BL.Cls_Orders order = new BL.Cls_Orders();
        public Frm_imprimerBonSortie()
        {
            InitializeComponent();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            int IDORDER = Convert.ToInt32(txtNumeroBonDeSortie.Text);

            Repport.RptOrders Rpt_Orders = new Repport.RptOrders();
            Repport.Frm_Repport_Article frmRepport = new Repport.Frm_Repport_Article();
            Rpt_Orders.SetDataSource(order.GET_ORDER_DETAILSForPrint(IDORDER));
            frmRepport.crystalReportViewer1.ReportSource = Rpt_Orders;
            frmRepport.ShowDialog();

            this.Close();
        }

        private void txtNumeroBonDeSortie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
