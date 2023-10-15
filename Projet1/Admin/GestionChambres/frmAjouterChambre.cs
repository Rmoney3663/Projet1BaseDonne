using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Admin.GestionChambres
{
    public partial class frmAjouterChambre : Form
    {
        public B56Projet1Equipe7DataSet.chambreRow unChambre;
        public bool boolMod;
        public frmAjouterChambre()
        {
            InitializeComponent();
        }

        private void chambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmAjouterChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.chambre' table. You can move, or remove it, as needed.
            this.chambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.chambre);
            decorationsTextBox.Text = "";
            emplacementTextBox.Text = "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bool good = true;
            if (decorationsTextBox.Text.Trim() == "")
            {
                errMessage.SetError(decorationsTextBox, "Le decoration du chambre ne peut pas être vide");
                good = false;
            }

            if (emplacementTextBox.Text.Trim() == "")
            {
                errMessage.SetError(emplacementTextBox, "L'emplacement du chambre ne peut pas être vide");
                good = false;
            }

            if (good == true)
            {
                unChambre.decorations = decorationsTextBox.Text;
                unChambre.emplacement = emplacementTextBox.Text;
                boolMod = true;
                this.Close();

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            boolMod = false;
            this.Close();
        }
    }
}
