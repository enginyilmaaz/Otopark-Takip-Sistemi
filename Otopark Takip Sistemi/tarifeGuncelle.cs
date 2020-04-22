using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class tarifeGuncelle : Form
    {
       int parkNo ; //global değişkenler
        public tarifeGuncelle(int otoparkID)
        {
            InitializeComponent();


            parkNo = otoparkID;

            DataRow ucretler = db.tarifeIslem.tarifeyiGetir(otoparkID);

        
            tbilkSaatUcreti.Text = ucretler["İlk Saat Ücreti"].ToString();
            tbSonrakiSaatBasiUcret.Text = ucretler["Sonraki Saat Başı Ücret"].ToString();
            tbGunlukUcret.Text = ucretler["Günlük Ücret"].ToString();
            string otoparkAdi = ucretler["Otopark Adı"].ToString();
            cbOtopark.DataSource = db.otoparkIslem.otoparklariGetir();
            cbOtopark.DisplayMember = "Otopark Adı";
            cbOtopark.ValueMember = "Park NO";
            cbOtopark.SelectedIndex = cbOtopark.FindStringExact(otoparkAdi);

        }

      
        private void ucrettEkle_Load(object sender, EventArgs e)
        {

        }

  
        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            db.tarifeIslem.tarifeGuncelle(Convert.ToInt16(tbilkSaatUcreti.Text), Convert.ToInt16(tbSonrakiSaatBasiUcret.Text), Convert.ToInt16(tbGunlukUcret.Text), parkNo);
            MessageBox.Show("Tarife başarıyla güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
