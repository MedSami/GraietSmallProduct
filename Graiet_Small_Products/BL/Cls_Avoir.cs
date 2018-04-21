using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Graiet_Small_Products.BL
{
    class Cls_Avoir
    {

        public DataTable GET_ORDER_DETAILSForPrintAvoir(int id_order)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_O", SqlDbType.Int);
            param[0].Value = id_order;

            DataTable dt = new DataTable();
            dt = dal.SelectData("GET_ORDER_DETAILSForPrintAvoir", param);
            dal.Close();
            return dt;
        }

    }
}
