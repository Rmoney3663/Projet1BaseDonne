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
    public partial class GererAssistants : Form
    {
        public GererAssistants()
        {
            InitializeComponent();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void GererAssistants_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistantSoin);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.planifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.planifSoin);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.b56Projet1Equipe7DataSet.assistant);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.soin);

            lbTotale.Text = assistantBindingSource.Count.ToString();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            assistantBindingSource.MoveFirst();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            assistantBindingSource.MovePrevious();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            assistantBindingSource.MoveNext();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            assistantBindingSource.MoveLast();
            int position = assistantBindingSource.Position + 1;
            lbPosition.Text = position.ToString();
        }

    }
}
