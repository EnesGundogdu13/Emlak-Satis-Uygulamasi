using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetEmlak
{
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader oku;

        private void btngiris_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
            con.Open();
            string sorgu = "Select * From admingiris Where kullaniciadi=@ad AND sifre=@sifre";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ad", txtkullaniciadi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                string mesaj = "Hoşgeldin " + oku[1].ToString();
                MessageBox.Show(mesaj);
                AdminPanel frm = new AdminPanel();
                this.Hide();
                frm.ShowDialog();
            }
            con.Close();
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
