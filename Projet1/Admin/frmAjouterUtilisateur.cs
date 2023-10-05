using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Admin
{
    public partial class frmAjouterUtilisateur : Form
    {
        public B56Projet1Equipe7DataSet.utilisateurRow unUser;
        public frmAjouterUtilisateur()
        {
            InitializeComponent();
            
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmAjouterUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.typeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.b56Projet1Equipe7DataSet.typeUtilisateur);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.utilisateurTableAdapter.Fill(this.b56Projet1Equipe7DataSet.utilisateur);

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            unUser.password = "";
            unUser.nomUtilisateur = "";
            this.Close();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                errMessage.SetError(txtUser, " le montant ne peut pas être vide");
            }

            if (txtPassword.Text.Trim() == "")
            {
                errMessage.SetError(txtPassword, " le montant ne peut pas être vide");
            }

            if (txtPassword.Text.Trim() != "" && txtUser.Text.Trim() != "")
            {
                unUser.password = txtPassword.Text;
                unUser.nomUtilisateur = txtUser.Text;
                unUser.noTypeUtilisateur = Convert.ToDecimal(cbTypeUser.SelectedValue.ToString());
                this.Close();
            }
        }
    }
}
