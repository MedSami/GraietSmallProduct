using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Graiet_Small_Products.BL
{
    class Cls_Custmers
    {

        public DataTable Get_All_Custmer() {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Custmer", null);
            dal.Close();
            return dt;
        }


        public void ADD_CLIENT(string nom,string NumTel)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Name_Client", SqlDbType.VarChar, 50);
            param[0].Value = nom;
            param[1] = new SqlParameter("@NumTel", SqlDbType.VarChar, 50);
            param[1].Value = NumTel;
            dal.ExcuteCommand("ADD_CLIENT", param);
            dal.Close();
        }



        public void DeleteClient(string n)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@N", SqlDbType.VarChar,50);
            param[0].Value = n;

            dal.ExcuteCommand("DeleteClient", param);
            dal.Close();
        }

    }
}
