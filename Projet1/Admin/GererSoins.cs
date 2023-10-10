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

        private void GererSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.planifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.planifSoin);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistantSoin);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistantSoin);
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
            if (dgSoins.SelectedRows.Count == 1 && dgSoins.SelectedRows[0].IsNewRow == false)
            {
                // Vérification si le soin est planifié

                decimal noSoin = (decimal)dgSoins.SelectedRows[0].Cells[0].Value;

                bool booPlanifie = false;
                foreach (B56Projet1Equipe7DataSet.planifSoinRow uneLigne in b56Projet1Equipe7DataSet.planifSoin.Rows)
                {
                    if (uneLigne.noSoin == noSoin)
                    {
                        MessageBox.Show("Ce soin ne peut pas être supprimé, car il est déjà planifié.",
                            "Supprimer soin avec planification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        booPlanifie = true;
                        break;
                    }
                }

                if (booPlanifie == false)
                {
                    bool booAssistant = false;
                    foreach (B56Projet1Equipe7DataSet.assistantSoinRow uneLigne in b56Projet1Equipe7DataSet.assistantSoin.Rows)
                    {
                        if (uneLigne.noSoin == noSoin)
                        {
                            MessageBox.Show("Ce soin ne peut pas être supprimé, car il est présentement offert par un assistant.",
                                "Supprimer soin avec assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            booAssistant = true;
                            break;
                        }
                    }

                    if (booAssistant == false)
                    {
                        DialogResult reponse = MessageBox.Show("Êtes-vous certain de vouloir supprimer le soin numéro " + noSoin + "?",
                            "Supprimer un soin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (reponse == DialogResult.Yes)
                        {
                            soinBindingSource.RemoveCurrent();
                            this.Validate();
                            this.soinBindingSource.EndEdit();
                            this.soinTableAdapter.Update(this.b56Projet1Equipe7DataSet.soin);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner le soin que vous souhaitez supprimer dans la liste.", "Sélection d'un soin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
