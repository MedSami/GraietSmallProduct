using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Graiet_Small_Products.BL
{
    class Cls_User
    {
        public DataTable Get_All_Users()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Users", null);
            dal.Close();
            return dt;
        }

        public void DELETE_USER(int ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_USER", SqlDbType.Int);
            param[0].Value = ID;


            dal.ExcuteCommand("DELETE_USER", param);
            dal.Close();
        }

        public void ADD_USER(string Name_User,string Password_User, string Numero_User,string Type_User)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Name_User", SqlDbType.VarChar, 50);
            param[0].Value = Name_User;
            param[1] = new SqlParameter("@Password_User", SqlDbType.VarChar, 50);
            param[1].Value = Password_User;
            param[2] = new SqlParameter("@Numero_User", SqlDbType.VarChar, 50);
            param[2].Value = Numero_User;
            param[3] = new SqlParameter("@Type_User", SqlDbType.VarChar, 50);
            param[3].Value = Type_User;
            dal.ExcuteCommand("ADD_USER", param);
            dal.Close();
        }
    }
}
