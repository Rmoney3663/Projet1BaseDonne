using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Prepose
{
    public partial class MenuPrepose : Form
    {
        PlanifierSoins planifier = new PlanifierSoins();
        ReserverChambre reserver = new ReserverChambre();
        GererClientsInvites gerer = new GererClientsInvites();

        public MenuPrepose()
        {
            InitializeComponent();
        }

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Connexion connexionForm = new Connexion();
            this.Hide();*/
            this.Close();
            /*connexionForm.ShowDialog();
            this.Show();*/
        }

        private void gérerLesClientsEtLeursInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gerer.ShowDialog();
            this.Show();
        }

        private void planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            planifier.ShowDialog();
            this.Show();
        }

        private void réserverDesChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            reserver.ShowDialog();
            this.Show();
        }
    }
}
