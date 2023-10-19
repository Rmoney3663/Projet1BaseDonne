using Projet1.Prepose;
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
        PlanifierSoins planifSoin = new PlanifierSoins();
        ReserverChambre reserverChambre = new ReserverChambre();

        public MenuAdministrateur()
        {
            InitializeComponent();
        }

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b56Projet1Equipe7DataSet.reservationChambre.WriteXml("reservationChambre.xml");
            b56Projet1Equipe7DataSet.reservationChambre.WriteXmlSchema("reservationChambre.xsd");
            b56Projet1Equipe7DataSet.planifSoin.WriteXml("planifSoin.xml");
            b56Projet1Equipe7DataSet.planifSoin.WriteXmlSchema("planifSoin.xsd");
            b56Projet1Equipe7DataSet.client.WriteXml("client.xml");
            b56Projet1Equipe7DataSet.client.WriteXmlSchema("client.xsd");
            b56Projet1Equipe7DataSet.invite.WriteXml("invite.xml");
            b56Projet1Equipe7DataSet.invite.WriteXmlSchema("invite.xsd");
            b56Projet1Equipe7DataSet.utilisateur.WriteXml("utilisateur.xml");
            b56Projet1Equipe7DataSet.utilisateur.WriteXmlSchema("utilisateur.xsd");
            b56Projet1Equipe7DataSet.soin.WriteXml("soin.xml");
            b56Projet1Equipe7DataSet.soin.WriteXmlSchema("soin.xsd");
            b56Projet1Equipe7DataSet.chambre.WriteXml("chambre.xml");
            b56Projet1Equipe7DataSet.chambre.WriteXmlSchema("chambre.xsd");
            b56Projet1Equipe7DataSet.typeChambre.WriteXml("typeChambre.xml");
            b56Projet1Equipe7DataSet.typeChambre.WriteXmlSchema("typeChambre.xsd");
            b56Projet1Equipe7DataSet.assistant.WriteXml("assistant.xml");
            b56Projet1Equipe7DataSet.assistant.WriteXmlSchema("assistant.xsd");
            b56Projet1Equipe7DataSet.assistantSoin.WriteXml("assistantSoin.xml");
            b56Projet1Equipe7DataSet.assistantSoin.WriteXmlSchema("assistantSoin.xsd");
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
            planifSoin.ShowDialog();
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
            reserverChambre.ShowDialog();
            this.Show();
        }

        private void visualiserDesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            rapport.ShowDialog();
            this.Show();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void MenuAdministrateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.soin);

        }
    }
}
