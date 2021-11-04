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
    public partial class Gestion_livre : Form
    {
        public Gestion_livre()
        {
            InitializeComponent();
        }
        public string reqcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\bd\\gestion_beblio.accdb;";

        public void charche_listeLivre()
        {
            dataGridView1.Rows.Clear();
            string txtsql;
            txtsql = "select * from Livre";
            OleDbConnection ocn = new OleDbConnection(reqcon);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                string[] row = new string[] {reader.GetValue(0).ToString(),reader.GetValue(1).ToString(),reader.GetValue(2).ToString(),reader.GetValue(3).ToString(),
                                              reader.GetValue(4).ToString(),reader.GetValue(5).ToString()};
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
            ocn.Close();
        }
        private void Gestion_livre_Load(object sender, EventArgs e)
        {
            charche_listeLivre();

        }

       

     
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

        private void button3_Click(object sender, EventArgs e)
        {
            int lignecourant;
            string isbn;
            string req_sup;
            if (dataGridView1.RowCount == 0)

                return;
            lignecourant = dataGridView1.CurrentRow.Index;
            isbn = dataGridView1.Rows[lignecourant].Cells[0].Value.ToString();
            req_sup = "delete from Livre where ISBN ='" + isbn + "'";
            lancerRequet(req_sup);
            charche_listeLivre();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ajouter_Click_1(object sender, EventArgs e)
        {
            AjouterLivre al = new AjouterLivre();
            al.Show();
            charche_listeLivre();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Modifier f = new Modifier();

            int lignecourant;

            string numclient, nom_client, ville, rue, code_postal, num_tel;
            if (dataGridView1.RowCount == 0) return;
            lignecourant = dataGridView1.CurrentRow.Index;
            numclient = dataGridView1.Rows[lignecourant].Cells[0].Value.ToString();
            nom_client = dataGridView1.Rows[lignecourant].Cells[1].Value.ToString();
            ville = dataGridView1.Rows[lignecourant].Cells[2].Value.ToString();
            rue = dataGridView1.Rows[lignecourant].Cells[3].Value.ToString();
            code_postal = dataGridView1.Rows[lignecourant].Cells[4].Value.ToString();
            num_tel = dataGridView1.Rows[lignecourant].Cells[5].Value.ToString();
            f.txt_isbn.Text = numclient;
            f.txt_titre.Text = nom_client;
            f.txt_autheur.Text = ville;
            f.txt_annee.Text = rue;
            f.type.Text = code_postal;
            f.txt_iditeur.Text = num_tel;
            f.ShowDialog();
            charche_listeLivre();

        }


    }
}
