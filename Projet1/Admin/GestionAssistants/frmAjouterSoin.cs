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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet1.Admin.GestionAssistants
{
    public partial class frmAjouterSoin : Form
    {
        public B56Projet1Equipe7DataSet.assistantSoinRow unSoin;
        Dictionary<string, decimal> descriptionToNoSoin = new Dictionary<string, decimal>();

        public frmAjouterSoin(decimal assistantID)
        {
            InitializeComponent();

            // Ensure the data is up to date
            //assistantTableAdapter.Fill(b56Projet1Equipe7DataSet.assistant);
            //assistantSoinTableAdapter.Fill(b56Projet1Equipe7DataSet.assistantSoin);

            string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Fetch available soin options for the assistant based on assistantID
                string query = "SELECT s.noSoin AS SoinNoSoin, s.description " +
                               "FROM soin s " +
                               "WHERE s.noSoin NOT IN (SELECT noSoin FROM assistantSoin WHERE noAssistant = @AssistantID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AssistantID", assistantID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            decimal noSoin = Convert.ToDecimal(row["SoinNoSoin"]);
                            string description = row["description"].ToString();
                            descriptionToNoSoin[description] = noSoin;
                        }

                        descriptionComboBox.DataSource = dataTable;
                        descriptionComboBox.DisplayMember = "description";
                        descriptionComboBox.ValueMember = "SoinNoSoin"; 



                    }
                }
            }

            foreach (var key in descriptionToNoSoin.Keys)
            {
                Console.WriteLine("Dictionary Key: " + key);
            }

            foreach (var key in descriptionToNoSoin.Values)
            {
                Console.WriteLine("Dictionary Value: " + key);
            }
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

       


        private void frmAjouterSoin_Load(object sender, EventArgs e)
        {
            if (descriptionComboBox.Items.Count == 0)
            {
                descriptionComboBox.Enabled = false;
                MessageBox.Show("Il n'y a aucun soin ou vous avez tous les soin possibles");
                //this.Close();
            }
            else
            {
                descriptionComboBox.Enabled = true;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            unSoin.noSoin = -1;
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (descriptionComboBox.SelectedItem != null)
            {
                decimal noSoin = (decimal)descriptionComboBox.SelectedValue;
                unSoin.noSoin = noSoin;
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une description avant de l'ajouter.");
            }
        }






    }
}
