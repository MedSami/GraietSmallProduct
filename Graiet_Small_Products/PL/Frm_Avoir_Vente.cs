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
    public partial class Frm_Avoir_Vente : Form
    {
        PL.Frm_Avoir_Vente1 AV1 = new Frm_Avoir_Vente1();
        string Designation, Date, Qte, numeroBonSortie,AgentDeSaisi,NomChauf,Reference,NomClient,Vehicule,numeroClient,id_client;
        BL.Cls_Avoir Avoir = new BL.Cls_Avoir();

        public Frm_Avoir_Vente()
        {
            InitializeComponent();
        }

        private void txtNumBonSortie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int numBonDeSortie = 0 ;
            try
            {
                 numBonDeSortie = Convert.ToInt32(txtNumBonSortie.Text.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show("Verifier Numero Bon De sortie", " Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable Dt = Avoir.GET_ORDER_DETAILSForPrintAvoir(numBonDeSortie);
           
            DataTable Dt1 = Avoir.GET_ORDER_DETAILSForPrintAvoir(numBonDeSortie);
           
            DataSet ds = new DataSet();
          
           int s=Dt.Rows.Count;
           for (int i = 0; i < Dt.Rows.Count; i++)
           {
               //Designation, Date, Qte, numeroBonSortie,,,,,
               numeroBonSortie = Dt.Rows[i]["ID_ORDER"].ToString();
               
               Date = Dt.Rows[i]["Date_Order"].ToString();
              
               
               NomClient = Dt.Rows[i]["Name_Client"].ToString();
               Vehicule = Dt.Rows[i]["Vehicule"].ToString();
               NomChauf = Dt.Rows[i]["NomChauf"].ToString();
               AgentDeSaisi = Dt.Rows[i]["SalesMan"].ToString();
               numeroClient = Dt.Rows[i]["Numero_Client"].ToString();
               id_client = Dt.Rows[i]["ID_Clients"].ToString();
               /************************************************/
               Reference = Dt1.Rows[i]["Reference"].ToString();
               Designation = Dt1.Rows[i]["Name_Product"].ToString();
               Qte = Dt1.Rows[i]["Qte"].ToString();
               DataView view = new DataView(Dt1);
               DataTable table2 = view.ToTable(false, "Reference", "Name_Product", "Qte");
             
               AV1.dataGridView1.DataSource = table2;
           
           }
           AV1.txtDateLiv.Text = Date;
           AV1.txtNomClient.Text = NomClient;
           AV1.txtNumeroTel.Text = numeroClient;
           AV1.txtSalesMan.Text = AgentDeSaisi;
           AV1.txtNumBon.Text = numeroBonSortie;
           AV1.txtSearchChauf.Text = NomChauf;
           AV1.txtIdClient.Text = id_client;
           AV1.ShowDialog();
           this.Close();
          
            
        }
    }
}
