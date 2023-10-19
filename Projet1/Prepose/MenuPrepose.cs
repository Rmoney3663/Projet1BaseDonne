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

        private void planifSoinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planifSoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void MenuPrepose_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.planifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.planifSoin);

        }
    }
}
