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

namespace Projet1.Prepose
{
    public partial class GererClientsInvites : Form
    {
        public GererClientsInvites()
        {
            InitializeComponent();
        }

        private void Gerer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.reservationChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationChambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.reservationChambre);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.b56Projet1Equipe7DataSet.invite);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.b56Projet1Equipe7DataSet.client);

            lbTotale.Text = clientBindingSource.Count.ToString();
            int position = clientBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
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
            if (tbNoClient.Text.ToString() != "")
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
            else
            {
                MessageBox.Show("Vous devez être sur la page d'un client pour le modifier.",
                    "Modifier un client invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "SELECT * FROM planifSoin " +
                                "WHERE noPersonne = @noClient";

                            SqlCommand maCommande = new SqlCommand(query, connection);
                            maCommande.Parameters.AddWithValue("@noClient", decimal.Parse(tbNoClient.Text));

                            object possedePlanif = maCommande.ExecuteScalar();

                            if (possedePlanif != null)
                            {
                                MessageBox.Show("Ce client ne peut pas être suprimmé, car il possède au moins une planification de soin","Client possède planifSoin",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            else
                            {
                                DialogResult reponse = MessageBox.Show("Êtes-vous certain de vouloir supprimer ce client ?",
                                        "Supprimer un client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (reponse == DialogResult.Yes)
                                {
                                    clientBindingSource.RemoveCurrent();
                                    this.Validate();
                                    this.clientBindingSource.EndEdit();
                                    this.clientTableAdapter.Update(this.b56Projet1Equipe7DataSet.client);
                                }
                            }
                                connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous devez être sur la page d'un client pour le supprimer.", "Supprimer un client invalide",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                decimal noInvite = 0;

                for (int i = (int)unInvite.noClient + 1; i < unInvite.noClient + 10; i++)
                {
                    B56Projet1Equipe7DataSet.inviteRow inviteRandom = b56Projet1Equipe7DataSet.invite.FindBynoInvite(i);
                    if (inviteRandom == null)
                    {
                        noInvite = i;
                        break;
                    }
                }

                if (noInvite != 0)
                {
                    unInvite.noInvite = noInvite;

                    frmAjout.unInvite = unInvite;
                    frmAjout.ShowDialog();

                    if (unInvite.nomPrenom != "")
                    {
                        b56Projet1Equipe7DataSet.invite.AddinviteRow(unInvite);

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
                MessageBox.Show("Veuillez sélectionner l'invité que vous souhaitez modifier dans la liste.", "Sélection d'un invité", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {
            if (dgInvites.SelectedRows.Count == 1 && dgInvites.SelectedRows[0].IsNewRow == false)
            {

                // Vérification s'il a planifié des soins

                decimal noInvite = (decimal)dgInvites.SelectedRows[0].Cells[0].Value;

                string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM planifSoin " +
                        "WHERE noPersonne = @noInvite";

                    SqlCommand maCommande = new SqlCommand(query, connection);
                    maCommande.Parameters.AddWithValue("@noInvite", noInvite);

                    object possedePlanif = maCommande.ExecuteScalar();

                    if (possedePlanif != null)
                    {
                        MessageBox.Show("Cet invité ne peut pas être suprimmé, car il possède au moins une planification de soin", "Invité possède planifSoin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult reponse = MessageBox.Show("Êtes-vous certain de vouloir supprimer cet invité ?",
                            "Supprimer un invité", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (reponse == DialogResult.Yes)
                        {
                            inviteBindingSource.RemoveCurrent();
                            this.Validate();
                            this.inviteBindingSource.EndEdit();
                            this.inviteTableAdapter.Update(this.b56Projet1Equipe7DataSet.invite);
                        }
                    }

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner l'invité que vous souhaitez supprimer dans la liste.", "Sélection d'un invité", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            b56Projet1Equipe7DataSet.client.WriteXml("client.xml");
            b56Projet1Equipe7DataSet.client.WriteXmlSchema("client.xsd");
            b56Projet1Equipe7DataSet.invite.WriteXml("invite.xml");
            b56Projet1Equipe7DataSet.invite.WriteXmlSchema("invite.xsd");
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveFirst();
            int position = clientBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
            int position = clientBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
            int position = clientBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveLast();
            int position = clientBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }
    }
}
