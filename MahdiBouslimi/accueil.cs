using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahdiBouslimi
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

        private void gestionLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void authentificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void accueil_Load(object sender, EventArgs e)
        {

        }

        private void gestionLivreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gestion_livre gt = new Gestion_livre();
            gt.Show();

        }

        private void authentificationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gestion_user gu = new Gestion_user();
            gu.Show();

        }
    }
}