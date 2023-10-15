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
    public partial class frmSupprimerType : Form
    {
        public B56Projet1Equipe7DataSet.typeChambreRow unUser;
        public bool boolMod;
        public frmSupprimerType()
        {
            InitializeComponent();
        }

        private void typeChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmSupprimerType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.typeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.typeChambre);

            descriptionTextBox.Text = unUser.description;
            prixHautTextBox.Text = unUser.prixHaut.ToString();
            prixBasTextBox.Text = unUser.prixBas.ToString();
            prixMoyenTextBox.Text = unUser.prixMoyen.ToString();
            noTypeChambreTextBox.Text = unUser.noTypeChambre.ToString();
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
