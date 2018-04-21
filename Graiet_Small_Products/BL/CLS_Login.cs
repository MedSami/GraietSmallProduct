using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Graiet_Small_Products.BL
{
    class CLS_Login
    {
        public DataTable Login(string NAME_User, string Password_User) 
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param=new SqlParameter[2];
            param[0] = new SqlParameter("@Name_User",SqlDbType.VarChar,50);
            param[0].Value = NAME_User;
            param[1] = new SqlParameter("@Password_User", SqlDbType.VarChar, 50);
            param[1].Value = Password_User;
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_proc", param);
            dal.Close();
            return dt;
        }
    }
}
