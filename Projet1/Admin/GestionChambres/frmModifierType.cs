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

namespace Projet1.Admin.GestionChambres
{
    public partial class frmModifierType : Form
    {
        public B56Projet1Equipe7DataSet.typeChambreRow unUser;
        public string description { get; set; }
        public string haut { get; set; }
        public string bas { get; set; }
        public string moyen { get; set; }

        public bool boolMod;
        public frmModifierType()
        {
            InitializeComponent();
        }

        private void typeChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void frmModifierType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.typeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.typeChambre);
            descriptionTextBox.Text = unUser.description;
            prixHautTextBox.Text = unUser.prixHaut.ToString();
            prixBasTextBox.Text = unUser.prixBas.ToString();
            prixMoyenTextBox.Text = unUser.prixMoyen.ToString();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            boolMod = false;
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bool good = true;
            if (descriptionTextBox.Text.Trim() == "")
            {
                errMessage.SetError(descriptionTextBox, "Le description du chambre ne peut pas être vide");
                good = false;
            }

            if (prixHautTextBox.Text.Trim() == "")
            {
                errMessage.SetError(prixHautTextBox, "Le haut prix ne peut pas être vide");
                good = false;
            }

            if (prixBasTextBox.Text.Trim() == "")
            {
                errMessage.SetError(prixBasTextBox, "Le bas prix ne peut pas être vide");
                good = false;
            }

            if (prixMoyenTextBox.Text.Trim() == "")
            {
                errMessage.SetError(prixMoyenTextBox, "Le moyen prix ne peut pas être vide");
                good = false;
            }


            string description = descriptionTextBox.Text.Trim();
            bool isUniqueDescription = IsDescriptionUnique(description);

            if (!isUniqueDescription)
            {
                errMessage.SetError(descriptionTextBox, "La description du chambre doit être unique");
                good = false;
            }


            if (good == true)
            {
                unUser.description = descriptionTextBox.Text;
                unUser.prixBas = decimal.Parse(prixBasTextBox.Text);
                unUser.prixHaut = decimal.Parse(prixHautTextBox.Text);
                unUser.prixMoyen = decimal.Parse(prixMoyenTextBox.Text);
                boolMod = true;
                this.Close();

            }
        }

        private bool IsDescriptionUnique(string description)
        {
            string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
            bool isUnique = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM typeChambre WHERE description = @Description";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Description", description);

                    int count = (int)command.ExecuteScalar();
                    isUnique = (count == 0);
                }
            }
            return isUnique;
        }

    }
}
