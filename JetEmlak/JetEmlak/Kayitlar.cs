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
    public partial class Kayitlar : Form
    {
        public Kayitlar()
        {
            InitializeComponent();
        }

        private void Kayitlar_Load(object sender, EventArgs e)
        {
            gridoldur();
        }
        SqlConnection con;

        void gridoldur()
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
                SqlDataAdapter da = new SqlDataAdapter("Select * From Kayitlar", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Kayitlar");
                dataGridView1.DataSource = ds.Tables["Kayitlar"];
                con.Close();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtekullaniciadi.Text == "" || txteeposta.Text == "" || txtesifre.Text == "")
            {
                MessageBox.Show("Lütfen boş yer bırakmayın!");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Kayitlar (kullaniciadi,eposta,sifre) VALUES (@kullaniciadi,@eposta,@sifre)";
                cmd.Parameters.AddWithValue("@kullaniciadi", txtekullaniciadi.Text);
                cmd.Parameters.AddWithValue("@eposta", txteeposta.Text);
                cmd.Parameters.AddWithValue("@sifre", txtesifre.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    txtekullaniciadi.Clear();
                    txteeposta.Clear();
                    txtesifre.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt olurken bir sorun oluştur.");
                }
                finally
                {
                    con.Close();
                    gridoldur();
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From Kayitlar Where id=@id";
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtid.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt olurken bir sorun oluştur.");
            }
            finally
            {
                con.Close();
                gridoldur();
            }
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Kayitlar Set kullaniciadi=@kullaniciadi,eposta=@eposta,sifre=@sifre Where id=@id";
            cmd.Parameters.AddWithValue("@id", txtdid.Text);
            cmd.Parameters.AddWithValue("@kullaniciadi", txtdkullaniciadi.Text);
            cmd.Parameters.AddWithValue("@eposta", txtdeposta.Text);
            cmd.Parameters.AddWithValue("@sifre", txtdsifre.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtdkullaniciadi.Clear();
                txtdeposta.Clear();
                txtdsifre.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt olurken bir sorun oluştur.");
            }
            finally
            {
                con.Close();
                gridoldur();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txtdkullaniciadi.Text = dataGridView1.CurrentRow.Cells["kullaniciadi"].Value.ToString();
            txtdsifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            txtdeposta.Text = dataGridView1.CurrentRow.Cells["eposta"].Value.ToString();
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            AdminPanel frm = new AdminPanel();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
