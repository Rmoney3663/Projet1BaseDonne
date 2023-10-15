using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Prepose.PlanificationSoins
{
    public partial class frmAjouterPlanifSoin : Form
    {
        public frmAjouterPlanifSoin()
        {
            InitializeComponent();
        }

        private void planifSoinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planifSoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmAjouterPlanifSoin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.soin);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistant);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.b56Projet1Equipe7DataSet.invite);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.b56Projet1Equipe7DataSet.client);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.planifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.planifSoin);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.planifSoinTableAdapter.FillBy(this.b56Projet1Equipe7DataSet.planifSoin);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
