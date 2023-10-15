using Projet1.Admin.GestionChambres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Admin
{
    public partial class GererChambre : Form
    {
        public GererChambre()
        {
            InitializeComponent();
        }

        private void typeChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void GererChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.chambre' table. You can move, or remove it, as needed.
            this.chambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.chambre);
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.typeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.typeChambre);
            lbTotale.Text = typeChambreBindingSource.Count.ToString();
            int position = typeChambreBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
            if (position == 0)
            {
                btnAjouterChambre.Enabled = false;
                btnModificationChambre.Enabled = false;
                btnSupprimerChambre.Enabled = false;

            }else
            {
                btnAjouterChambre.Enabled = true;
                btnModificationChambre.Enabled = true;
                btnSupprimerChambre.Enabled = true;
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MoveFirst();
            int position = typeChambreBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MovePrevious();
            int position = typeChambreBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MoveNext();
            int position = typeChambreBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MoveLast();
            int position = typeChambreBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.typeChambreRow unUser = b56Projet1Equipe7DataSet.typeChambre.NewtypeChambreRow();
            decimal noContratMax = 0;
            foreach (B56Projet1Equipe7DataSet.assistantRow uneLigne in b56Projet1Equipe7DataSet.assistant.Rows)
                if (uneLigne.noAssistant > noContratMax) noContratMax = uneLigne.noAssistant;

            unUser.noTypeChambre = noContratMax + 1;
            unUser.description = "";
            unUser.prixBas = 0;
            unUser.prixHaut = 0;
            unUser.prixMoyen = 0;
            frmAjouterType frmAjouterType = new frmAjouterType();
            frmAjouterType.unUser = unUser;
            frmAjouterType.boolMod = false;
            frmAjouterType.ShowDialog();

            if (frmAjouterType.boolMod == true)
            {
                
                b56Projet1Equipe7DataSet.typeChambre.AddtypeChambreRow(unUser);

                MessageBox.Show(" Le type de chambre " + unUser.description.ToString() + " a été ajouté. ",
                   "Ajout d'un type de chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Validate();
                this.typeChambreBindingSource.EndEdit();
                this.typeChambreTableAdapter.Update(this.b56Projet1Equipe7DataSet.typeChambre);
                lbTotale.Text = typeChambreBindingSource.Count.ToString();

                btnAjouterChambre.Enabled = true;
                btnModificationChambre.Enabled = true;
                btnSupprimerChambre.Enabled = true;
            }


        }
    }
}
