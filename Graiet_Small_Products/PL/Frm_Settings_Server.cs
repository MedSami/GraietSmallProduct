using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graiet_Small_Products.PL
{
    public partial class Frm_Settings_Server : Form
    {
        public Frm_Settings_Server()
        {
            InitializeComponent();
            txtNomServer.Text = Properties.Settings.Default.ServerName;
            txtBD.Text = Properties.Settings.Default.DataBase;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbSqlServer.Checked = true;
                txtNomUtilisateur.Text = Properties.Settings.Default.ID;
                txtPss.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txtNomUtilisateur.Clear();
                txtPss.Clear();
                txtNomUtilisateur.ReadOnly=true;
                txtPss.ReadOnly = true;
            }

            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerName = txtNomServer.Text;
            Properties.Settings.Default.DataBase = txtBD.Text;
            Properties.Settings.Default.ID = txtNomUtilisateur.Text;
            Properties.Settings.Default.Password = txtPss.Text;
            Properties.Settings.Default.Mode = rbSqlServer.Checked == true ? "SQL" : "WINDOWS";
            Properties.Settings.Default.Save();
        }

        private void rbSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            txtNomUtilisateur.ReadOnly = false;
            txtPss.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtNomUtilisateur.ReadOnly = true;
            txtPss.ReadOnly = true;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
