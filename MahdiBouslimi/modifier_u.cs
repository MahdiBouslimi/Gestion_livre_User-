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
    public partial class modifier_u : Form
    {
        public modifier_u()
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
        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            string requpdate = "update authentification set Nom = '" + txt_nom.Text + "',type_compte='" + txt_type.Text +
                "',description='" + txt_discription.Text +

                "' where login='" + txt_login.Text + "'And password='" + txt_pwd.Text + "'";
            lancerRequet(requpdate);

        }

        private void modifier_u_Load(object sender, EventArgs e)
        {

        }
    }
}