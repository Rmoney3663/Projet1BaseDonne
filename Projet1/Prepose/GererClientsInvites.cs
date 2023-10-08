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
    public partial class GererClientsInvites : Form
    {
        public GererClientsInvites()
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
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.reservationChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationChambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.reservationChambre);
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
                MessageBox.Show("Le client " + (unClient.noClient).ToString() + " a été ajouté.", "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Validate();
                this.clientBindingSource.EndEdit();
                this.clientTableAdapter.Update(this.b56Projet1Equipe7DataSet.client);
            }

        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.clientRow unClient = b56Projet1Equipe7DataSet.client.FindBynoClient(decimal.Parse(tbNoClient.Text));

            GestionClientsInvites.frmModifierClient frmModifier = new GestionClientsInvites.frmModifierClient();

            frmModifier.unClient = unClient;
            frmModifier.boolMod = false;

            frmModifier.ShowDialog();

            if (frmModifier.boolMod == true)
            {
                MessageBox.Show("Le client " + (unClient.noClient).ToString() + " a été modifié.", "Modification d'un client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Validate();
                this.clientBindingSource.EndEdit();
                this.clientTableAdapter.Update(this.b56Projet1Equipe7DataSet.client);
            }
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (tbNoClient.Text.Trim() != "")
            {
                // Vérification s'il possède un ou des invités

                B56Projet1Equipe7DataSet.clientRow client = b56Projet1Equipe7DataSet.client.FindBynoClient(Decimal.Parse(tbNoClient.Text));
                decimal noClient = client.noClient;

                if (dgInvites.RowCount != 1)
                {
                    MessageBox.Show("Ce client ne peut pas être supprimé, car il possède un ou des invités.",
                        "Supprimer un client avec invité(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Vérification s'il possède une chambre

                    if (dgReservationChambre.RowCount != 1)
                    {
                        MessageBox.Show("Ce client ne peut pas être supprimé, car il possède une réservation de chambre à son nom.",
                            "Supprimer un client avec réservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Vérification s'il a planifié des soins

                        bool booPossedeSoin = false;
                        foreach (B56Projet1Equipe7DataSet.planifSoinRow uneLigne in b56Projet1Equipe7DataSet.planifSoin.Rows)
                        {
                            if (uneLigne.noPersonne == noClient)
                            {
                                MessageBox.Show("Ce client ne peut pas être supprimé, car il a planifier un soin.",
                                    "Supprimer client avec planification de soin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                booPossedeSoin = true;
                                break;
                            }
                        }

                        if (booPossedeSoin == false)
                        {
                            DialogResult reponse = MessageBox.Show("Êtes-vous certain de vouloir supprimer le client numéro " + noClient + "?",
                                "Supprimer un client",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (reponse == DialogResult.Yes)
                            {
                                clientBindingSource.RemoveCurrent();
                                this.Validate();
                                this.clientBindingSource.EndEdit();
                                this.clientTableAdapter.Update(this.b56Projet1Equipe7DataSet.client);
                            }
                        }
                    }
                }




            }
        }

        private void btnAjoutInvite_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.inviteRow unInvite = b56Projet1Equipe7DataSet.invite.NewinviteRow();

            if (b56Projet1Equipe7DataSet.client.Count() != 0 && tbNoClient.Text != "")
            {
                unInvite.nomPrenom = "";
                unInvite.noClient = Decimal.Parse(tbNoClient.Text);
                
                GestionClientsInvites.frmAjoutInvite frmAjout = new GestionClientsInvites.frmAjoutInvite();

                decimal noInvite = unInvite.noClient + 1;
                foreach (B56Projet1Equipe7DataSet.inviteRow uneLigne in b56Projet1Equipe7DataSet.invite.Rows)
                    if (uneLigne.noInvite == noInvite && uneLigne.noClient == unInvite.noClient) noInvite ++;

                if (noInvite < unInvite.noClient + 10)
                {
                    unInvite.noInvite = noInvite;

                    frmAjout.unInvite = unInvite;
                    frmAjout.ShowDialog();

                    if (unInvite.nomPrenom != "")
                    {
                        b56Projet1Equipe7DataSet.invite.AddinviteRow(unInvite);

                        clientBindingSource.MoveLast();
                        MessageBox.Show("L'invité " + (unInvite.noInvite).ToString() + " a été ajouté.", "Ajout d'un invité", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Validate();
                        this.inviteBindingSource.EndEdit();
                        this.inviteTableAdapter.Update(this.b56Projet1Equipe7DataSet.invite);
                    }
                }

                else
                {
                    MessageBox.Show("Ce client possède déjà le nombre d'invités maximal","Maximum atteint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Veuillez sélectionner un client afin de lui attribuer un nouvel invité", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifierInvite_Click(object sender, EventArgs e)
        {
            if (dgInvites.SelectedRows.Count == 1 && dgInvites.SelectedRows[0].IsNewRow == false)
            {

                decimal noInvite = (decimal)dgInvites.SelectedRows[0].Cells[0].Value;

                B56Projet1Equipe7DataSet.inviteRow unInvite = b56Projet1Equipe7DataSet.invite.FindBynoInvite(noInvite);

                GestionClientsInvites.frmModifierInvite frmModifier = new GestionClientsInvites.frmModifierInvite();

                frmModifier.unInvite = unInvite;
                frmModifier.boolMod = false;

                frmModifier.ShowDialog();

                if (frmModifier.boolMod == true)
                {
                    MessageBox.Show("L'invité " + (unInvite.noInvite).ToString() + " a été modifié.", "Modification d'un invité", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Validate();
                    this.inviteBindingSource.EndEdit();
                    this.inviteTableAdapter.Update(this.b56Projet1Equipe7DataSet.invite);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner l'invité que vous souhaitez modifier dans la liste (un seul à la fois).", "Sélection d'un invité", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
