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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "" || txteposta.Text == "" || txtsifre.Text == "" || txtsifreonay.Text == "")
            {
                MessageBox.Show("Lütfen boş yer bırakmayın!");
            }
            else
            {
                if (txtsifre.Text == txtsifreonay.Text)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Server = localhost; Database = emlakotomasyonu; User Id =sa; Password = 123456;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Kayitlar (kullaniciadi,eposta,sifre) VALUES (@kullaniciadi,@eposta,@sifre)";
                    cmd.Parameters.AddWithValue("@kullaniciadi", txtkullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@eposta", txteposta.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        txtkullaniciadi.Clear();
                        txteposta.Clear();
                        txtsifre.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kayıt olurken bir sorun oluştur.");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler birbiriyle uyuşmuyor!");
                }
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
