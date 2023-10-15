using Projet1.Admin.GestionChambres;
using Projet1.B56Projet1Equipe7DataSetTableAdapters;
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
            foreach (B56Projet1Equipe7DataSet.typeChambreRow uneLigne in b56Projet1Equipe7DataSet.typeChambre.Rows)
                if (uneLigne.noTypeChambre > noContratMax) noContratMax = uneLigne.noTypeChambre;

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

        private void btnModifierType_Click(object sender, EventArgs e)
        {
            string no = noTypeChambreTextBox.Text;
            decimal noid = decimal.Parse(no);

            B56Projet1Equipe7DataSet.typeChambreRow unUser = b56Projet1Equipe7DataSet.typeChambre.FindBynoTypeChambre(noid);

            if (unUser != null)
            {
                frmModifierType frmModifierType = new frmModifierType();
                frmModifierType.unUser = unUser;
                frmModifierType.boolMod = false;
                frmModifierType.ShowDialog();                

                if (frmModifierType.boolMod == true)
                {
                    MessageBox.Show("Le chambre " + unUser.noTypeChambre.ToString() + " a été modifié. ",
                                    "Modification d'un chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Validate();
                    this.typeChambreBindingSource.EndEdit();
                    this.typeChambreTableAdapter.Update(unUser);
                }
                else
                {
                    MessageBox.Show("Vous avez annulez la modification du chambre " + unUser.description.ToString(),
                                    "Modification d'un chambre Annuler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void btnSupprimerType_Click(object sender, EventArgs e)
        {
            string no = noTypeChambreTextBox.Text;
            decimal noid = decimal.Parse(no);

            B56Projet1Equipe7DataSet.typeChambreRow unUser = b56Projet1Equipe7DataSet.typeChambre.FindBynoTypeChambre(noid);
           

            if (unUser != null)
            {
                frmSupprimerType frmSupprimerType = new frmSupprimerType();
                frmSupprimerType.boolMod = false;
                frmSupprimerType.unUser = unUser;
                frmSupprimerType.ShowDialog();

                if (frmSupprimerType.boolMod == true)
                {
                    decimal typeToDelete = unUser.noTypeChambre;                  

                    if (chambreDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("Impossible de supprimer ce chambre. Des chambres lui sont assignées.",
                                        "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.typeChambreTableAdapter.Delete(unUser.noTypeChambre, unUser.description, unUser.prixHaut, unUser.prixBas, unUser.prixMoyen);
                        MessageBox.Show("Le chambre " + unUser.description.ToString() + " a été supprimé. ",
                                        "Suppression d'un chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        b56Projet1Equipe7DataSet.typeChambre.RemovetypeChambreRow(unUser);
                        chambreDataGridView.DataSource = chambreBindingSource;

                        lbTotale.Text = typeChambreBindingSource.Count.ToString();
                        typeChambreBindingSource.MoveFirst();
                        int position = typeChambreBindingSource.Position + 1;
                        lbPosition.Text = position.ToString();

                        if (position == 0)
                        {
                            btnAjouterChambre.Enabled = false;
                            btnModificationChambre.Enabled = false;
                            btnSupprimerChambre.Enabled = false;

                        }
                        else
                        {
                            btnAjouterChambre.Enabled = true;
                            btnModificationChambre.Enabled = true;
                            btnSupprimerChambre.Enabled = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vous avez annulé la suppression du chambre " + unUser.description.ToString() ,
                                  "Suppression d'un chambre annulée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
