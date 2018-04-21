using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Graiet_Small_Products.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        public DataAccessLayer()
        {
            string MODE = Properties.Settings.Default.Mode;
            if(MODE=="SQL")
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.ServerName + 
                    "; Database="+ Properties.Settings.Default.DataBase +
                    "; Integrated Security=false; User ID="+Properties.Settings.Default.ID+
                    ";Password="+Properties.Settings.Default.Password+"");
            }else{
            sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.ServerName+ "; Database="+Properties.Settings.Default.DataBase+"; Integrated Security=true");
        }}


        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open) 
            {
                sqlconnection.Open();
            }
        }

        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        public DataTable SelectData(String stored_procedure, SqlParameter [] param)
        {
            
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            if (param != null) {
                for (int i = 0; i < param.Length;i++ )
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            } try
            {
               
                da.Fill(dt);
                
            }
            catch (Exception e) {
                MessageBox.Show("Vérifier (Setting Server Conection)"+e,"Server Connection ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return dt;
        }


        public void ExcuteCommand(String stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param); 
            }
            sqlcmd.ExecuteNonQuery();
        }

    }
}
