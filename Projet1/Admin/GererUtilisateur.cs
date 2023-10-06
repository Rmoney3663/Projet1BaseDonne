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
        public int LoginUser { get; set; }

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
                MessageBox.Show(" L'utilisateur " + unUser.nomUtilisateur.ToString() + " a été ajouté. ",
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

                string user = selectedRow.Cells["noUtilisateur"].Value.ToString();
                string type = selectedRow.Cells["noTypeUtilisateur"].Value.ToString();

                decimal userId = decimal.Parse(user);
                decimal userType = decimal.Parse(type);

                
                B56Projet1Equipe7DataSet.utilisateurRow existingUser = b56Projet1Equipe7DataSet.utilisateur.FindBynoUtilisateur(userId);

                if (existingUser != null)
                {
                    frmModifierUtilisateur frmModifierUtilisateur = new frmModifierUtilisateur();
                    frmModifierUtilisateur.unUser = existingUser; 
                    frmModifierUtilisateur.LoginUser = LoginUser;
                    frmModifierUtilisateur.ShowDialog();

                    if (existingUser.password != "" && existingUser.nomUtilisateur != "" && existingUser.password != null && existingUser.nomUtilisateur != null)
                    {
                        MessageBox.Show("L'utilisateur " + existingUser.nomUtilisateur.ToString() + " a été modifié. ",
                                        "Modification d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Validate();
                        this.utilisateurBindingSource.EndEdit();
                        this.utilisateurTableAdapter.Update(existingUser);
                    }
                    else
                    {
                        MessageBox.Show("Les données de l'utilisateur ne sont pas valides et la modification est impossible.",
                                        "Modification d'un utilisateur impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("No rows are selected.");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (utilisateurDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = utilisateurDataGridView.SelectedRows[0];

                string user = selectedRow.Cells["noUtilisateur"].Value.ToString();
                string type = selectedRow.Cells["noTypeUtilisateur"].Value.ToString();

                decimal userId = decimal.Parse(user);
                decimal userType = decimal.Parse(type);

                B56Projet1Equipe7DataSet.utilisateurRow deleteUser = b56Projet1Equipe7DataSet.utilisateur.FindBynoUtilisateur(userId);
               
                if (deleteUser.noUtilisateur != LoginUser && deleteUser.noUtilisateur != 1)
                {                    
                    if (deleteUser != null)
                    {
                        frmSupprimerUtilisateur frmSupprimerUtilisateur = new frmSupprimerUtilisateur();
                        frmSupprimerUtilisateur.unUser = deleteUser;
                        frmSupprimerUtilisateur.LoginUser = LoginUser;
                       
                        frmSupprimerUtilisateur.ShowDialog();
                        
                        if (deleteUser.noTypeUtilisateur == 3)
                        {
                            deleteUser.noTypeUtilisateur = userType;
                            /*this.Validate();
                            this.utilisateurBindingSource.EndEdit();*/
                            this.utilisateurTableAdapter.Delete(deleteUser.noUtilisateur, deleteUser.nomUtilisateur, deleteUser.password, userType);
                            MessageBox.Show("L'utilisateur " + deleteUser.nomUtilisateur.ToString() + " a été supprimé. ",
                                            "Suppression d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            b56Projet1Equipe7DataSet.utilisateur.RemoveutilisateurRow(deleteUser);
                            
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Un utilisateur ne peut pas supprimer son propre compte ou l'administrateur initial!",
                                    "Suppression d'un utilisateur impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No rows are selected.");
            }
        }

    }
}
