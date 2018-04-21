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
    public partial class Frm_Restore : Form
    {
        SqlConnection sqlconnection;
        SqlCommand cmd;
      /*  SqlConnection sqlCon = new SqlConnection(@"Server=.\SQLEXPRESS; Database=master; Integrated Security=true");
        */
        public Frm_Restore()
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string Query = "ALTER DATABASE Graiet_Small_Product SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE Graiet_Small_Product FROM DISK=" + " '" + txtDirectory.Text + "' ";
            cmd = new SqlCommand(Query,sqlconnection);
            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Restore DONE", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
