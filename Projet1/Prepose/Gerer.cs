﻿using System;
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
                MessageBox.Show("Le client " + (unClient.noClient).ToString() + " a été ajouté.", "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Validate();
                this.clientBindingSource.EndEdit();
                this.clientTableAdapter.Update(this.b56Projet1Equipe7DataSet.client);
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
            B56Projet1Equipe7DataSet.inviteRow unInvite = b56Projet1Equipe7DataSet.invite.NewinviteRow();

            if (b56Projet1Equipe7DataSet.client.Count() != 0 && tbNoClient.Text != "")
            {

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
                    MessageBox.Show("Ce client possède déjà le nombre d'invités maximal","Maximum atteint");
                }
            }

            else
            {
                MessageBox.Show("Veuillez sélectionner un client afin de lui attribuer un nouvel invité", "Aucune sélection");
            }
        }

        private void btnModifierInvite_Click(object sender, EventArgs e)
        {

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
