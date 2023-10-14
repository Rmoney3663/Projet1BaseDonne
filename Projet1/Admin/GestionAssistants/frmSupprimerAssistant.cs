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
    public partial class frmSupprimerAssistant : Form
    {
        public B56Projet1Equipe7DataSet.assistantRow unUser;
        public string nom { get; set; }
        public string prenom { get; set; }
        public string specialites { get; set; }
        public string remarques { get; set; }
        public bool boolMod;
        public frmSupprimerAssistant()
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

        private void frmSupprimerAssistant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistant);
            prenomTextBox.Text = unUser.prenom.ToString();
            nomTextBox.Text = unUser.nom.ToString();
            specialitesTextBox.Text = unUser.specialites.ToString();
            remarquesTextBox.Text = unUser.remarques.ToString();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            boolMod = false;
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            boolMod = true;
            this.Close();
        }
    }
}
