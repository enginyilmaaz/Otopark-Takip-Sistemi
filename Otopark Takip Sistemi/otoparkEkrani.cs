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
    public partial class otoparkEkrani : Form
    {
        string parkNo;
        string otoparkAdi;
        string tckno;
        string ara;
        string zaman1, zaman2;

        public void HaftaHesapla()
        {


            DateTime dtHafta = DateTime.Now;
            switch ((int)dtHafta.DayOfWeek)
            {
                case 0:
                    zaman1 = dtHafta.AddDays(-6).ToString("yyyy-MM-dd 00:00:00");
                    zaman2 = dtHafta.ToString("yyyy-MM-dd 23:59:59");
                    break;

                default:
                    zaman1 = dtHafta.AddDays(1 - (int)dtHafta.DayOfWeek).ToString("yyyy-MM-dd 00:00:00");
                    zaman2 = dtHafta.AddDays(7 - (int)dtHafta.DayOfWeek).ToString("yyyy-MM-dd 23:59:59");
                    break;
            }
        }


        public void ayHesapla()
        {


            DateTime suan = DateTime.Now;
            zaman1 = new DateTime(suan.Year, suan.Month, 1).ToString("yyyy-MM-dd 00:00:00");
            zaman2 = new DateTime(suan.Year, suan.Month, 1).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59");

           
        }


        public void yilHesapla()
        {
            zaman1 = new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy-MM-dd 00:00:00");
            zaman2 = new DateTime(DateTime.Now.Year, 1, 1).AddYears(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59");


            
        }

        public void otoparkBilgiGetir ()
        {


            DataRow otopark = db.otoparkIslem.otoparkGetir(Convert.ToInt16(parkNo));
            string kapasite = otopark["Araç Kapasitesi"].ToString();
            string anlikKapasite = otopark["Şuanki Kapasite"].ToString();
            int doluSayisi;
            doluSayisi = Convert.ToInt16(kapasite) - Convert.ToInt16(anlikKapasite);
            lblFooterInfo.Text = "Kapasite: " + kapasite + ", Boş: " + anlikKapasite + ", Dolu: " + doluSayisi;
         
        }


    


        public otoparkEkrani(string prsKimlikNo, string prs_adsoyad, string modulErisimi, string otoparkAd)
        {
            InitializeComponent();
           
            if (modulErisimi == "Otopark Personel Ekranı")
            {


                btnPersonelListesi.Enabled = false;
                btnSubeDegistir.Enabled = false;
                btnRapolar.Enabled = false;
            }


            DataRow personel = db.personelIslemleri.personelGetir(prsKimlikNo);
            tckno = personel["Kimlik NO"].ToString();
            string prsAdSoyad = personel["Ad Soyad"].ToString();
            parkNo = personel["Park No"].ToString();
            otoparkAdi = personel["Otopark Adı"].ToString();



            lbl_HeaderINfo.Text = prsAdSoyad + ", TC No: " + tckno + ",Otopark: " + otoparkAdi;

            cbRaporlar.SelectedIndex = 0;
            cb_islemTuru.SelectedIndex = 0;
            cbOdemeTuru.SelectedIndex = 0;
            Main_Grid.DataSource = db.otoparkIslem.otoparkGetir(Convert.ToInt16(parkNo));
            Main_Grid.AutoResizeColumns();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           
            
            otoparkBilgiGetir();


        }

        private void btnPersonelListesi_Click(object sender, EventArgs e)
        {
            tb_ara.Visible = true;
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            ara = "personeller";
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            gbIslemYap.Visible = false;
            Main_Grid.Visible = true;
            gbAra.Enabled = true;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;
            Main_Grid.DataSource = db.personelIslemleri.otoparkaGorePersoneller(Convert.ToInt16(parkNo));
            Main_Grid.ContextMenuStrip = contextMenuStripPersoneller;
            Main_Grid.AutoResizeColumns();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnOtoparkGuncelle_Click(object sender, EventArgs e)
        {
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            gbIslemYap.Visible = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;
            Main_Grid.Visible = true;
            tb_ara.Visible = true;
            gbAra.Enabled = true;
            otoparkGuncelle s = new otoparkGuncelle(Convert.ToInt16(parkNo));
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.otoparkIslem.otoparkGetir(Convert.ToInt16(parkNo));
            Main_Grid.AutoResizeColumns();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ara = "personeller";
            DataGridViewRow seciliYetkili = Main_Grid.CurrentRow;
            string yetkiliTC = seciliYetkili.Cells["Kimlik NO"].Value.ToString();
            personelGuncelle s = new personelGuncelle(yetkiliTC, false);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.personelIslemleri.otoparkaGorePersoneller(Convert.ToInt16(parkNo));
            Main_Grid.ContextMenuStrip = contextMenuStripPersoneller;
            Main_Grid.AutoResizeColumns();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ara = "personeller";
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili kullancıyı silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {

                DataGridViewRow seciliYetkili = Main_Grid.CurrentRow;
                string yetkiliTC = seciliYetkili.Cells["Kimlik No"].Value.ToString();

                db.personelIslemleri.PersonelSil(yetkiliTC);

                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_Grid.DataSource = db.personelIslemleri.otoparkaGorePersoneller(Convert.ToInt16(parkNo));
                Main_Grid.ContextMenuStrip = contextMenuStripPersoneller;
                Main_Grid.AutoResizeColumns();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


        }

        private void btn_islemYap_Click(object sender, EventArgs e)
        {



            tb_ara.Visible = true;
          
            ara = "kayıtlar";
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            gbIslemYap.Visible = true;
            Main_Grid.Visible = false;
            gbAra.Enabled = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;
            mtbMusCepNo.Clear();
            tbAracPlakasi.Clear();
            tb_musteriBilgi.Clear();
            cbOdemeTuru.SelectedIndex = 0;
            cb_islemTuru.SelectedIndex = 0;


        }

        private void btnKayitlariListele_Click(object sender, EventArgs e)
        {
            tb_ara.Visible = true;
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            gbIslemYap.Visible = false;
            Main_Grid.Visible = true;
            gbAra.Enabled = true;
            label1.Enabled =true;
            dtpGiris.Enabled = true;
            dtpCikis.Enabled =true;
            lblTarihAraligi.Enabled = true;
            ara = "kayıtlar";

            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");






            Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2,"and o.otoparkID="+parkNo);
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main_Grid.ContextMenuStrip = cmsKayitlar;
          

        }












        private void Main_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRapolar_Click(object sender, EventArgs e)
        {



            
            gbIslemYap.Visible = false;
            Main_Grid.Visible = true;
            gbAra.Enabled = true;
            lbl_ara.Visible = false;
            tb_ara.Visible = false;
            
            lblRapor.Visible = true;
            cbRaporlar.Visible = true;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;
        }

        private void btnFaturaListele_Click(object sender, EventArgs e)
        {
            tb_ara.Visible = true;
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            gbIslemYap.Visible = false;
            Main_Grid.Visible = true;
            gbAra.Enabled = true;
            label1.Enabled = true;
            dtpGiris.Enabled = true;
            dtpCikis.Enabled = true;
            lblTarihAraligi.Enabled = true;
            ara = "faturalar";
            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");

            Main_Grid.DataSource = db.tarifeIslem.faturalariGetirOtoparkaGore(Convert.ToInt16(parkNo),aralik1,aralik2);
            Main_Grid.ContextMenuStrip = null;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void tb_ara_TextChanged(object sender, EventArgs e)
        {
            if (tb_ara.TextLength > 0)

            {
                if (ara == "personeller")
                {
                    Main_Grid.DataSource = db.personelIslemleri.personelAraOtoparkaGore(tb_ara.Text, Convert.ToInt16(parkNo));
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }



                if (ara == "kayıtlar")
                {
                    string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                    string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                    Main_Grid.DataSource = db.otoparkIslem.kayitAraOtoparkaGoreTarihFiltreli( Convert.ToInt16(parkNo),aralik1,aralik2, tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }





                if (ara == "faturalar")
                {
                    string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                    string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");

                    Main_Grid.DataSource = db.tarifeIslem.faturaAraOtoparkaGore(tb_ara.Text, Convert.ToInt16(parkNo),aralik1,aralik2);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }



            else if (tb_ara.TextLength <= 0)

            {
                if (ara == "personeller")

                {
                    Main_Grid.DataSource = db.personelIslemleri.personelAraOtoparkaGore(tb_ara.Text, Convert.ToInt16(parkNo));
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }

                if (ara == "kayıtlar")
                {

                    string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                    string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");






                    Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2,"and o.otoparkID="+parkNo);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (ara == "faturalar")
                {
                    string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                    string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");

                    Main_Grid.DataSource = db.tarifeIslem.faturalariGetirOtoparkaGore(Convert.ToInt16(parkNo),aralik1,aralik2);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
        }

        private void cbRaporlar_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            int secili = cbRaporlar.SelectedIndex;
            if (secili == 1)
            {
                Main_Grid.DataSource = db.otoparkIslem.dolulukOraniOtoparkaGore(Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 2)
            {
                Main_Grid.DataSource = db.aracIslemleri.henuzCikisYapmamisAraclarOtoparkaGore(Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 3)
            {
                Main_Grid.DataSource = db.personelIslemleri.otoparkaGorePersonelSayisi(Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 4)
            {
                HaftaHesapla();
                Main_Grid.DataSource = db.tarifeIslem.ToplamCiroFiltreliOtoparkaGore(zaman1, zaman2, Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 5)
            {
                ayHesapla();
                Main_Grid.DataSource = db.tarifeIslem.ToplamCiroFiltreliOtoparkaGore(zaman1, zaman2, Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            if (secili == 6)
           {
                yilHesapla();
                Main_Grid.DataSource = db.tarifeIslem.ToplamCiroFiltreliOtoparkaGore(zaman1, zaman2, Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }


            if (secili == 7)
            {
                
                Main_Grid.DataSource = db.tarifeIslem.ToplamCiroPtoparkaGore(Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }


            if (secili == 8)
            {
                HaftaHesapla();
                Main_Grid.DataSource = db.otoparkIslem.otoparkGoreGirisYapanAracSayisiFiltreli(zaman1,zaman2, Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

            if (secili == 9)
            {
                ayHesapla();
                Main_Grid.DataSource = db.otoparkIslem.otoparkGoreGirisYapanAracSayisiFiltreli(zaman1, zaman2, Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

            if (secili == 10)
            {
                yilHesapla();
                Main_Grid.DataSource = db.otoparkIslem.otoparkGoreGirisYapanAracSayisiFiltreli(zaman1, zaman2, Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }



            if (secili == 11)
            {
                yilHesapla();
                Main_Grid.DataSource = db.otoparkIslem.toplamGirisAracSayisiOtoparkaGore(Convert.ToInt16(parkNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }




        }

        private void linklabel_cikisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            girisEkrani s = new girisEkrani();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
        }

        private void cmsmiKayitDetayi_Click(object sender, EventArgs e)
        {
            DataGridViewRow secili = Main_Grid.CurrentRow;
            int islemID = Convert.ToInt16(secili.Cells["İşlem No"].Value);

            kayitDetay s = new kayitDetay(islemID);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;

            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");

            Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2,"and o.otoparkID="+parkNo);
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void otoparkEkrani_Load(object sender, EventArgs e)
        {
            dtpGiris.Value = DateTime.Today.AddDays(-7);
            dtpCikis.Value = DateTime.Today;
            cbOdemeTuru.SelectedIndex = 0;
            cb_islemTuru.SelectedIndex = 0;
            

        }

        private void gbIslemYap_Enter(object sender, EventArgs e)
        {

        }

        private void tbAracPlakasi_TextChanged(object sender, EventArgs e)
        {
            if (tbAracPlakasi.TextLength>0) { ticlkPlaka.Visible = true; }
            else if (tbAracPlakasi.TextLength <= 0) { ticlkPlaka.Visible = false; }
            int secili = cb_islemTuru.SelectedIndex;

            if (secili == 1)  // giriş işlemi 
            {
                AutoCompleteStringCollection autolist = new AutoCompleteStringCollection();
                foreach (DataRow r in db.aracIslemleri.plakaVarsaGetir().Rows)
                {
                    if (r[0] != null) // plaka kayıtlı ise getir
                    {
                        autolist.Add(r[0].ToString());
                    }
                }

                tbAracPlakasi.AutoCompleteMode = AutoCompleteMode.Suggest;
                tbAracPlakasi.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbAracPlakasi.AutoCompleteCustomSource = autolist;





                DataTable musteriKontrol = db.musteriIslemleri.plakaMusteriGetir(tbAracPlakasi.Text);
                DataTable aracKontrol = db.aracIslemleri.plakaKontrol(tbAracPlakasi.Text);

                if (musteriKontrol.Rows.Count > 0 && aracKontrol.Rows.Count > 0) // müşteri kaydı ve araç kaydı varsa, araç bilgilerini otomatik getir
                {
                    
                    DataRow musteri = db.musteriIslemleri.plakaMusteriGetir(tbAracPlakasi.Text).Rows[0];
                    tb_musteriBilgi.Text = musteri["Ad Soyad"].ToString();
                    mtbMusCepNo.Text = musteri["Müşteri Cep NO"].ToString();
                    mtbMusCepNo.Enabled = false;


                }




                else
                {
                    tb_musteriBilgi.Text = "";
                    mtbMusCepNo.Text = "";
                    mtbMusCepNo.Enabled = true;



                }











            } // giriş sonu

            if (secili == 2)  //çıkış işlemi 
            {
                DataTable kontrol = db.aracIslemleri.cikisYapilacakAracAraOtoparkaGorePlaka(Convert.ToInt16(parkNo));

                if (kontrol.Rows.Count <= 0)
                {
                    btnTamam.Enabled = false;


                }

                if (kontrol.Rows.Count > 0)
                {

                    btnTamam.Enabled = true;
                    AutoCompleteStringCollection autolist = new AutoCompleteStringCollection();
                foreach (DataRow r in db.aracIslemleri.cikisYapilacakAracAraOtoparkaGorePlaka(Convert.ToInt16(parkNo)).Rows)
                {
                    if (r[0] != null) // plaka kayıtlı ise getir
                    {
                        autolist.Add(r[0].ToString());
                       
                    }
                   
                }

                tbAracPlakasi.AutoCompleteMode = AutoCompleteMode.Suggest;
                tbAracPlakasi.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbAracPlakasi.AutoCompleteCustomSource = autolist;

                DataTable musteriKontrol = db.musteriIslemleri.plakaMusteriGetir(tbAracPlakasi.Text);
                if (musteriKontrol.Rows.Count > 0) { 
                DataRow musteri = musteriKontrol.Rows[0];
                tb_musteriBilgi.Text = musteri["Ad Soyad"].ToString();
                mtbMusCepNo.Text = musteri["Müşteri Cep NO"].ToString();
            }

                else
                {
                    tb_musteriBilgi.Text = "";
                    mtbMusCepNo.Text = "";
                }

                }


               
            }//çıkış işlemi sonu






        }

        private void btnTamam_Click(object sender, EventArgs e)
        {

            DataRow doluluk = db.otoparkIslem.otoparkGetir(Convert.ToInt16(parkNo));

            int anlikKapasite = Convert.ToInt16(doluluk["Şuanki Kapasite"]);
          

            int secili = cb_islemTuru.SelectedIndex;
            if (secili == 1)  // giriş işlemi 
            {
                if (tickIslemTuru.Visible && tickMusBilgi.Visible && ticlkPlaka.Visible && tickMusCepNo.Visible)
                {
                    if (anlikKapasite == 0)
                    {

                        MessageBox.Show("Otoparkta boş yer yok", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        goto son;
                    }

                    else
                    {

                        DataTable aracKontrol = db.aracIslemleri.plakaKontrol(tbAracPlakasi.Text);
                        DataTable musteriKontrol = db.musteriIslemleri.musteriKontrol(mtbMusCepNo.Text);



                        if (aracKontrol.Rows.Count <= 0 && musteriKontrol.Rows.Count <= 0)  // araç ve müşteri kayıtlı değilse
                        {


                            db.musteriIslemleri.musteriEkle(mtbMusCepNo.Text, tb_musteriBilgi.Text);

                            db.aracIslemleri.aracEkle(mtbMusCepNo.Text, tbAracPlakasi.Text);




                        }


                        if (aracKontrol.Rows.Count <= 0 && musteriKontrol.Rows.Count > 0)  // müşteri kayıtlı ve araç kayıtlı değilse
                        {


                            db.aracIslemleri.aracEkle(mtbMusCepNo.Text, tbAracPlakasi.Text);


                        }


                        else if (aracKontrol.Rows.Count > 0) //araç kayıtlı ise
                        {


                            DataTable aracGirisKontrol = db.aracIslemleri.henuzCikisYapmamisAraclar(tbAracPlakasi.Text);
                            if (aracGirisKontrol.Rows.Count > 0)  // araç hali hazırda otoparkta ise
                            {


                                goto bitti;

                            }

                            if (aracGirisKontrol.Rows.Count <= 0)  // araç otoparkta değilse

                            {

                                db.aracIslemleri.aracGuncelle(tbAracPlakasi.Text, true);

                            }



                        }







                        //fatura oluştur önce
                        db.tarifeIslem.faturaOlustur(tckno);

                        DataRow faturaNO = db.tarifeIslem.sonEklenenFaturaID(tckno); // son eklenen fatura
                        int faturaNo = Convert.ToInt16(faturaNO["faturaNo"]);


                        bool kayitTuru = false;
                        if (cb_islemTuru.Text == "Giriş") kayitTuru = false;
                        if (cb_islemTuru.Text == "Çıkış") kayitTuru = true;
                        DateTime suankiTarih = DateTime.Now;
                        string islemZamani = suankiTarih.ToString("yyyy-MM-dd HH:mm:ss");
                        db.otoparkIslem.kayitEkle(Convert.ToInt16(parkNo), kayitTuru, tckno, islemZamani, faturaNo, tbAracPlakasi.Text, true);



                    }

                }

                else { MessageBox.Show("Eksik bilgi girişi", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);  goto son; }
            }// giriş işlemi sonu



            if (secili==0)  { MessageBox.Show("Eksik bilgi girişi", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error); goto son; }







            if (secili == 2)  //çıkış işlemi 
            {
                if (tickIslemTuru.Visible && tickMusBilgi.Visible && ticlkPlaka.Visible && tickMusCepNo.Visible)
                {

                    DataTable dt = db.aracIslemleri.girisBilgileriniGetir(tbAracPlakasi.Text, Convert.ToInt16(parkNo));

                    string girisZamani = dt.Rows[0]["islemZamani"].ToString();
                    int faturaNo = Convert.ToInt16(dt.Rows[0]["faturaNo"]);
                    DateTime giris = DateTime.Parse(girisZamani);
                    DateTime cikis = DateTime.Now;
                    TimeSpan gecenSure = cikis - giris;
                    string islemZamani = cikis.ToString("yyyy-MM-dd HH:mm:ss");


                    decimal kalinanSaat = Math.Ceiling(Convert.ToDecimal(gecenSure.TotalHours));


                    DataRow tarife = db.tarifeIslem.tarifeyiGetir(Convert.ToInt16(parkNo));
                    decimal ilkSaatUcreti = Convert.ToInt16(tarife["İlk Saat Ücreti"]);
                    decimal sonrakiSaatbasiEkUcret = Convert.ToInt16(tarife["Sonraki Saat Başı Ücret"]);
                    decimal gunlukUcret = Convert.ToInt16(tarife["Günlük Ücret"]);


                    decimal faturaTutari = 1;

                    if (kalinanSaat >= 0 && kalinanSaat <= 1)
                    {

                        faturaTutari = ilkSaatUcreti;
                    }

                    if (kalinanSaat >= 1 && kalinanSaat <= 23)
                    {

                        faturaTutari = ilkSaatUcreti + (sonrakiSaatbasiEkUcret * (kalinanSaat - 1));
                        if (faturaTutari > gunlukUcret)
                        { faturaTutari = gunlukUcret; }
                    }

                    if (kalinanSaat >= 24)
                    {
                        decimal kalinanGun = Math.Floor(kalinanSaat / 24);
                        decimal saat = kalinanSaat = kalinanSaat % 24;


                        if (saat >= 0 && saat <= 1)
                        {

                            faturaTutari = gunlukUcret * kalinanGun + ilkSaatUcreti;
                        }

                        else
                        {

                            decimal saatUcret = ilkSaatUcreti + (sonrakiSaatbasiEkUcret * (saat - 1));
                            if (saatUcret > gunlukUcret) saatUcret = gunlukUcret;

                            faturaTutari = gunlukUcret * kalinanGun + saatUcret;
                        }

                    }


                    bool kayitTuru = false;
                    if (cb_islemTuru.Text == "Giriş") kayitTuru = false;
                    if (cb_islemTuru.Text == "Çıkış") kayitTuru = true;

                    bool odemeTuru = false;
                    if (cb_islemTuru.Text == "Nakit") odemeTuru = false;
                    if (cb_islemTuru.Text == "Kredi Kartı") odemeTuru = true;

                    db.otoparkIslem.kayitEkle(Convert.ToInt16(parkNo), kayitTuru, tckno, islemZamani, faturaNo, tbAracPlakasi.Text, false);

                    db.tarifeIslem.faturaOdendiGuncelle(faturaNo, islemZamani, Convert.ToInt16(faturaTutari), odemeTuru);
                    db.aracIslemleri.aracGuncelle(tbAracPlakasi.Text, false);


                    DataRow islemID = db.otoparkIslem.kayitGuncellenecekIslemIDGetir(tbAracPlakasi.Text); // son eklenen fatura
                    int islemIDNO = Convert.ToInt16(islemID["islemID"]);

                    db.otoparkIslem.kayitGuncelle(islemIDNO);


                }

                else { MessageBox.Show("Eksik bilgi girişi", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error); goto son; }
            }  //çıkış sonu















            MessageBox.Show("İşlem Başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbIslemYap.Visible = false;
            Main_Grid.Visible = true;
            gbAra.Enabled = true;









            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");

            Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2,"and o.otoparkID="+parkNo);
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main_Grid.ContextMenuStrip = cmsKayitlar;
            
            goto son;

            bitti:
            MessageBox.Show("Bu araç zaten otoparklarımızda park halinde", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            son:
            mtbMusCepNo.Clear();
            tbAracPlakasi.Clear();
            tb_musteriBilgi.Clear();
            cbOdemeTuru.SelectedIndex = 0;
            cb_islemTuru.SelectedIndex = 0;
            otoparkBilgiGetir();




        }

        private void cb_islemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

            int secili = cb_islemTuru.SelectedIndex;
            if (secili == 2)
            {
                mtbMusCepNo.Enabled = false;
                tb_musteriBilgi.Enabled = false;

                lblOdemeTuru.Visible = true;
                cbOdemeTuru.Visible = true;
                tickIslemTuru.Visible = true;

            }

           else if (secili == 1)  
            {

                mtbMusCepNo.Enabled = true;
                tb_musteriBilgi.Enabled = true;

                lblOdemeTuru.Visible = false;
                cbOdemeTuru.Visible = false;
                tickIslemTuru.Visible = true;

            }

            else tickIslemTuru.Visible = false;

        }

        private void mtbMusCepNo_TextChanged(object sender, EventArgs e)
        {
            if (mtbMusCepNo.TextLength > 0) { tickMusCepNo.Visible = true; }
            else if (mtbMusCepNo.TextLength <= 0) { tickMusCepNo.Visible = false; }

            int secili = cb_islemTuru.SelectedIndex;
            if (secili == 1)  // giriş işlemi
            {
                DataTable musteriKontrol = db.musteriIslemleri.musteriKontrol(mtbMusCepNo.Text);
               

                if (musteriKontrol.Rows.Count > 0) // müşteri kaydı varsa
                {

                    tb_musteriBilgi.Enabled = false;
                    DataRow musteri = db.musteriIslemleri.musteriBilgiGetir(mtbMusCepNo.Text).Rows[0];
                    tb_musteriBilgi.Text = musteri["musAdSoyad"].ToString();
                    mtbMusCepNo.Text = musteri["musCepNO"].ToString();


                   


                }


                else 
                    {
                        tb_musteriBilgi.Text = "";
                    tb_musteriBilgi.Enabled = true;
                    }




            } //giriş sonu








        } //mtbMuscepno textchanged sonu

        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {

            int secili = cbRaporlar.SelectedIndex;
            if (secili == 6)  // giriş işlemi
            {

            }




            if (ara == "kayıtlar")
            {





                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");

                Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2,"and o.otoparkID="+parkNo);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (ara == "faturalar")
            {
                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                Main_Grid.DataSource = db.tarifeIslem.faturalariGetirOtoparkaGore(Convert.ToInt16(parkNo), aralik1, aralik2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {

            if (ara == "kayıtlar")
            {






                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");

                Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2,"and o.otoparkID="+parkNo);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            if (ara == "faturalar")
            {
                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                Main_Grid.DataSource = db.tarifeIslem.faturalariGetirOtoparkaGore(Convert.ToInt16(parkNo), aralik1, aralik2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }



        }

        private void mtbMusCepNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tb_musteriBilgi_TextChanged(object sender, EventArgs e)
        {
            if (tb_musteriBilgi.TextLength > 0) { tickMusBilgi.Visible = true; }
            else if (tb_musteriBilgi.TextLength <= 0) { tickMusBilgi.Visible = false; }

        }

        private void cbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            int secili = cbOdemeTuru.SelectedIndex;
            if (secili == 0) tickOdemeTuru.Visible = false;
            else tickOdemeTuru.Visible = true;


        }
    }
}