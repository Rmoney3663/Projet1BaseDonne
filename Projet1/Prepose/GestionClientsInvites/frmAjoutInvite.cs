using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Prepose.GestionClientsInvites
{
    public partial class frmAjoutInvite : Form
    {
        public B56Projet1Equipe7DataSet.inviteRow unInvite;

        public frmAjoutInvite()
        {
            InitializeComponent();
        }

        private void inviteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inviteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmAjoutInvite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.b56Projet1Equipe7DataSet.invite);
            tbNoClient.Text = unInvite.noClient.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
                errMessage.SetError(tbNom, "La zone de texte pour le nom ne peut pas être vide");
            else
                errMessage.SetError(tbNom, "");

            if (errMessage.GetError(tbNom) == "")
            {
                unInvite.nomPrenom = tbNom.Text;
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
