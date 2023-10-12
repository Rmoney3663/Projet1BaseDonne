using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Admin.GestionAssistants
{
    public partial class frmAjouterAssistant : Form
    {
        public B56Projet1Equipe7DataSet.assistantRow unUser;
        public frmAjouterAssistant()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void assistantBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmAjouterAssistant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistant);
            prenomTextBox.Text = "";
            nomTextBox.Text = "";
            specialitesTextBox.Text = "";
            remarquesTextBox.Text = "";

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            unUser.prenom = "";
            unUser.nom = "";
            unUser.specialites = "";
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (prenomTextBox.Text.Trim() == "")
            {
                errMessage.SetError(prenomTextBox, "Le prenom d'assistant ne peut pas être vide");
            }

            if (nomTextBox.Text.Trim() == "")
            {
                errMessage.SetError(nomTextBox, "Le nom d'assistant ne peut pas être vide");
            }
            if (specialitesTextBox.Text.Trim() == "")
            {
                errMessage.SetError(specialitesTextBox, "Le specialite d'assistant ne peut pas être vide");
            }

            if (prenomTextBox.Text.Trim() != "" && nomTextBox.Text.Trim() != "" && specialitesTextBox.Text.Trim() != "")
            {
                unUser.prenom = prenomTextBox.Text;
                unUser.nom = nomTextBox.Text;
                unUser.specialites = specialitesTextBox.Text;
                unUser.remarques = remarquesTextBox.Text;
                this.Close();
            }
        }
    }
}
