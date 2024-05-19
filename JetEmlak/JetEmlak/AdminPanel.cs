using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetEmlak
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnkayitlar_Click(object sender, EventArgs e)
        {
            Kayitlar frm = new Kayitlar();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            Admingirisleri frm = new Admingirisleri();
            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnilanlar_Click(object sender, EventArgs e)
        {
            adminilanlar frm = new adminilanlar();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
