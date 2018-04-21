using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Graiet_Small_Products.BL
{
    class Cls_Orders
    {

        public DataTable Get_last_Num_Order()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_last_Num_Order", null);
            dal.Close();
            return dt;
        }
        public DataTable Get_last_Num_OrderForPrint()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_last_Num_OrderForPrint", null);
            dal.Close();
            return dt;
        }

        public DataTable Get_last_Num_OrderForPrintAvoirVente()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_last_Num_OrderForPrintAvoirVente", null);
            dal.Close();
            return dt;
        }
        public DataTable VERIF_QT(int reference,int qt)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@RefProduct", SqlDbType.Int);
            param[0].Value = reference;
            param[1] = new SqlParameter("@Qt", SqlDbType.Int);
            param[1].Value = qt;
            DataTable dt = new DataTable();
            dt = dal.SelectData("VERIF_QT", param);
            dal.Close();
            return dt;
        }

        public DataTable GET_ORDER_DETAILSForPrint(int id_order)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_O", SqlDbType.Int);
            param[0].Value = id_order;
            
            DataTable dt = new DataTable();
            dt = dal.SelectData("GET_ORDER_DETAILSForPrint", param);
            dal.Close();
            return dt;
        }
        public DataTable GET_ORDER_DETAILSForPrint_Avoir_Vente(int id_order)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_O", SqlDbType.Int);
            param[0].Value = id_order;

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_OrderPrintAvoirVente", param);
            dal.Close();
            return dt;
        }

        public void Add_Order(string Date_Order, int Id_Client, int Numero_Order, string SalesMan,string Nom_Chauffeur)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Date_Order", SqlDbType.VarChar, 50);
            param[0].Value = Date_Order;
            param[1] = new SqlParameter("@Id_Client", SqlDbType.Int);
            param[1].Value = Id_Client;
            param[2] = new SqlParameter("@Numero_Order", SqlDbType.Int);
            param[2].Value = Numero_Order;
            param[3] = new SqlParameter("@SalesMan", SqlDbType.VarChar, 50);
            param[3].Value = SalesMan;
            param[4] = new SqlParameter("@Nom_Chauf", SqlDbType.VarChar, 50);
            param[4].Value = Nom_Chauffeur;
            dal.ExcuteCommand("Add_Order", param);
            dal.Close();
        }

        public void Add_Order_Avoir_Vente(string Date_Order, int Id_Client, int Numero_Order, string SalesMan, string Nom_Chauffeur)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Date_Order", SqlDbType.VarChar, 50);
            param[0].Value = Date_Order;
            param[1] = new SqlParameter("@Id_Client", SqlDbType.Int);
            param[1].Value = Id_Client;
            param[2] = new SqlParameter("@Numero_Order", SqlDbType.Int);
            param[2].Value = Numero_Order;
            param[3] = new SqlParameter("@SalesMan", SqlDbType.VarChar, 50);
            param[3].Value = SalesMan;
            param[4] = new SqlParameter("@Nom_Chauf", SqlDbType.VarChar, 50);
            param[4].Value = Nom_Chauffeur;
            dal.ExcuteCommand("ADD_Order_Avoir_Vente", param);
            dal.Close();
        }

        public void Modifier_bon_sortie(string Date_Order, int Id_Client, int Numero_Order, string SalesMan, string Nom_Chauffeur)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Date_Order", SqlDbType.VarChar, 50);
            param[0].Value = Date_Order;
            param[1] = new SqlParameter("@Id_Client", SqlDbType.Int);
            param[1].Value = Id_Client;
            param[2] = new SqlParameter("@Numero_Order", SqlDbType.Int);
            param[2].Value = Numero_Order;
            param[3] = new SqlParameter("@SalesMan", SqlDbType.VarChar, 50);
            param[3].Value = SalesMan;
            param[4] = new SqlParameter("@Nom_Chauf", SqlDbType.VarChar, 50);
            param[4].Value = Nom_Chauffeur;
            dal.ExcuteCommand("UpdateBonDeSortie", param);
            dal.Close();
        }


        public void ADD_ORDER_DETAILS(int Id_Product ,int Id_Order, int Qte)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[0].Value = Id_Product;
            param[1] = new SqlParameter("@Id_Order", SqlDbType.Int);
            param[1].Value = Id_Order;
            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = Qte;
          
            dal.ExcuteCommand("ADD_ORDER_DETAILS", param);
            dal.Close();
        }

        public void ADD_ORDER_DETAILS_Avoir_Vente(int Id_Product, int Id_Order, int Qte)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[0].Value = Id_Product;
            param[1] = new SqlParameter("@Id_Order", SqlDbType.Int);
            param[1].Value = Id_Order;
            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = Qte;

            dal.ExcuteCommand("Add_Order_Details_Avoir_Vente", param);
            dal.Close();
        }

    }
}
