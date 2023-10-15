using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
