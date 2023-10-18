using Projet1.Admin.GestionChambres;
using Projet1.Prepose.PlanificationSoins;
using Projet1.Prepose.ReservationChambres;
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
    public partial class ReserverChambre : Form
    {
        public ReserverChambre()
        {
            InitializeComponent();
        }

        private void reservationChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.b56Projet1Equipe7DataSet);

        }

        private void ReservationChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'b56Projet1Equipe7DataSet.reservationChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationChambreTableAdapter.Fill(this.b56Projet1Equipe7DataSet.reservationChambre);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            B56Projet1Equipe7DataSet.reservationChambreRow uneReservation = b56Projet1Equipe7DataSet.reservationChambre.NewreservationChambreRow();
            uneReservation.dateArrivee = DateTime.MinValue;

            frmAjoutReservation frmAjout = new frmAjoutReservation();
            frmAjout.uneReservation = uneReservation;

            frmAjout.ShowDialog();

            if (uneReservation.dateArrivee != DateTime.MinValue)
            {
                b56Projet1Equipe7DataSet.reservationChambre.AddreservationChambreRow(uneReservation);

                reservationChambreBindingSource.MoveLast();
                MessageBox.Show("Une nouvelle réservation de chambre a été ajoutée.", "Ajout d'une réservation de chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Validate();
                this.reservationChambreBindingSource.EndEdit();
                this.reservationChambreTableAdapter.Update(this.b56Projet1Equipe7DataSet.reservationChambre);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgReservations.SelectedRows.Count != 0)
            {
                if ((DateTime)dgReservations.SelectedRows[0].Cells[2].Value >= DateTime.Today)
                {
                    DialogResult reponse = MessageBox.Show("Êtes-vous certain de vouloir supprimer cette réservation de chambre ?",
                        "Supprimer une réservation de chambre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (reponse == DialogResult.Yes)
                    {
                        reservationChambreBindingSource.RemoveCurrent();
                        this.Validate();
                        this.reservationChambreBindingSource.EndEdit();
                        this.reservationChambreTableAdapter.Update(this.b56Projet1Equipe7DataSet.reservationChambre);
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer cette réservation, car la date d'arrivée est déjà passée",
                        "Date d'arrivée antérieure à la date actuelle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner la réservation de chambre que vous souhaitez supprimer", "Sélection de réservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
