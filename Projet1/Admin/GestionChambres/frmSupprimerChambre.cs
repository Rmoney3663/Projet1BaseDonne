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
    public partial class frmSupprimerChambre : Form
    {
        public B56Projet1Equipe7DataSet.chambreRow unChambre;
        public bool boolMod;
        public frmSupprimerChambre()
        {
            InitializeComponent();
        }

        private void chambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmSupprimerChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.chambre' table. You can move, or remove it, as needed.
            this.chambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.chambre);
            decorationsTextBox.Text = unChambre.decorations;
            emplacementTextBox.Text = unChambre.emplacement;
            noChambreTextBox.Text = unChambre.noChambre.ToString();
            noTypeChambreTextBox.Text = unChambre.noTypeChambre.ToString();
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
