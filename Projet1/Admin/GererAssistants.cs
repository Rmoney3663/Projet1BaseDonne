using Projet1.Admin.GestionAssistants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Admin
{
    public partial class GererAssistants : Form
    {
        public GererAssistants()
        {
            InitializeComponent();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void GererAssistants_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistantSoin);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.planifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.planifSoin);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistant);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.soin);

            lbTotale.Text = assistantBindingSource.Count.ToString();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            assistantBindingSource.MoveFirst();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            assistantBindingSource.MovePrevious();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            assistantBindingSource.MoveNext();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            assistantBindingSource.MoveLast();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnAjouterSoins_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.assistantSoinRow unSoin = b56Projet1Equipe7DataSet.assistantSoin.NewassistantSoinRow();
            string input = noAssistantTextBox.Text;
            unSoin.noAssistant = decimal.Parse(input);

            GestionAssistants.frmAjouterSoin frmAjoutSoin = new GestionAssistants.frmAjouterSoin();

            frmAjoutSoin.unSoin = unSoin;
            frmAjoutSoin.ShowDialog();

            if (unSoin.noSoin != 0 && unSoin.noSoin != -1)
            {
                b56Projet1Equipe7DataSet.assistantSoin.AddassistantSoinRow(unSoin);
                MessageBox.Show(" Le soin " + unSoin.noSoin.ToString() + " a été ajouté. ",
                   "Ajout d'un soin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Validate();
                this.assistantSoinBindingSource.EndEdit();
                this.assistantSoinTableAdapter.Update(this.b56Projet1Equipe7DataSet.assistantSoin);

            }
        }

        private void btnSupprimerSoins_Click(object sender, EventArgs e)
        {
            if (assistantSoinDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = assistantSoinDataGridView.SelectedRows[0];

                string strsoin = selectedRow.Cells["noSoin"].Value.ToString();
                string strinput = noAssistantTextBox.Text;
               

                decimal soin = decimal.Parse(strsoin);
                decimal assistant = decimal.Parse(strinput);

                B56Projet1Equipe7DataSet.assistantSoinRow deleteSoin = b56Projet1Equipe7DataSet.assistantSoin.FindBynoAssistantnoSoin(assistant, soin);

                string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
                decimal noSoinToDelete = deleteSoin.noSoin;
                int planifSoinCount = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM planifSoin WHERE noSoin = @noSoin";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@noSoin", noSoinToDelete);

                        // Execute the query and get the count
                        planifSoinCount = (int)command.ExecuteScalar();
                    }
                }

                if (planifSoinCount > 0)
                {
                    MessageBox.Show("Ce soin est utilisé dans la planification et ne peut pas être supprimé.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (deleteSoin != null)
                    {
                        GestionAssistants.frmSupprimerSoin frmSupprimerSoin = new GestionAssistants.frmSupprimerSoin();
                        frmSupprimerSoin.deleteSoin = deleteSoin;

                        frmSupprimerSoin.ShowDialog();

                        if (deleteSoin.noSoin == -1)
                        {
                            deleteSoin.noSoin = soin;
                            this.assistantSoinTableAdapter.Delete(deleteSoin.noAssistant, deleteSoin.noSoin);
                            MessageBox.Show("Le soin " + deleteSoin.noSoin.ToString() + " a été enlevé de cet assistant. ",
                                            "Suppression d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            b56Projet1Equipe7DataSet.assistantSoin.RemoveassistantSoinRow(deleteSoin);
                        }
                    }
                    }                   
                }
            else
            {
                MessageBox.Show("No rows are selected.");
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.assistantRow unUser = b56Projet1Equipe7DataSet.assistant.NewassistantRow();
            decimal noContratMax = 0;
            foreach (B56Projet1Equipe7DataSet.assistantRow uneLigne in b56Projet1Equipe7DataSet.assistant.Rows)
                if (uneLigne.noAssistant > noContratMax) noContratMax = uneLigne.noAssistant;

            unUser.noAssistant = noContratMax + 1;
            unUser.prenom = "";
            unUser.nom = "";
            unUser.specialites = "";
            unUser.remarques = "";
            frmAjouterAssistant frmAjouterAssistant = new frmAjouterAssistant();
            frmAjouterAssistant.unUser = unUser;
            frmAjouterAssistant.ShowDialog();
          
            if (unUser.prenom != "" && unUser.nom != "" && unUser.specialites != "" && unUser.specialites != null && unUser.nom != null && unUser.prenom != null )
            {
                b56Projet1Equipe7DataSet.assistant.AddassistantRow(unUser);
                //utilisateurBindingSource.MoveLast();
                MessageBox.Show(" L'utilisateur " + unUser.prenom.ToString() + " " + unUser.nom.ToString() + " a été ajouté. ",
                   "Ajout d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Validate();
                this.assistantBindingSource.EndEdit();
                this.assistantTableAdapter.Update(this.b56Projet1Equipe7DataSet.assistant);
                lbTotale.Text = assistantBindingSource.Count.ToString();
            }
        }
    }
}
