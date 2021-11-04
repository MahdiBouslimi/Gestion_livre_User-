using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahdiBouslimi
{
    public partial class AjouterLivre : Form
    {
        public AjouterLivre()
        {
            InitializeComponent();
        }
        public string reqcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\bd\\gestion_beblio.accdb;";


        public void lancerRequet(string requet)
        {

            OleDbConnection ocn = new OleDbConnection();
            OleDbCommand ocm = new OleDbCommand();
            ocn.ConnectionString = reqcon;
            try
            {
                ocn.Open();
                ocm.Connection = ocn;
                ocm.CommandText = requet;
                ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("insertion avec succee");
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception genere" + ex.Message);
            }
        }
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {

            string textinsert;
            textinsert = "insert into Livre values (" + "'" + txt_isbn.Text + "','" + txt_titre.Text + "','" + txt_autheur.Text + "','" +
                                    txt_annee.Text + "','" + type.Text + "','" + txt_iditeur.Text + "'" + ")";
            lancerRequet(textinsert);
        }

        private void AjouterLivre_Load(object sender, EventArgs e)
        {

        }
    }
}
