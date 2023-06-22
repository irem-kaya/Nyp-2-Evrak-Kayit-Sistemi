using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aşriv_Kayıt_Sistemi
{
    public partial class kullaniciGiris : Form
    {
        public kullaniciGiris()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.3; uid=Grup3-2023;pwd=NyP:974.cc;database=Grup3-2023;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dm;
        private void FormGetir(Form form)
        {
            panel1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLoginScreem hedefForm = new FormLoginScreem();
            hedefForm.Show();
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKullanıcıBilgileri formKullanıcıBilgileri = new FormKullanıcıBilgileri();
            FormGetir(formKullanıcıBilgileri);
        }

        private void kullanıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormKullanıcıAyarları formKullanıcıAyarları = new FormKullanıcıAyarları();
            FormGetir(formKullanıcıAyarları);
        }

        private void emanetVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmanetVer formEmanetVer = new FormEmanetVer();
            FormGetir(formEmanetVer);
        }

        private void emanetAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmanetAl formEmanetAl = new FormEmanetAl();
            FormGetir(formEmanetAl);
        }

        private void emanetDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmanetDurumu emanetDurumu = new FormEmanetDurumu();
            FormGetir(emanetDurumu);
        }

        private void dgwDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void kayıtGetir()
        {
            dm = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT* FROM Document", connection);
            adapter.Fill(dm);
            dgwDocument.DataSource = dm;
            connection.Close();
        }
        

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            
            DataView dv = dm.DefaultView;
            dv.RowFilter = "document_name LIKE '" + tbxSearch.Text + "%'";
            dgwDocument.DataSource = dv;
        }


        private void kullaniciGiris_Load(object sender, EventArgs e)
        {
            kayıtGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
        }
    }
}
