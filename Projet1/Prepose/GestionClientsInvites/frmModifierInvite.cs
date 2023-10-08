using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.Prepose.GestionClientsInvites
{
    public partial class frmModifierInvite : Form
    {
        public B56Projet1Equipe7DataSet.inviteRow unInvite;
        public bool boolMod;

        public frmModifierInvite()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
                errMessage.SetError(tbNom, "La zone de texte pour le nom ne peut pas être vide");
            else
                errMessage.SetError(tbNom, "");

            if (errMessage.GetError(tbNom) == "")
            {
                unInvite.nomPrenom = tbNom.Text;
                boolMod = true;
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            boolMod = false;
            this.Close();
        }

        private void frmModifierInvite_Load(object sender, EventArgs e)
        {
            tbNoClient.Text = unInvite.noClient.ToString();
            tbNom.Text = unInvite.nomPrenom;
            tbNoInvite.Text = unInvite.noInvite.ToString();
        }
    }
}
