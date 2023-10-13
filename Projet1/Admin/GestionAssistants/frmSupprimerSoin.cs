using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Admin.GestionAssistants
{    
    public partial class frmSupprimerSoin : Form
    {
        public B56Projet1Equipe7DataSet.assistantSoinRow deleteSoin;
        public frmSupprimerSoin()
        {
            InitializeComponent();
            
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmSupprimerSoin_Load(object sender, EventArgs e)
        {
            this.soinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.soin);

            decimal soinValue = deleteSoin.noSoin;

            for (int i = 0; i < descriptionComboBox.Items.Count; i++)
            {
                DataRowView item = (DataRowView)descriptionComboBox.Items[i];

                decimal comboBoxValue = (decimal)item["noSoin"]; 

                if (comboBoxValue == soinValue)
                {
                    descriptionComboBox.SelectedIndex = i;
                    break;
                }
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            deleteSoin.noSoin = -1;
            this.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
