﻿using System;
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
    public partial class Rapport : Form
    {
        public Rapport()
        {
            InitializeComponent();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Rapport_Load_1(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.InfoChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.infoChambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.InfoChambre);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.chambre);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.InfoSoinPersonne'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.infoSoinPersonneTableAdapter.Fill(this.b56Projet1Equipe7DataSet.InfoSoinPersonne);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.InfoClientInvite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.infoClientInviteTableAdapter.Fill(this.b56Projet1Equipe7DataSet.InfoClientInvite);

        }

        private void infoClientInviteBindingSource_PositionChanged(object sender, EventArgs e)
        {
            nbSoin.Text = infoSoinPersonneDataGridView.RowCount.ToString();

        }


    }
}
