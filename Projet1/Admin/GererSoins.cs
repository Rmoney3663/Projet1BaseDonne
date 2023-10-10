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
    public partial class GererSoins : Form
    {
        public GererSoins()
        {
            InitializeComponent();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void GererSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.soin);

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.soinRow unSoin = b56Projet1Equipe7DataSet.soin.NewsoinRow();

            decimal noSoinMax = 0;

            if (b56Projet1Equipe7DataSet.soin.Count() != 0)
            {
                noSoinMax =
                b56Projet1Equipe7DataSet.soin.Rows.Cast<B56Projet1Equipe7DataSet.soinRow>().Max(r => r.noSoin);
            }

            unSoin.noSoin = noSoinMax + 1;
            unSoin.duree = "60";
            unSoin.description = "";

            GestionSoins.frmAjouterSoin frmAjout = new GestionSoins.frmAjouterSoin();

            frmAjout.unSoin = unSoin;
            frmAjout.ShowDialog();

            if (unSoin.description != "")
            {
                b56Projet1Equipe7DataSet.soin.AddsoinRow(unSoin);

                soinBindingSource.MoveLast();
                MessageBox.Show("Le soin " + (unSoin.noSoin).ToString() + " a été ajouté.", "Ajout d'un soin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Validate();
                this.soinBindingSource.EndEdit();
                this.soinTableAdapter.Update(this.b56Projet1Equipe7DataSet.soin);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSoins.SelectedRows.Count == 1 && dgSoins.SelectedRows[0].IsNewRow == false)
            {
                decimal noSoin = (decimal)dgSoins.SelectedRows[0].Cells[0].Value;

                B56Projet1Equipe7DataSet.soinRow unSoin = b56Projet1Equipe7DataSet.soin.FindBynoSoin(noSoin);

                GestionSoins.frmModifierSoin frmModifier = new GestionSoins.frmModifierSoin();

                frmModifier.unSoin = unSoin;
                frmModifier.boolMod = false;

                frmModifier.ShowDialog();

                if (frmModifier.boolMod == true)
                {
                    MessageBox.Show("Le soin " + (unSoin.noSoin).ToString() + " a été modifié.", "Modification d'un soin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Validate();
                    this.soinBindingSource.EndEdit();
                    this.soinTableAdapter.Update(this.b56Projet1Equipe7DataSet.soin);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner le soin que vous souhaitez modifier dans la liste.", "Sélection d'un soin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
