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

namespace Projet1.Prepose.ReservationChambres
{
    public partial class frmAjoutReservation : Form
    {
        public B56Projet1Equipe7DataSet.reservationChambreRow uneReservation;

        public frmAjoutReservation()
        {
            InitializeComponent();
        }

        private void frmAjoutReservation_Load(object sender, EventArgs e)
        {
            // Set up datetime pickers
            dpArrivee.MinDate = DateTime.Today;
            dpArrivee.Value = DateTime.Today;
            dpDepart.MinDate = DateTime.Today.AddDays(1);
            dpDepart.Value = DateTime.Today.AddDays(1);

            string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Remplir comboBox des clients
                string query = "SELECT noClient, CONCAT(nom, ', ', prenom, ' (', noClient, ')') AS nomPrenom FROM Client";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cbClient.DataSource = dataTable;
                        cbClient.DisplayMember = "nomPrenom";
                        cbClient.ValueMember = "noClient";
                    }
                }

                // Remplir le datagridview des chambres
                string query2 = "SELECT noChambre, emplacement, decorations, prixHaut, prixBas, prixMoyen FROM Chambre " +
                    "LEFT JOIN typeChambre ON Chambre.noTypeChambre = typeChambre.noTypeChambre";
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        dgChambres.DataSource = dataTable;
                    }
                }

                connection.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (dgChambres.SelectedRows.Count != 0)
                {
                    if (cbClient.Items.Count != 0)
                    {
                        // Vérif date d'arrivée
                        if (dpArrivee.Value < DateTime.Today)
                        {
                            errMessage.SetError(dpArrivee, "La date d'arrivée ne peut pas être dans le passé!");
                        }
                        else
                        {
                            string query = "SELECT * FROM reservationChambre " +
                                "WHERE noChambre = @noChambre AND dateArrivee <= @dateArrivee AND dateDepart > @dateArrivee";

                            SqlCommand maCommande = new SqlCommand(query, connection);
                            maCommande.Parameters.AddWithValue("@noChambre", dgChambres.SelectedRows[0].Cells[0].Value);
                            maCommande.Parameters.AddWithValue("@dateArrivee", dpArrivee.Value);

                            object dateCorrecte = maCommande.ExecuteScalar();

                            if (dateCorrecte != null)
                            {
                                errMessage.SetError(dpArrivee, "Cette chambre est occupée par quelqu'un d'autre à cette date");
                            }
                            else
                            {
                                errMessage.SetError(dpArrivee, "");
                            }
                        }

                        // Vérif date de départ
                        if (dpDepart.Value < DateTime.Today.AddDays(1))
                        {
                            errMessage.SetError(dpDepart, "La date de départ doit être plus tard qu'aujourd'hui!");
                        }
                        else if (dpDepart.Value <= dpArrivee.Value)
                        {
                            errMessage.SetError(dpDepart, "La date de départ ne peut pas être la même ou plus petite que la date d'arrivée!");
                        }
                        else
                        {
                            string query = "SELECT * FROM reservationChambre " +
                                "WHERE noChambre = @noChambre AND dateArrivee < @dateDepart AND dateDepart >= @dateDepart";

                            SqlCommand maCommande = new SqlCommand(query, connection);
                            maCommande.Parameters.AddWithValue("@noChambre", dgChambres.SelectedRows[0].Cells[0].Value);
                            maCommande.Parameters.AddWithValue("@dateDepart", dpDepart.Value);

                            object dateCorrecte = maCommande.ExecuteScalar();

                            if (dateCorrecte != null)
                            {
                                errMessage.SetError(dpDepart, "Cette chambre est occupée par quelqu'un d'autre à cette date");
                            }
                            else
                            {
                                errMessage.SetError(dpDepart, "");
                            }
                        }
                        
                        if (errMessage.GetError(dpArrivee) == "" && errMessage.GetError(dpDepart) == "")
                        {
                            uneReservation.noClient = (decimal)cbClient.SelectedValue;
                            uneReservation.dateArrivee = dpArrivee.Value;
                            uneReservation.dateDepart = dpDepart.Value;
                            uneReservation.noChambre = (decimal)dgChambres.SelectedRows[0].Cells[0].Value;
                            uneReservation.NbPersonnes = numNbPers.Value;
                            this.Close();
                        }
                    }
                    else
                    {
                        errMessage.SetError(cbClient,"Veuillez sélectionner un client");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner la chambre que vous souhaitez réserver", "Sélection chambre", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }

                connection.Close();

            }   
        }
    }
}
