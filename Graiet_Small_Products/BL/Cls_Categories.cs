using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Graiet_Small_Products.BL
{
    class Cls_Categories
    {

        public void Add_Categorie(string nom)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Nom", SqlDbType.VarChar, 50);
            param[0].Value = nom;
            dal.ExcuteCommand("Add_Categorie", param);
            dal.Close();
        }

        public DataTable Get_All_Categories()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Categories", null);
            dal.Close();
            return dt;
        }

        public DataTable VerifCategorie(string nom)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param[0].Value = nom;
            DataTable dt = new DataTable();
            dt = dal.SelectData("VerifCategorie", param);
            dal.Close();
            return dt;
        }

        public void Delete_Categorie(string name)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Name", SqlDbType.VarChar,50);
            param[0].Value = name;
           

            dal.ExcuteCommand("DELETE_CATEGORIE", param);
            dal.Close();
        }

    }
}
