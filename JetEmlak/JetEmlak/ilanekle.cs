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
    public partial class ilanekle : Form
    {
        public ilanekle()
        {
            InitializeComponent();
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
            cmd.CommandText = "INSERT INTO ilanlar (ilantarihi,eposta,telefon,emlaktipi,metrekare,odasayisi,binayasi,bulundugukat,isitma,banyosayisi,balkon,esyali,siteicerisinde,krediyeuygun,aidat) VALUES (@ilantarihi,@eposta,@telefon,@emlaktipi,@metrekare,@odasayisi,@binayasi,@bulundugukat,@isitma,@banyosayisi,@balkon,@esyali,@siteicerisinde,@krediyeuygun,@aidat)";
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kayıt olurken bir sorun oluştu." + ex);
            }
            finally
            {
                con.Close();
                MessageBox.Show("İlan Başarıyla Oluşturuldu!");
            }
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
