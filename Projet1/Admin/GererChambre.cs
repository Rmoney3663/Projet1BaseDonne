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


    }
}
