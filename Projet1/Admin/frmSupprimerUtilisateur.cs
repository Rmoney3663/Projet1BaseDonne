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
    public partial class frmSupprimerUtilisateur : Form
    {
        public B56Projet1Equipe7DataSet.utilisateurRow unUser;
        public int LoginUser { get; set; }
        public frmSupprimerUtilisateur()
        {
            InitializeComponent();
           
            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            unUser.noTypeUtilisateur = 3;
            this.Close();
        }

        private void typeUtilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.typeUtilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);*/

        }

        private void frmSupprimerUtilisateur_Load(object sender, EventArgs e)
        {
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

        }
    }
}
