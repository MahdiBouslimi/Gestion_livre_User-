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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string reqcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\bd\\gestion_beblio.accdb;";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_connexion_Click_1(object sender, EventArgs e)
        {
            string txtsql;
            txtsql = (" SELECT count(login) FROM authentification WHERE login='" + txt_log.Text + "'AND password= '" + txt_pass.Text + "'");
            OleDbConnection ocn = new OleDbConnection(reqcon);

            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            Int32 ival;
            try
            {
                ocm.Connection.Open();
                ival = Convert.ToInt32(ocm.ExecuteScalar());
                if (ival == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("verefier l'identifient ", "erreur login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_log.Text = "";
                    txt_pass.Text = "";
                    txt_log.Focus();
                    ocm.Connection.Close();



                }
                else
                {
                    ocm.Connection.Close();
                    accueil f2 = new accueil();
                    f2.Show();
                    Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
