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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            kayitol frm = new kayitol();
            this.Hide();
            frm.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            admingiris frm = new admingiris();
            this.Hide();
            frm.ShowDialog();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader oku;

        public static string eposta;
        public static bool misafirgiris = false;

        private void btngiris_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
            con.Open();
            string sorgu = "Select * From Kayitlar Where eposta=@eposta AND sifre=@sifre";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@eposta", txteposta.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                misafirgiris = false;
                eposta = txteposta.Text;
                string mesaj = "Hoşgeldin " + oku[1].ToString();
                MessageBox.Show(mesaj);
                AnaSayfa frm = new AnaSayfa();
                this.Hide();
                frm.ShowDialog();
            }
            con.Close();
        }
        private void btnmisafirgiris_Click(object sender, EventArgs e)
        {
            misafirgiris = true;
            AnaSayfa frm = new AnaSayfa();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
