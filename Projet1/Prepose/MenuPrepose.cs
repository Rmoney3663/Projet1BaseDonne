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
            Connexion connexionForm = new Connexion();
            this.Hide();
            //this.Close();
            connexionForm.ShowDialog();
            this.Show();
        }
    }
}
