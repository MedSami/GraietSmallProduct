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
    public partial class Frm_Main : Form
    {
        private static Frm_Main frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Main getMainForm
        {
            get {
                if (frm == null)
                {
                    frm = new Frm_Main();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                } return frm;
            }
        }
        public Frm_Main()
        {
            InitializeComponent();
            if (frm == null) frm = this;
            this.clientsToolStripMenuItem.Enabled = false;
            this.copierBDToolStripMenuItem.Enabled = false;
            this.collerBdToolStripMenuItem.Enabled = false;
            this.utilisateursToolStripMenuItem.Enabled = false;
            this.articlesToolStripMenuItem.Enabled = false;
            this.chauffeursToolStripMenuItem.Enabled = false;
            this.avoirToolStripMenuItem.Enabled = false;
            this.bonDeSortieToolStripMenuItem.Enabled = false;
        }

        private void gestionProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ARTICLES frmArticles = new Frm_ARTICLES();
            frmArticles.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frmLogin = new Frm_Login();
            frmLogin.ShowDialog();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_add_article frmAddArtc = new Frm_add_article();
            frmAddArtc.ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Categories frmCategorie = new Frm_Categories();
            frmCategorie.ShowDialog();
        }

        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Commande frmCmd = new Frm_Commande();
            frmCmd.ShowDialog();
        }

        private void ajoutCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Clients Clients = new Frm_Clients();
            Clients.ShowDialog();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Categorie AddCat = new Frm_Add_Categorie();
            AddCat.ShowDialog();
        }

        private void gestionDUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Users Users = new Frm_Users();
            Users.ShowDialog();
        }

        private void copierBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BackUp Bach_up = new Frm_BackUp();
            Bach_up.ShowDialog();
        }

        private void collerBdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Restore Restore = new Frm_Restore();
            Restore.ShowDialog();
        }

        private void ajoutUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ADD_Users clt = new Frm_ADD_Users();
            clt.ShowDialog();
        }

        private void settingsServerConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Settings_Server setting = new Frm_Settings_Server();
            setting.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionDuChauffeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Chauff Chauffeur = new Frm_Chauff();
            Chauffeur.ShowDialog();
        }

        private void listeAvoirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Liste_Avoir ListeAvoir = new Frm_Liste_Avoir();
            ListeAvoir.ShowDialog();
        }

        private void avoirVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Avoir_Vente Avoir_Vente = new Frm_Avoir_Vente();
            Avoir_Vente.ShowDialog();
        }

        private void imprimerBonDeSortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_imprimerBonSortie ibs = new Frm_imprimerBonSortie();
            ibs.ShowDialog();
        }

        private void avoirAchatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeArticlesModifier ArticleModifier = new ListeArticlesModifier();
            ArticleModifier.ShowDialog();
        }
    }
}
