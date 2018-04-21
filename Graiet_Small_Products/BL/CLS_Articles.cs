using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Graiet_Small_Products.BL
{
    class CLS_Articles
    {

        public DataTable Get_All_Categories()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
          
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Categories", null);
            dal.Close();
            return dt;
        }

        public DataTable GET_ALL_Article_Modified()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("GET_ALL_Article_Modified", null);
            dal.Close();
            return dt;
        }
            public DataTable Get_All_Article()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Article", null);
            dal.Close();
            return dt;
        }
        public DataTable Get_All_Product()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Product", null);
            dal.Close();
            return dt;
        }
        

        public DataTable VerifyRefArticle(int reference)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Reference", SqlDbType.Int);
            param[0].Value = reference;
            DataTable dt = new DataTable();
            dt = dal.SelectData("VerifyRefArticle", param);
            dal.Close();
            return dt;
        }

        public DataTable SearchArticle(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = dal.SelectData("SearchArticle", param);
            dal.Close();
            return dt;
        }


        public void Add_Article(string nomArticle, int ReferenceArticle, int QteArticle,int idCat)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Nom", SqlDbType.VarChar, 50);
            param[0].Value = nomArticle;
            param[1] = new SqlParameter("@Reference", SqlDbType.Int);
            param[1].Value = ReferenceArticle;
            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = QteArticle;
            param[3] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[3].Value = idCat;
            dal.ExcuteCommand("Add_Article", param);
            dal.Close();
        }


        public void Add_ArticleAvoirAchat(string nomArticle, string ReferenceArticle,string userName, int QteArticle,string qtAS)
        {
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"); ;
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@NomArticle", SqlDbType.VarChar, 50);
            param[0].Value = nomArticle;
            param[1] = new SqlParameter("@ReferenceArticle", SqlDbType.VarChar, 50);
            param[1].Value = ReferenceArticle;
            param[2] = new SqlParameter("@Quantite", SqlDbType.Int);
            param[2].Value = QteArticle;
            param[3] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[3].Value = userName;
            param[4] = new SqlParameter("@Date", SqlDbType.VarChar,50);
            param[4].Value = dateTime;
            param[5] = new SqlParameter("@QtAjotOuSupprimer", SqlDbType.VarChar,50);
            param[5].Value = qtAS;
            dal.ExcuteCommand("InsertModificationAvoirAchat", param);
            dal.Close();
        }

        public void Update_Article(string nomArticle, int ReferenceArticle, int QteArticle, int idCat)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Nom", SqlDbType.VarChar, 50);
            param[0].Value = nomArticle;
            param[1] = new SqlParameter("@Reference", SqlDbType.Int);
            param[1].Value = ReferenceArticle;
            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = QteArticle;
            param[3] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[3].Value = idCat;
            dal.ExcuteCommand("update_article", param);
            dal.Close();
        }


        public void Delete_Article(string ReferenceArticle)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Ref", SqlDbType.Int);
            param[0].Value = ReferenceArticle;

            dal.ExcuteCommand("DeleteArticle", param);
            dal.Close();
        }

    }
}
