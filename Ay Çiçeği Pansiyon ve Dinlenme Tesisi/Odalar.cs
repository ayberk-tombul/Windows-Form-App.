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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KDK27UT\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Oda101",baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();

            while(oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " +oku1["Soyadi"].ToString();
            }
            baglanti.Close();

            if(BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
            }

        }
    }
}
