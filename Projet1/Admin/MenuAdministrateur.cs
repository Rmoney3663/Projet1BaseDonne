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
    public partial class MenuAdministrateur : Form
    {
        public int LoginUser { get; set; }

        GererUtilisateur gererUtilisateur = new GererUtilisateur();
        Prepose.GererClientsInvites gererClient = new Prepose.GererClientsInvites();
        GererAssistants gererAssistants = new GererAssistants();
        GererSoins gererSoins = new GererSoins();
        GererChambre gererChambre = new GererChambre();
        Rapport rapport = new Rapport();

        public MenuAdministrateur()
        {
            InitializeComponent();
        }

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Connexion connexionForm = new Connexion();
           // this.Hide();
            this.Close();
            //connexionForm.ShowDialog();
            //this.Show();
        }

        private void gérerLesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            gererUtilisateur.LoginUser = LoginUser;
            gererUtilisateur.ShowDialog();
            this.Show();
        }

        private void gérerLesClientsEtLeursInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gererClient.ShowDialog();
            this.Show();
        }

        private void gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gererAssistants.ShowDialog();
            this.Show();
        }

        private void gérerLesSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gererSoins.ShowDialog();
            this.Show();
        }

        private void planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void gérerLesChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gererChambre.ShowDialog();
            this.Show();
        }

        private void réserverDesChambrespourLesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void visualiserDesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            rapport.ShowDialog();
            this.Show();
        }
    }
}
