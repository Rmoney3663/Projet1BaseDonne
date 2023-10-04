using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Prepose.GestionClientsInvites
{
    public partial class frmAjoutClient : Form
    {
        public B56Projet1Equipe7DataSet.clientRow unClient;

        public frmAjoutClient()
        {
            InitializeComponent();
        }

        private void frmAjoutClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.b56Projet1Equipe7DataSet.client);
            dpInscription.Value = DateTime.Now;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
                errMessage.SetError(tbNom, "La zone de texte pour le nom ne peut pas être vide");
            else
                errMessage.SetError(tbNom, "");

            if (tbPrenom.Text.Trim() == "")
                errMessage.SetError(tbPrenom, "La zone de texte pour le prénom ne peut pas être vide");
            else
                errMessage.SetError(tbPrenom, "");

            if (tbVille.Text.Trim() == "")
                errMessage.SetError(tbVille, "La zone de texte pour la ville ne peut pas être vide");
            else
                errMessage.SetError(tbVille, "");

            if (tbPays.Text.Trim() == "")
                errMessage.SetError(tbPays, "La zone de texte pour le pays ne peut pas être vide");
            else
                errMessage.SetError(tbPays, "");

            if (tbAdresse.Text.Trim() == "")
                errMessage.SetError(tbAdresse, "La zone de texte pour l'adresse ne peut pas être vide");
            else
                errMessage.SetError(tbAdresse, "");

            if (tbCodePostal.Text.Trim() == "")
                errMessage.SetError(tbCodePostal, "La zone de texte pour le code postal ne peut pas être vide");
            else
                errMessage.SetError(tbCodePostal, "");

            if (errMessage.GetError(tbNom) == "" && errMessage.GetError(tbPrenom) == ""
                && errMessage.GetError(tbVille) == "" && errMessage.GetError(tbPays) == ""
                && errMessage.GetError(tbAdresse) == "" && errMessage.GetError(tbCodePostal) == "")
            {
                unClient.nom = tbNom.Text;
                unClient.prenom = tbPrenom.Text;
                unClient.ville = tbVille.Text;
                unClient.pays = tbPays.Text;
                unClient.adresse = tbAdresse.Text;
                unClient.codePostal = tbCodePostal.Text;
                unClient.dateInscription = DateTime.Now;
                this.Close();
            }
                
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
