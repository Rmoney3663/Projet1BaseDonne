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
            B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter planifSoinTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter();
            planifSoinTableAdapter.Fill(b56Projet1Equipe7DataSet.planifSoin);

            B56Projet1Equipe7DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.utilisateurTableAdapter();
            utilisateurTableAdapter.Fill(b56Projet1Equipe7DataSet.utilisateur);

            B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter clientTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter();
            clientTableAdapter.Fill(b56Projet1Equipe7DataSet.client);

            B56Projet1Equipe7DataSetTableAdapters.inviteTableAdapter inviteTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.inviteTableAdapter();
            inviteTableAdapter.Fill(b56Projet1Equipe7DataSet.invite);

            B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter assistantTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter();
            assistantTableAdapter.Fill(b56Projet1Equipe7DataSet.assistant);

            B56Projet1Equipe7DataSetTableAdapters.assistantSoinTableAdapter assistantSoinTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.assistantSoinTableAdapter();
            assistantSoinTableAdapter.Fill(b56Projet1Equipe7DataSet.assistantSoin);

            B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter soinTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter();
            soinTableAdapter.Fill(b56Projet1Equipe7DataSet.soin);

            B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter chambreTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter();
            chambreTableAdapter.Fill(b56Projet1Equipe7DataSet.chambre);

            B56Projet1Equipe7DataSetTableAdapters.typeChambreTableAdapter typeChambreTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.typeChambreTableAdapter();
            typeChambreTableAdapter.Fill(b56Projet1Equipe7DataSet.typeChambre);

            B56Projet1Equipe7DataSetTableAdapters.reservationChambreTableAdapter reservationChambreTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.reservationChambreTableAdapter();
            reservationChambreTableAdapter.Fill(b56Projet1Equipe7DataSet.reservationChambre);

            B56Projet1Equipe7DataSetTableAdapters.typeSoinTableAdapter typeSoinTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.typeSoinTableAdapter();
            typeSoinTableAdapter.Fill(b56Projet1Equipe7DataSet.typeSoin);

            b56Projet1Equipe7DataSet.WriteXml("tables.xml");
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
            b56Projet1Equipe7DataSet.typeSoin.WriteXml("typeSoin.xml");
            b56Projet1Equipe7DataSet.typeSoin.WriteXmlSchema("typeSoin.xsd");
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

       

        private void MenuAdministrateur_Load(object sender, EventArgs e)
        {
           

            
           
        }
    }
}
