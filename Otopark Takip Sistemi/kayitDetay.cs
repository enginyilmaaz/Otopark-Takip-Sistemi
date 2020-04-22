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
    public partial class kayitDetay : Form
    {
        public kayitDetay(int islemID)
        {
            InitializeComponent();
            DataRow detay = db.otoparkIslem.kaydiGetir(islemID);
            tbIslemNO.Text=detay["İşlem NO"].ToString();
            tbOtopark.Text = detay["Otopark"].ToString();
            tbKonum.Text = detay["Şehir"].ToString() + ", " + detay["İlçe"].ToString();
            tb_islemZamani.Text = detay["İşlem Zamanı"].ToString();
            tbAracPlaka.Text = detay["Araç Plakası"].ToString();
            tbMusAdSoyad.Text = detay["Müşteri Bilgisi"].ToString();
            mtbMusCepNo.Text = detay["Müşteri Cep No"].ToString();
            tbKayitTuru.Text = detay["Kayıt Türü"].ToString();

            tbislemYapanPersonelAd.Text = detay["İşlemi Yapan Personel"].ToString();
            tbFaturaTutari.Text = detay["Fatura Tutarı (TL)"].ToString();
            tbFaturaDurumu.Text = detay["Fatura Durumu"].ToString();
            tbPrsKimlikNO.Text = detay["prsKimlikNO"].ToString();


        }

        private void kayitDetay_Load(object sender, EventArgs e)
        {

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
