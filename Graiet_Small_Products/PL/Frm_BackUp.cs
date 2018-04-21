using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Graiet_Small_Products.PL
{
    public partial class Frm_BackUp : Form
    {
        SqlConnection sqlconnection;
        SqlCommand cmd;
       /* SqlConnection sqlCon = new SqlConnection(@"Server=" + Properties.Settings.Default.ServerName +
                    "; Database=" + Properties.Settings.Default.DataBase +
                    "; Integrated Security=false; User ID=" + Properties.Settings.Default.ID +
                    ";Password=" + Properties.Settings.Default.Password + "");*/
        
        public Frm_BackUp()
        {
            InitializeComponent();
            string MODE = Properties.Settings.Default.Mode;
            if (MODE == "SQL")
            {
                 sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.ServerName +
                    "; Database=" + Properties.Settings.Default.DataBase +
                    "; Integrated Security=false; User ID=" + Properties.Settings.Default.ID +
                    ";Password=" + Properties.Settings.Default.Password + "");
            }
            else
            {
                 sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.ServerName + "; Database=" + Properties.Settings.Default.DataBase + "; Integrated Security=true");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = folderBrowserDialog1.SelectedPath;
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string FileName = txtDirectory.Text + "\\Graiet_Small_Product" + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToShortTimeString().Replace(':', '-');
            string Query = " BACKUP DATABASE Graiet_Small_Product TO DISK="+" '"+FileName+".bak' ";
            cmd = new SqlCommand(Query, sqlconnection);
            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("BackUp DONE","BackUp",MessageBoxButtons.OK,MessageBoxIcon.Information);

        
        }
    }
}
