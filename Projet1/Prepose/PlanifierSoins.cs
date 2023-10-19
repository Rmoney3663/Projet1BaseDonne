using Projet1.Prepose.PlanificationSoins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Prepose
{
    public partial class PlanifierSoins : Form
    {
        public PlanifierSoins()
        {
            InitializeComponent();
        }

        private void planifSoinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planifSoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void planifSoinBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.planifSoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void PlanifierSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.planifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.planifSoin);

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.planifSoinRow unePlanif = b56Projet1Equipe7DataSet.planifSoin.NewplanifSoinRow();
            unePlanif.dateHeure = DateTime.MinValue;

            frmAjouterPlanifSoin frmAjout = new frmAjouterPlanifSoin();
            frmAjout.unePlanif = unePlanif;
            
            frmAjout.ShowDialog();

            if (unePlanif.dateHeure != DateTime.MinValue)
            {
                b56Projet1Equipe7DataSet.planifSoin.AddplanifSoinRow(unePlanif);

                planifSoinBindingSource.MoveLast();
                MessageBox.Show("Une nouvelle planification de soin a été ajoutée.", "Ajout d'une planification de soin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Validate();
                this.planifSoinBindingSource.EndEdit();
                this.planifSoinTableAdapter.Update(this.b56Projet1Equipe7DataSet.planifSoin);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgPlanif.SelectedRows.Count == 1 && dgPlanif.SelectedRows[0].IsNewRow == false)
            {
                if (b56Projet1Equipe7DataSet.planifSoin[dgPlanif.SelectedRows[0].Index].dateHeure < DateTime.Now)
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer une planification de soin si le soin a déjà été donné.", "Supprimer une planification de soin déjà passée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult reponse = MessageBox.Show("Êtes-vous certain de vouloir supprimer cette planification de soin ?",
                        "Supprimer une planification de soin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (reponse == DialogResult.Yes)
                    {
                        planifSoinBindingSource.RemoveCurrent();
                        this.Validate();
                        this.planifSoinBindingSource.EndEdit();
                        this.planifSoinTableAdapter.Update(this.b56Projet1Equipe7DataSet.planifSoin);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner la planification de soin que vous souhaitez supprimer dans la liste.", "Sélection d'une planification de soin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            b56Projet1Equipe7DataSet.planifSoin.WriteXml("planifSoin.xml");
            b56Projet1Equipe7DataSet.planifSoin.WriteXmlSchema("planifSoin.xsd");
            this.Close();
        }
    }
}
