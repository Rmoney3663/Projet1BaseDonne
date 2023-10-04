using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class Connexion : Form
    {
        Prepose.MenuPrepose prepose = new Prepose.MenuPrepose();

        public Connexion()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            prepose.ShowDialog();
            this.Close();
        }
    }
}
