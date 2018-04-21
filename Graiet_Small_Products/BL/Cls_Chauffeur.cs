using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Graiet_Small_Products.BL
{
    class Cls_Chauffeur
    {


        public DataTable Get_All_Drivers()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Drivers", null);
            dal.Close();
            return dt;
        }

        public void Add_Chauffeur(string nom, int NumTel,string matricule)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = nom;
            param[1] = new SqlParameter("@NumTel", SqlDbType.Int);
            param[1].Value = NumTel;
            param[2] = new SqlParameter("@Matricule", SqlDbType.VarChar, 50);
            param[2].Value = matricule;
           
            dal.ExcuteCommand("Add_Chauffeur", param);
            dal.Close();
        }

        public void Update_Chauffeur(int idChauffeur,string nom, int NumTel, string matricule)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idChauffeur;
            param[1] = new SqlParameter("@nom", SqlDbType.NChar, 50);
            param[1].Value = nom;
            param[2] = new SqlParameter("@NumeroTel", SqlDbType.Int);
            param[2].Value = NumTel;
            param[3] = new SqlParameter("@matricule", SqlDbType.NChar, 50);
            param[3].Value = matricule;

            dal.ExcuteCommand("updateChauffeur", param);
            dal.Close();
        }

        public void Delete_Chauffeur(int idChauffeur)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idChauffeur;

            dal.ExcuteCommand("DeleteChauffeur", param);
            dal.Close();
        }


    }
}
