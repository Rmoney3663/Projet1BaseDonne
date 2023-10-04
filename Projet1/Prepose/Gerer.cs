using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Prepose
{
    public partial class Gerer : Form
    {
        public Gerer()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void Gerer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.b56Projet1Equipe7DataSet.invite);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.b56Projet1Equipe7DataSet.client);

        }

        private void btnAjoutClient_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.clientRow unClient = b56Projet1Equipe7DataSet.client.NewclientRow();

            decimal noContratMax = 0;

            if (b56Projet1Equipe7DataSet.client.Count() != 0)
            {
                noContratMax =
                b56Projet1Equipe7DataSet.client.Rows.Cast<B56Projet1Equipe7DataSet.clientRow>().Max(r => r.noClient);
            }

            unClient.noClient = noContratMax + 10;

            unClient.dateInscription = DateTime.MinValue;

            GestionClientsInvites.frmAjoutClient frmAjout = new GestionClientsInvites.frmAjoutClient();

            frmAjout.unClient = unClient;
            frmAjout.ShowDialog();

            if (unClient.dateInscription != DateTime.MinValue)
            {
                b56Projet1Equipe7DataSet.client.AddclientRow(unClient);

                clientBindingSource.MoveLast();
                MessageBox.Show("Le client " + unClient.noClient.ToString() + " a été ajouté.", "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutInvite_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierInvite_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {

        }
    }
}
