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
    public partial class Modifier : Form
    {
        public Modifier()
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
                MessageBox.Show("Modifier avec succee");
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception genere" + ex.Message);
            }
        }
        private void Modifier_Load(object sender, EventArgs e)
        {

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            string requpdate = "update Livre set titre = '" + txt_titre.Text + "',autheur='" + txt_autheur.Text +
                "',anne_sortie='" + txt_annee.Text + "',type_livre='" + type.Text +
                "',iditeur='" + txt_iditeur.Text + "'" +
                " where ISBN='" + txt_isbn.Text + "'";
            lancerRequet(requpdate);
        }
    }
}
