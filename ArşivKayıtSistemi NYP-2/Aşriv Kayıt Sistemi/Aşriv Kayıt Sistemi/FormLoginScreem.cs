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
    public partial class FormLoginScreem : Form
    {
        public FormLoginScreem()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ka = textBox1.Text;
            string sifre = textBox2.Text;
            

            if (ka == "admin" && radioButton1.Checked)
            {
                if (sifre == "1111")
                {
                    label3.Text = "Giriş Başarılı";
                    adminGiris adminGiris = new adminGiris();

                    this.Hide();
                    adminGiris.Show();
                }
                else
                {
                    label3.Text = "Şifre ya da kullanıcı adı yanlış";
                }
            }
            else
            {
                if(ka=="kullanici" && radioButton2.Checked)
                {
                    if (sifre == "1111")
                    {
                        label3.Text = "Giriş Başarılı";
                        kullaniciGiris kullaniciGiris = new kullaniciGiris();

                        this.Hide();
                        kullaniciGiris.Show();
                    }
                    else
                    {
                        label3.Text = "Şifre ya da kullanıcı adı yanlış";
                    }

                }
            }
        }

        public void FormLoginScreem_Load(object sender, EventArgs e)
        {
 

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
