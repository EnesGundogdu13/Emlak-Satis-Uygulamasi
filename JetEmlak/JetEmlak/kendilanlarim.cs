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
    public partial class kendilanlarim : Form
    {
        public kendilanlarim()
        {
            InitializeComponent();
        }

        private void kendilanlarim_Load(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM ilanlar WHERE eposta = '" + Form1.eposta + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "ilanlar");
                dataGridView1.DataSource = ds.Tables["ilanlar"];
                con.Close();
            }
        }

        private void btnilanolustur_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            DateTime bugun = DateTime.Today;
            cmd.CommandText = "Update ilanlar Set ilantarihi=@ilantarihi,eposta=@eposta,telefon=@telefon,emlaktipi=@emlaktipi,metrekare=@metrekare,odasayisi=@odasayisi,binayasi=@binayasi,bulundugukat=@bulundugukat,isitma=@isitma,banyosayisi=@banyosayisi,balkon=@balkon,esyali=@esyali,siteicerisinde=@siteicerisinde,krediyeuygun=@krediyeuygun,aidat=@aidat Where ilanno=@id";
            cmd.Parameters.AddWithValue("@ilantarihi", bugun);
            cmd.Parameters.AddWithValue("@emlaktipi", cbemlaktipi.Text);
            cmd.Parameters.AddWithValue("@metrekare", txtmetrekare.Text);
            cmd.Parameters.AddWithValue("@odasayisi", txtodasayisi.Text);
            cmd.Parameters.AddWithValue("@binayasi", cbbinayasi.Text);
            cmd.Parameters.AddWithValue("@bulundugukat", txtkat.Text);
            cmd.Parameters.AddWithValue("@isitma", cbisitma.Text);
            cmd.Parameters.AddWithValue("@banyosayisi", cbbanyosayisi.Text);
            cmd.Parameters.AddWithValue("@balkon", cbbalkon.Text);
            cmd.Parameters.AddWithValue("@esyali", cbesyali.Text);
            cmd.Parameters.AddWithValue("@siteicerisinde", cbsiteicerisi.Text);
            cmd.Parameters.AddWithValue("@krediyeuygun", cbkrediyeuygun.Text);
            cmd.Parameters.AddWithValue("@aidat", txtaidat.Text);
            cmd.Parameters.AddWithValue("@eposta", Form1.eposta);
            cmd.Parameters.AddWithValue("@telefon", txttelefon.Text);
            cmd.Parameters.AddWithValue("@id", txtdid.Text);
            try
            {
                cmd.ExecuteNonQuery();
                cbemlaktipi.Text = "";
                txtmetrekare.Clear();
                txtaidat.Clear();
                cbbalkon.Text = "";
                cbbanyosayisi.Text = "";
                cbbinayasi.Text = "";
                txtkat.Text = "";
                cbemlaktipi.Text = "";
                cbesyali.Text = "";
                cbisitma.Text = "";
                cbkrediyeuygun.Text = "";
                txtodasayisi.Text = "";
                cbsiteicerisi.Text = "";
                txtdid.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kayıt olurken bir sorun oluştu." + ex);
            }
            finally
            {
                con.Close();
                dgwdoldur();
                MessageBox.Show("İlan Başarıyla Düzenlendi!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From ilanlar Where ilanno=@id";
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtdid.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kayıt olurken bir sorun oluştu." + ex);
            }
            finally
            {
                con.Close();
                dgwdoldur();
                MessageBox.Show("İlan Başarıyla Silindi!");
            }
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdid.Text = dataGridView1.CurrentRow.Cells["ilanno"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["ilanno"].Value.ToString();
            cbemlaktipi.Text = dataGridView1.CurrentRow.Cells["emlaktipi"].Value.ToString();
            txtmetrekare.Text = dataGridView1.CurrentRow.Cells["metrekare"].Value.ToString();
            txtodasayisi.Text = dataGridView1.CurrentRow.Cells["odasayisi"].Value.ToString();
            cbbinayasi.Text = dataGridView1.CurrentRow.Cells["binayasi"].Value.ToString();
            txtkat.Text = dataGridView1.CurrentRow.Cells["bulundugukat"].Value.ToString();
            cbisitma.Text = dataGridView1.CurrentRow.Cells["isitma"].Value.ToString();
            cbbanyosayisi.Text = dataGridView1.CurrentRow.Cells["banyosayisi"].Value.ToString();
            cbbalkon.Text = dataGridView1.CurrentRow.Cells["balkon"].Value.ToString();
            cbesyali.Text = dataGridView1.CurrentRow.Cells["esyali"].Value.ToString();
            cbsiteicerisi.Text = dataGridView1.CurrentRow.Cells["siteicerisinde"].Value.ToString();
            cbkrediyeuygun.Text = dataGridView1.CurrentRow.Cells["krediyeuygun"].Value.ToString();
            txtaidat.Text = dataGridView1.CurrentRow.Cells["aidat"].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
        }
    }
}
