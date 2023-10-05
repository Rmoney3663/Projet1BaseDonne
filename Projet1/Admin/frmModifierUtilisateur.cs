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
    public partial class frmModifierUtilisateur : Form
    {
        public B56Projet1Equipe7DataSet.utilisateurRow unUser;
        public string pass { get; set; }
        public string user { get; set; }
        public decimal type { get; set; }

        public int LoginUser { get; set; }

        public frmModifierUtilisateur()
        {
            InitializeComponent();
        }
       

        private void btnFermer_Click(object sender, EventArgs e)
        {
            unUser.password = pass;
            unUser.nomUtilisateur = user;
            unUser.noTypeUtilisateur = type;
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                errMessage.SetError(txtUser, "Le nom d'utilisateur ne peut pas être vide");
            }

            if (txtPassword.Text.Trim() == "")
            {
                errMessage.SetError(txtPassword, "Le mot de passe ne peut pas être vide");
            }

            if (txtPassword.Text.Trim() != "" && txtUser.Text.Trim() != "")
            {
                unUser.password = txtPassword.Text;
                unUser.nomUtilisateur = txtUser.Text;
                unUser.noTypeUtilisateur = Convert.ToDecimal(cbTypeUser.SelectedValue.ToString());
                this.Validate();
                this.typeUtilisateurBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);
                this.Close();
            }
        }

        private void typeUtilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.typeUtilisateurBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmModifierUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.utilisateurTableAdapter.Fill(this.b56Projet1Equipe7DataSet.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.typeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.b56Projet1Equipe7DataSet.typeUtilisateur);
            txtPassword.Text = unUser.password.ToString();
            txtUser.Text = unUser.nomUtilisateur.ToString();

            decimal userTypeValue = unUser.noTypeUtilisateur;

            for (int i = 0; i < cbTypeUser.Items.Count; i++)
            {
                DataRowView item = (DataRowView)cbTypeUser.Items[i];

                decimal comboBoxValue = (decimal)item["noTypeUtilisateur"];

                if (comboBoxValue == userTypeValue)
                {
                    cbTypeUser.SelectedIndex = i;
                    break;
                }               
               
            }

            if (Convert.ToDecimal(LoginUser) == unUser.noUtilisateur)
            {
                cbTypeUser.Enabled = false;
            }
            else
            {
                cbTypeUser.Enabled = true;
            }
            pass = unUser.password;
            type = unUser.noTypeUtilisateur;
            user = unUser.nomUtilisateur;

        }
    }
}
