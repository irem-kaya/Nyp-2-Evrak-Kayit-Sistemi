using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Reflection.Metadata;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Aşriv_Kayıt_Sistemi
{
    public partial class adminGiris : Form 
    {
        public adminGiris()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }
        MySqlConnection connection= new MySqlConnection("Server=172.21.54.3; uid=Grup3-2023;pwd=NyP:974.cc;database=Grup3-2023;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        private void FormGetir(Form form)
        {
            panel1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }
        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminBilgileri ekle = new FormAdminBilgileri();
            FormGetir(ekle);
        }
        private void adminAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminAyarları adminbilgi = new FormAdminAyarları();
            FormGetir(adminbilgi);
        }
        private void kullanıcıBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKullanıcıBul kullanicibul = new FormKullanıcıBul();
            FormGetir(kullanicibul);
        }
        private void kullanııEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKullanıcıEkle kullanıcıekle = new FormKullanıcıEkle();
            FormGetir(kullanıcıekle);
        }
        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKullanıcıSil kullanıcısil = new FormKullanıcıSil();
            FormGetir(kullanıcısil);
        }
        private void uygulamaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayarlar uygulamaayarlari = new Ayarlar();
            FormGetir(uygulamaayarlari);
        }
        private void emanetDurumuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }
        private void emanetAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void emanetVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {   
        }

        private void evrakKayıtSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEvrakSil formEvrakSil = new FormEvrakSil();
            FormGetir(formEvrakSil);
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void kullanıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void oturumuKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLoginScreem hedefForm = new FormLoginScreem();
            hedefForm.Show();
        }
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void emanetDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       public  void kayıtGetir()
        {
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT* FROM Document", connection);
            adapter.Fill(dt);
            dgwDocument.DataSource = dt;
            connection.Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            kayıtGetir();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        public void dgwDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();  
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "document_name LIKE '" + tbxSearch.Text + "%'";
            dgwDocument.DataSource= dv;

        }

        private void evrakBulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void dgwDocument_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            
           
        }

        private void dgwDocument_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            tbxId.Text = dgwDocument.CurrentRow.Cells[0].Value.ToString();
            tbxDocName.Text=dgwDocument.CurrentRow.Cells[1].Value.ToString(); 
            tbxDocType.Text=dgwDocument.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dgwDocument.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {

            }
            
        }

        public void btnEkle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Document (document_name,document_type,document_creationTime,document_id)" +
                "VALUES (@name,@type,@creationtime,@id)";
            cmd=new MySqlCommand(sql,connection);
            cmd.Parameters.AddWithValue("@id", tbxId.Text);
            cmd.Parameters.AddWithValue("@name", tbxDocName.Text);
            cmd.Parameters.AddWithValue("@type", tbxDocType.Text);
            cmd.Parameters.AddWithValue("@creationtime", dateTimePicker1.Value);
            connection.Open();  
            cmd.ExecuteNonQuery();
            connection.Close();
            kayıtGetir();
            MessageBox.Show("eklendi");

        }

        void button3_Click_1(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Document WHERE @id=document_id";
            cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", tbxId.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            kayıtGetir();
            MessageBox.Show("silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Document " +
                "SET document_name=@name, document_type=@type , document_creationTime=@creationtime " +
                "WHERE document_id=@id";
            cmd =new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@name", tbxDocName.Text);
            cmd.Parameters.AddWithValue("@type", tbxDocType.Text);
            cmd.Parameters.AddWithValue("@creationtime", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@id", tbxId.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            kayıtGetir();
            MessageBox.Show("güncellendi");




        }

        private void splitContainer4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }

}
    