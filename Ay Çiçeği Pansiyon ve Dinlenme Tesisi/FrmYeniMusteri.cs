using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon_ve_Dinlenme_Tesisi
{

    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-KDK27UT\\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)//106. oda 
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda110_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "110";
        }

        private void BtnOda111_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "111";
        }

        private void BtnOda112_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "112";
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli Butonlar Dolu Odaları Gösterir.");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli Butonlar Boş Odaları Gösterir.");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime buyuktarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc = buyuktarih - kucuktarih;

            label11.Text = Sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 50;

            TxtUcret.Text = ucret.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + TxtAdi.Text.ToString() + "','" + TxtSoyad.ToString() + "','" + comboBox1.Text.ToString() + "','"+ mskTxtTelefon.Text.ToString() + "','" +TxtMail.Text.ToString() + "','" +TxtKimlikNo.Text.ToString() + "','" +TxtOdaNo.Text + "','" +TxtUcret.Text.ToString() + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd)") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')," , baglantı);
            komut.ExecuteNonQuery();//Gelen parametreleri değiştirir.
            baglantı.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı.");
        }

        private void TxtAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


//Data Source=DESKTOP-KDK27UT\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True