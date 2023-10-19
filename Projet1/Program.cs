using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            B56Projet1Equipe7DataSet dataset = new B56Projet1Equipe7DataSet();

            // Pass the dataset as a parameter to the main form
            Connexion mainForm = new Connexion(dataset);

            // Hook into the ApplicationExit event to save the dataset before the application exits
            Application.ApplicationExit += (sender, e) =>
            {
                B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter planifSoinTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter();
                planifSoinTableAdapter.Fill(dataset.planifSoin);

                B56Projet1Equipe7DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.utilisateurTableAdapter();
                utilisateurTableAdapter.Fill(dataset.utilisateur);

                B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter clientTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter();
                clientTableAdapter.Fill(dataset.client);

                B56Projet1Equipe7DataSetTableAdapters.inviteTableAdapter inviteTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.inviteTableAdapter();
                inviteTableAdapter.Fill(dataset.invite);

                B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter assistantTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter();
                assistantTableAdapter.Fill(dataset.assistant);

                B56Projet1Equipe7DataSetTableAdapters.assistantSoinTableAdapter assistantSoinTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.assistantSoinTableAdapter();
                assistantSoinTableAdapter.Fill(dataset.assistantSoin);

                B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter soinTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter();
                soinTableAdapter.Fill(dataset.soin);

                B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter chambreTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter();
                chambreTableAdapter.Fill(dataset.chambre);

                B56Projet1Equipe7DataSetTableAdapters.typeChambreTableAdapter typeChambreTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.typeChambreTableAdapter();
                typeChambreTableAdapter.Fill(dataset.typeChambre);

                B56Projet1Equipe7DataSetTableAdapters.reservationChambreTableAdapter reservationChambreTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.reservationChambreTableAdapter();
                reservationChambreTableAdapter.Fill(dataset.reservationChambre);

                B56Projet1Equipe7DataSetTableAdapters.typeSoinTableAdapter typeSoinTableAdapter = new B56Projet1Equipe7DataSetTableAdapters.typeSoinTableAdapter();
                typeSoinTableAdapter.Fill(dataset.typeSoin);

                dataset.reservationChambre.WriteXml("reservationChambre.xml");
                dataset.reservationChambre.WriteXmlSchema("reservationChambre.xsd");
                dataset.planifSoin.WriteXml("planifSoin.xml");
                dataset.planifSoin.WriteXmlSchema("planifSoin.xsd");
                dataset.client.WriteXml("client.xml");
                dataset.client.WriteXmlSchema("client.xsd");
                dataset.invite.WriteXml("invite.xml");
                dataset.invite.WriteXmlSchema("invite.xsd");
                dataset.utilisateur.WriteXml("utilisateur.xml");
                dataset.utilisateur.WriteXmlSchema("utilisateur.xsd");
                dataset.soin.WriteXml("soin.xml");
                dataset.soin.WriteXmlSchema("soin.xsd");
                dataset.chambre.WriteXml("chambre.xml");
                dataset.chambre.WriteXmlSchema("chambre.xsd");
                dataset.typeChambre.WriteXml("typeChambre.xml");
                dataset.typeChambre.WriteXmlSchema("typeChambre.xsd");
                dataset.assistant.WriteXml("assistant.xml");
                dataset.assistant.WriteXmlSchema("assistant.xsd");
                dataset.assistantSoin.WriteXml("assistantSoin.xml");
                dataset.assistantSoin.WriteXmlSchema("assistantSoin.xsd");
                dataset.typeSoin.WriteXml("typeSoin.xml");
                dataset.typeSoin.WriteXmlSchema("typeSoin.xsd");
                dataset.WriteXml("tables.xml");
            };
            /*
            System.Timers.Timer autoSaveTimer = new System.Timers.Timer();
            autoSaveTimer.Interval = TimeSpan.FromSeconds(5).TotalMilliseconds;
            autoSaveTimer.Elapsed += (sender, e) =>
            {
                dataset.reservationChambre.WriteXml("reservationChambre.xml");
                dataset.reservationChambre.WriteXmlSchema("reservationChambre.xsd");
                dataset.planifSoin.WriteXml("planifSoin.xml");
                dataset.planifSoin.WriteXmlSchema("planifSoin.xsd");
                dataset.client.WriteXml("client.xml");
                dataset.client.WriteXmlSchema("client.xsd");
                dataset.invite.WriteXml("invite.xml");
                dataset.invite.WriteXmlSchema("invite.xsd");
                dataset.utilisateur.WriteXml("utilisateur.xml");
                dataset.utilisateur.WriteXmlSchema("utilisateur.xsd");
                dataset.soin.WriteXml("soin.xml");
                dataset.soin.WriteXmlSchema("soin.xsd");
                dataset.chambre.WriteXml("chambre.xml");
                dataset.chambre.WriteXmlSchema("chambre.xsd");
                dataset.typeChambre.WriteXml("typeChambre.xml");
                dataset.typeChambre.WriteXmlSchema("typeChambre.xsd");
                dataset.assistant.WriteXml("assistant.xml");
                dataset.assistant.WriteXmlSchema("assistant.xsd");
                dataset.assistantSoin.WriteXml("assistantSoin.xml");
                dataset.assistantSoin.WriteXmlSchema("assistantSoin.xsd");
            };
            autoSaveTimer.Start();
            */
            Application.Run(mainForm);
        }

       
    }
}
