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

namespace Projet1
{
    public partial class Connexion : Form
    {
        Prepose.MenuPrepose prepose = new Prepose.MenuPrepose();
        Admin.MenuAdministrateur admin = new Admin.MenuAdministrateur();
        
        static String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=B56Projet1Equipe7;Persist Security Info=True;User ID=B56Equipe7;Password=Password1";

        SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);

        public Connexion()
        {
            InitializeComponent();
            maConnexion.Open();
            tbPassword.PasswordChar = '*';
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            string NomUtilisateur = tbNomUtilisateur.Text;
            string Password = tbPassword.Text;

            string maRequete = "SELECT noTypeUtilisateur FROM utilisateur WHERE nomUtilisateur LIKE @NomUtilisateur AND password LIKE @Password;";

            SqlCommand maCommande = new SqlCommand(maRequete, maConnexion);
            maCommande.Parameters.AddWithValue("@NomUtilisateur", NomUtilisateur);
            maCommande.Parameters.AddWithValue("@Password", Password);

            string maRequete2 = "SELECT noUtilisateur FROM utilisateur WHERE nomUtilisateur LIKE @NomUtilisateur AND password LIKE @Password;";

            SqlCommand maCommande2 = new SqlCommand(maRequete2, maConnexion);
            maCommande2.Parameters.AddWithValue("@NomUtilisateur", NomUtilisateur);
            maCommande2.Parameters.AddWithValue("@Password", Password);

            if (maCommande.ExecuteScalar() != null)
            {
                int noTypeUtilisateur = Convert.ToInt32(maCommande.ExecuteScalar());
                int noUtilisateur = Convert.ToInt32(maCommande2.ExecuteScalar());
                resultat.Text = "Connexion réussie";
               

                if (noTypeUtilisateur == 1)
                {
                    this.Hide();
                    admin.LoginUser = noUtilisateur;
                    admin.ShowDialog();
                    tbNomUtilisateur.Text = "";
                    tbPassword.Text = "";
                    resultat.Text = "";
                    this.Show();
                }
                if (noTypeUtilisateur == 2)
                {
                    this.Hide();
                    prepose.ShowDialog();
                    tbNomUtilisateur.Text = "";
                    tbPassword.Text = "";
                    resultat.Text = "";
                    this.Show();
                }

            }
            else
            {
                resultat.Text = "Connexion échouée";
            }

        }

        
    }
}
