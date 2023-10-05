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
    public partial class GererUtilisateur : Form
    {         
        public GererUtilisateur()
        {
            InitializeComponent();
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void GererUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.b56Projet1Equipe7DataSet.utilisateur);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.utilisateurRow unUser = b56Projet1Equipe7DataSet.utilisateur.NewutilisateurRow();
            decimal noContratMax = 0;
            foreach (B56Projet1Equipe7DataSet.utilisateurRow uneLigne in b56Projet1Equipe7DataSet.utilisateur.Rows)
                if (uneLigne.noUtilisateur > noContratMax) noContratMax = uneLigne.noUtilisateur;

            unUser.noUtilisateur = noContratMax + 1;
            unUser.noTypeUtilisateur = 2;
            unUser.password = "";
            unUser.nomUtilisateur = "";
            frmAjouterUtilisateur frmAjouterUtilisateur = new frmAjouterUtilisateur();
            frmAjouterUtilisateur.unUser = unUser;
            frmAjouterUtilisateur.ShowDialog();

            bool userNameExists = DoesUserNameExist(unUser.nomUtilisateur);

            if (userNameExists)
            {
                MessageBox.Show("Le nom d'utilisateur existe déjà. Veuillez choisir un autre nom d'utilisateur.",
                    "Nom d'utilisateur déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (unUser.password != "" && unUser.nomUtilisateur != "" && unUser.password != null && unUser.nomUtilisateur != null && userNameExists == false)
            {
                b56Projet1Equipe7DataSet.utilisateur.AddutilisateurRow(unUser);
                //utilisateurBindingSource.MoveLast();
                MessageBox.Show(" le utilisateur " + unUser.nomUtilisateur.ToString() + " a été ajouté. ",
                   "Ajout d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Validate();
                this.utilisateurBindingSource.EndEdit();
                this.utilisateurTableAdapter.Update(this.b56Projet1Equipe7DataSet.utilisateur);
            }
        }

        private bool DoesUserNameExist(string userNameToCheck)
        {
            foreach (B56Projet1Equipe7DataSet.utilisateurRow uneLigne in b56Projet1Equipe7DataSet.utilisateur.Rows)
            {
                if (uneLigne.nomUtilisateur.Equals(userNameToCheck, StringComparison.OrdinalIgnoreCase))
                {
                    return true; 
                }
            }
            return false; 
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (utilisateurDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = utilisateurDataGridView.SelectedRows[0];

                B56Projet1Equipe7DataSet.utilisateurRow unUser = b56Projet1Equipe7DataSet.utilisateur.NewutilisateurRow();     

                string user = selectedRow.Cells["noUtilisateur"].Value.ToString();
                string type = selectedRow.Cells["noTypeUtilisateur"].Value.ToString();

                unUser.noUtilisateur = decimal.Parse(user);
                unUser.noTypeUtilisateur = decimal.Parse(type);
                unUser.password = selectedRow.Cells["password"].Value.ToString();
                unUser.nomUtilisateur = selectedRow.Cells["nomUtilisateur"].Value.ToString();
                frmModifierUtilisateur frmModifierUtilisateur = new frmModifierUtilisateur();
                frmModifierUtilisateur.unUser = unUser;
                frmModifierUtilisateur.ShowDialog();

            }
            else
            {
                MessageBox.Show("No rows are selected.");
            }
        }
    }
}
