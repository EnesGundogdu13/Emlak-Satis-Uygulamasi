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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnilanekle_Click(object sender, EventArgs e)
        {
            if (Form1.misafirgiris == true)
            {
                MessageBox.Show("İlan ekleyebilmek için giriş yapmalısınız!");
            }
            else
            {
                ilanekle frm = new ilanekle();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            dgwdoldur();
        }
        SqlConnection con;
        void dgwdoldur()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex);
            }
            finally
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From ilanlar", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "ilanlar");
                dgwilanlar.DataSource = ds.Tables["ilanlar"];
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.misafirgiris == true)
            {
                MessageBox.Show("Kendi ilanlarınızı görebilmek için giriş yapmalısınız!");
            }
            else
            {
                kendilanlarim frm = new kendilanlarim();
                this.Hide();
                frm.ShowDialog();
            }

        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
