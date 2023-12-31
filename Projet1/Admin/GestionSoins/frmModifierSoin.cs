﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Admin.GestionSoins
{
    public partial class frmModifierSoin : Form
    {
        public B56Projet1Equipe7DataSet.soinRow unSoin;
        public bool boolMod;

        public frmModifierSoin()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            char point = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            var exprDonnee = new Regex("^[0-9]{1,50}(" + point + "[0-9]{2})?$");

            if (tbDesc.Text.Trim() == "")
                errMessage.SetError(tbDesc, "La zone de texte pour la description ne peut pas être vide");
            else
                errMessage.SetError(tbDesc, "");

            if (tbPrix.Text.Trim() == "")
                errMessage.SetError(tbPrix, "La zone de texte pour le prix ne peut pas être vide");
            else if (!exprDonnee.IsMatch(tbPrix.Text))
                errMessage.SetError(tbPrix, "Le prix n'est pas dans un format valide");
            else
                errMessage.SetError(tbPrix, "");

            if (errMessage.GetError(tbDesc) == "" && errMessage.GetError(tbPrix) == "")
            {
                unSoin.description = tbDesc.Text;
                unSoin.noTypeSoin = (decimal)cbTypeSoin.SelectedValue;
                unSoin.prix = decimal.Parse(tbPrix.Text);
                boolMod = true;
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            boolMod = false;
            this.Close();
        }

        private void frmModifierSoin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.soin);
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.typeSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeSoinTableAdapter.Fill(this.b56Projet1Equipe7DataSet.typeSoin);
            
            tbNo.Text = unSoin.noSoin.ToString();
            tbDesc.Text = unSoin.description;
            tbDuree.Text = unSoin.duree;
            tbPrix.Text = unSoin.prix.ToString();
            cbTypeSoin.SelectedValue = unSoin.noTypeSoin;
        }
    }
}
