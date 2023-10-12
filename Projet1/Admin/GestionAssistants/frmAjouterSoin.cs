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
        public frmAjouterSoin()
        {
            InitializeComponent();

            
            string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT s.noSoin AS SoinNoSoin, s.description FROM soin s LEFT JOIN assistantSoin a ON s.noSoin = a.noSoin WHERE a.noSoin IS NULL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                        descriptionComboBox.ValueMember = "description";
                    }
                }
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
            // TODO: This line of code loads data into the 'b56Projet1Equipe7DataSet.soin' table. You can move, or remove it, as needed.

            //this.soinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.soin);
            /*
            string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT  description FROM soin s LEFT JOIN assistantSoin a ON s.noSoin = a.noSoin WHERE a.noSoin IS NULL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        descriptionComboBox.DataSource = dataTable;
                        descriptionComboBox.DisplayMember = "description";
                    }
                }
            }*/
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
                string selectedDescription = descriptionComboBox.SelectedValue.ToString();
                decimal noSoin = descriptionToNoSoin[selectedDescription];
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
