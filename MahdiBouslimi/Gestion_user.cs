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
    public partial class Gestion_user : Form
    {
        public Gestion_user()
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
                MessageBox.Show("supprimer avec succee");
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception genere" + ex.Message);
            }
        }

        public void charche_listeUser()
        {
            dataGridView2.Rows.Clear();
            string txtsql;
            txtsql = "select * from authentification";
            OleDbConnection ocn = new OleDbConnection(reqcon);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                string[] row = new string[] {reader.GetValue(0).ToString(),reader.GetValue(1).ToString(),reader.GetValue(2).ToString(),reader.GetValue(3).ToString(),
                                              reader.GetValue(4).ToString()};
                dataGridView2.Rows.Add(row);
            }
            reader.Close();
            ocn.Close();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Ajouter_user au = new Ajouter_user();
            au.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifier_u f = new modifier_u();

            int lignecourant;

            string numclient, nom_client, ville, rue, code_postal, num_tel;
            if (dataGridView2.RowCount == 0) return;
            lignecourant = dataGridView2.CurrentRow.Index;
            numclient = dataGridView2.Rows[lignecourant].Cells[0].Value.ToString();
            nom_client = dataGridView2.Rows[lignecourant].Cells[1].Value.ToString();
            ville = dataGridView2.Rows[lignecourant].Cells[2].Value.ToString();
            rue = dataGridView2.Rows[lignecourant].Cells[3].Value.ToString();
            code_postal = dataGridView2.Rows[lignecourant].Cells[4].Value.ToString();

            f.txt_login.Text = numclient;
            f.txt_pwd.Text = nom_client;
            f.txt_nom.Text = ville;
            f.txt_type.Text = rue;
            f.txt_discription.Text = code_postal;

            f.ShowDialog();
            charche_listeUser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lignecourant;
            string login;
            string req_sup;
            if (dataGridView2.RowCount == 0)

                return;
            lignecourant = dataGridView2.CurrentRow.Index;
            login = dataGridView2.Rows[lignecourant].Cells[0].Value.ToString();
            req_sup = "delete from authentification where login ='" + login + "'";
            lancerRequet(req_sup);
            charche_listeUser();
        }

        private void Gestion_user_Load(object sender, EventArgs e)
        {
            charche_listeUser();

        }
    }
}
