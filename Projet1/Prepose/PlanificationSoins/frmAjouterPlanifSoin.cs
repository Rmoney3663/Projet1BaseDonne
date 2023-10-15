﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Prepose.PlanificationSoins
{
    public partial class frmAjouterPlanifSoin : Form
    {
        public B56Projet1Equipe7DataSet.planifSoinRow unePlanif;

        public frmAjouterPlanifSoin()
        {
            InitializeComponent();
        }

        private void frmAjouterPlanifSoin_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Remplir comboBox des personnes
                string query = "SELECT noClient AS noPersonne, CONCAT(nom, ', ', prenom, ' (', noClient, ')') AS nomPrenom FROM Client " +
                               "UNION SELECT noInvite AS noPersonne, CONCAT(nomPrenom, ' (', noInvite, ')') AS nomPrenom FROM Invite";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cbNoPersonne.DataSource = dataTable;
                        cbNoPersonne.DisplayMember = "nomPrenom";
                        cbNoPersonne.ValueMember = "noPersonne";
                    }
                }

                // Remplir comboBox des soins
                string query2 = "SELECT noSoin, CONCAT(noSoin, ' ', description) AS description FROM Soin";

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cbNoSoin.DataSource = dataTable;
                        cbNoSoin.DisplayMember = "description";
                        cbNoSoin.ValueMember = "noSoin";
                    }
                }

                connection.Close();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbNoAssistant.SelectedValue.ToString());
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remplirCbAssistant(object sender, EventArgs e)
        {
            if (!(cbNoSoin.SelectedValue is System.Data.DataRowView))
            {
                cbNoAssistant.DataSource = null;
                cbNoAssistant.Items.Clear();

                string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Remplir comboBox des assistants
                    string query = "SELECT assistantSoin.noAssistant, CONCAT(assistantSoin.noAssistant, ' ', nom, ', ', prenom) AS nomPrenom FROM assistant " +
                        "INNER JOIN assistantSoin ON assistant.noAssistant = assistantSoin.noAssistant " +
                        "WHERE noSoin = @noSoin";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        decimal noSoin = (decimal)cbNoSoin.SelectedValue;
                        command.Parameters.AddWithValue("@noSoin", noSoin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            cbNoAssistant.DataSource = dataTable;
                            cbNoAssistant.DisplayMember = "nomPrenom";
                            cbNoAssistant.ValueMember = "noAssistant";
                        }
                    }
                }
            }
        }
    }
}
