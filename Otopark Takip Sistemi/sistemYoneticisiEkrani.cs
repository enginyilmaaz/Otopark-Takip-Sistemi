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
  

    public partial class sistemYoneticisiEkrani : Form
    {
        
        public sistemYoneticisiEkrani(string tcNo)
        {
            
            InitializeComponent();
            

            lblPersonel.Text = tcNo;
          

        }

        string ara= "otoparklar";
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
                zaman1= new DateTime(suan.Year, suan.Month, 1).ToString("yyyy-MM-dd 00:00:00");
                zaman2= new DateTime(suan.Year, suan.Month, 1).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59");

           
                }


        public void yilHesapla()
        {
            zaman1= new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy-MM-dd 00:00:00");
            zaman2= new DateTime(DateTime.Now.Year, 1, 1).AddYears(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59");


           
        }






        private void SistemYoneticisiEkrani_Load(object sender, EventArgs e)
        {
            cbRaporlar.SelectedIndex=0;
            Main_Grid.DataSource = db.otoparkIslem.otoparklariGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripOtoparklar;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtpGiris.Value = DateTime.Today.AddDays(-7);
            dtpCikis.Value = DateTime.Today;
        }


        private void yenPersonelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelEkle s = new personelEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
        }

     

        private void sistemYoneticisiEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);

            if (x == DialogResult.Yes)
            { Environment.Exit(0);  } 

            else if (x == DialogResult.No)
            {  e.Cancel = true; }

            }


        private void btnPersonelListesi_Click(object sender, EventArgs e)
        {

            Main_Grid.DataSource = db.personelIslemleri.PersonelleriGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripPersoneller;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "personeller";
            tb_ara.Enabled =true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;



        }

        private void btnOtoparkListele_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.otoparkIslem.otoparklariGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripOtoparklar;
            Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
            ara = "otoparklar";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;
        }

        private void btnOtoparkEkle_Click(object sender, EventArgs e)
        {
            otoparkEkle s = new otoparkEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.otoparkIslem.otoparklariGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main_Grid.ContextMenuStrip = contextMenuStripOtoparklar;
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

            ara = "otoparklar";

            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;

        }



        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {

            personelEkle s = new personelEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.personelIslemleri.PersonelleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main_Grid.ContextMenuStrip = contextMenuStripOtoparklar;
            ara = "personeller";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;

        }

        private void cms_personelSil_Click(object sender, EventArgs e)
        {
            ara = "personeller";
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili kullancıyı silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {

                DataGridViewRow seciliPersonel = Main_Grid.CurrentRow;
                string PersonelKimlikNO = seciliPersonel.Cells["Kimlik No"].Value.ToString();

                db.personelIslemleri.PersonelSil(PersonelKimlikNO);

                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main_Grid.DataSource = db.personelIslemleri.PersonelleriGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void cms_personelGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliPersonel = Main_Grid.CurrentRow;
            string PersonelTC = seciliPersonel.Cells["Kimlik NO"].Value.ToString();
            personelGuncelle s = new personelGuncelle(PersonelTC, true);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.personelIslemleri.PersonelleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "personeller";
        }  

        private void cms_personelEkle_Click(object sender, EventArgs e)
        {
            ara = "personeller";
            personelEkle s = new personelEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.personelIslemleri.PersonelleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmsOtoparkEkle_Click(object sender, EventArgs e)
        {
            ara = "otoparklar";
            otoparkEkle s = new otoparkEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.otoparkIslem.otoparklariGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void cmsOtoparkiSil_Click(object sender, EventArgs e)
        {
            ara = "otoparklar";
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili otopark şubesini silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {

                DataGridViewRow seciliOtopark = Main_Grid.CurrentRow;
                int parkNo = Convert.ToInt16(seciliOtopark.Cells["Park NO"].Value);

                db.otoparkIslem.otoparkSil(parkNo);

                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main_Grid.DataSource = db.otoparkIslem.otoparklariGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void cmsOtoparkiGuncelle_Click(object sender, EventArgs e)
        {
            ara = "otoparklar";
            DataGridViewRow seciliOtopark = Main_Grid.CurrentRow;
            int parkNo = Convert.ToInt16(seciliOtopark.Cells["Park NO"].Value);
            otoparkGuncelle s = new otoparkGuncelle(parkNo);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.otoparkIslem.otoparklariGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTarifeListesi_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.tarifeIslem.tarifeleriGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripTarifeler;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "tarifeler";
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;

        }



        private void tarifeGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliTarife = Main_Grid.CurrentRow;
            int parkNO = Convert.ToInt16(seciliTarife.Cells["Park No"].Value);
          
        
   
            tarifeGuncelle s = new tarifeGuncelle(parkNO);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.tarifeIslem.tarifeleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        



        private void tb_ara_TextChanged(object sender, EventArgs e)
        {
            if (tb_ara.TextLength > 0)

            {
                if (ara == "personeller")
                {
                    Main_Grid.DataSource = db.personelIslemleri.personelAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (ara == "kayıtlar")
                {
                    string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                    string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");

                  
                    Main_Grid.DataSource = db.otoparkIslem.kayitAra(aralik1,aralik2,tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }



                if (ara == "otoparklar")

                {
                    
                  
                    
                        Main_Grid.DataSource = db.otoparkIslem.otoparkAra(tb_ara.Text);
                        Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    



                }
               
                if (ara == "musteriler")
                {
                    Main_Grid.DataSource = db.musteriIslemleri.musteriAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

               


                if (ara == "yetkiler")
                {
                    Main_Grid.DataSource = db.personelIslemleri.yetkiAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


              
                if (ara == "tarifeler")
                {
                    Main_Grid.DataSource = db.tarifeIslem.tarifeAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "faturalar")
                {
                    string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                    string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                    Main_Grid.DataSource = db.tarifeIslem.faturaAra(tb_ara.Text,aralik1,aralik2);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }



            else if (tb_ara.TextLength<=0)

            {
                if (ara == "personeller")

                { Main_Grid.DataSource = db.personelIslemleri.PersonelleriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "otoparklar")

                { Main_Grid.DataSource = db.otoparkIslem.otoparklariGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


             

                if (ara == "musteriler")
                {
                    Main_Grid.DataSource = db.musteriIslemleri.musterileriGetir();
                  
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

             


                if (ara == "yetkiler")
                {
                    Main_Grid.DataSource = db.personelIslemleri.yetkileriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


              
                if (ara == "tarifeler")
                {
                    Main_Grid.DataSource = db.tarifeIslem.tarifeleriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (ara == "kayıtlar")
                {
                    string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                    string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                    Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2, "");
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (ara == "faturalar")
                {
                    string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                    string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                    Main_Grid.DataSource = db.tarifeIslem.faturalariGetir(aralik1,aralik2);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }









        }

       

        private void btnKayitlariListele_Click(object sender, EventArgs e)
        {
            ara = "kayıtlar";
            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
            Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1,aralik2,"");
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             
            cbRaporlar.Visible = false;
            Main_Grid.ContextMenuStrip = contextMenuStripKayitlar;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            label1.Enabled = true;
            dtpGiris.Enabled = true;
            dtpCikis.Enabled = true;
            lblTarihAraligi.Enabled = true;
        }

     
      

        private void Main_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnYetkileriListele_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.personelIslemleri.yetkileriGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripYetkiler;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "yetkiler";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;
        }

       



        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            yetkiEkrani s = new yetkiEkrani();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.ContextMenuStrip = contextMenuStripYetkiler;
            
            ara = "yetkiler";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
            Main_Grid.DataSource = db.personelIslemleri.yetkileriGetir();
            
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        

       

        private void seçiliYetkiyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili yetkiyi silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           if (sonuc == DialogResult.OK)
            {
                DataGridViewRow secili = Main_Grid.CurrentRow;
                int yetkiNo = Convert.ToInt16(secili.Cells["Yetki No"].Value);
                 db.personelIslemleri.yetkiSil(yetkiNo);
                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  Main_Grid.DataSource = db.personelIslemleri.yetkileriGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnTarifeEkle_Click(object sender, EventArgs e)
        {
            fiyatEkle s = new fiyatEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.tarifeIslem.tarifeleriGetir();
           Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ara = "tarifeler";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
            Main_Grid.ContextMenuStrip = contextMenuStripTarifeler;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;

        }





        









        private void tarifeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fiyatEkle s = new fiyatEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.tarifeIslem.tarifeleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ara = "tarifeler";
            tb_ara.Enabled = true;
        }

    

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.musteriIslemleri.musterileriGetir();
            Main_Grid.ContextMenuStrip = null;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "musteriler";
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;

        }

        private void btnFaturaListele_Click(object sender, EventArgs e)
        {

           
                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                Main_Grid.DataSource = db.tarifeIslem.faturalariGetir(aralik1, aralik2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
           
            Main_Grid.ContextMenuStrip = null;
          
            ara = "faturalar";
            cbRaporlar.Visible = false;

            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            label1.Enabled = true;
            dtpGiris.Enabled = true;
            dtpCikis.Enabled = true;
            lblTarihAraligi.Enabled = true;

        }

        private void yeniYetkiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yetkiEkrani s = new yetkiEkrani();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.ContextMenuStrip = contextMenuStripYetkiler;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "yetkiler";
            tb_ara.Enabled = true;
        }

     
   
        private void btnRapolar_Click(object sender, EventArgs e)
        {
            lbl_ara.Visible = false;
            lblRapor.Visible = true;
            cbRaporlar.Visible = true;
            label1.Enabled = false;
            dtpGiris.Enabled = false;
            dtpCikis.Enabled = false;
            lblTarihAraligi.Enabled = false;
        }
      
        private void cbRaporlar_SelectedIndexChanged(object sender, EventArgs e)
        { int secili = cbRaporlar.SelectedIndex;
            if (secili == 1)
            {
                Main_Grid.DataSource = db.otoparkIslem.dolulukOrani();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if(secili == 2)
            {

              
                Main_Grid.DataSource = db.personelIslemleri.otoparklaraGorePersonelSayisi();
               Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 3)
            {

                HaftaHesapla();
                Main_Grid.DataSource = db.tarifeIslem.otoparklaraGoreToplamCiroFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 4)
            {
                ayHesapla();
                Main_Grid.DataSource = db.tarifeIslem.otoparklaraGoreToplamCiroFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 5)
            {
                yilHesapla();
                Main_Grid.DataSource = db.tarifeIslem.otoparklaraGoreToplamCiroFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }



            else if (secili == 6)
            {
                HaftaHesapla();
                Main_Grid.DataSource = db.tarifeIslem.ToplamCiroFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }



            else if (secili == 7)
            {
                ayHesapla();
                Main_Grid.DataSource = db.tarifeIslem.ToplamCiroFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else if (secili == 8)
            {
                yilHesapla();
                Main_Grid.DataSource = db.tarifeIslem.ToplamCiroFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 9)
            {
                HaftaHesapla();
                 Main_Grid.DataSource = db.otoparkIslem.otoparklaraGoreGirisYapanAracSayisiFiltreli(zaman1,zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 10)
            {



                ayHesapla();
                Main_Grid.DataSource = db.otoparkIslem.otoparklaraGoreGirisYapanAracSayisiFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 11)
            {



                yilHesapla();
                Main_Grid.DataSource = db.otoparkIslem.otoparklaraGoreGirisYapanAracSayisiFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }




            else if (secili == 12)
            {



                HaftaHesapla();
                Main_Grid.DataSource = db.otoparkIslem.toplamGirisAracSayisiFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }




            else if (secili == 13)
            {



                ayHesapla();
                Main_Grid.DataSource = db.otoparkIslem.toplamGirisAracSayisiFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else if (secili == 14)
            {



                yilHesapla();
                Main_Grid.DataSource = db.otoparkIslem.toplamGirisAracSayisiFiltreli(zaman1, zaman2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 15)
            {



              
                Main_Grid.DataSource = db.otoparkIslem.toplamOtoparkSayisi();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 16)
            {




                Main_Grid.DataSource = db.personelIslemleri.toplamPersonelSayisi();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 17)
            {




                Main_Grid.DataSource = db.tarifeIslem.ToplamCiro();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 18)
            {




                Main_Grid.DataSource = db.otoparkIslem.toplamGirisAracSayisi();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }



        }

        private void seçiliYetkiyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow secili = Main_Grid.CurrentRow;
            int yetkiNo = Convert.ToInt16(secili.Cells["Yetki No"].Value);

           yetkiGuncelle s = new yetkiGuncelle(yetkiNo);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;

            Main_Grid.DataSource = db.personelIslemleri.yetkileriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void kayıtDetayıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow secili = Main_Grid.CurrentRow;
            int islemID = Convert.ToInt16(secili.Cells["İşlem No"].Value);

            kayitDetay s = new kayitDetay(islemID);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
            Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2, "");
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void linklabel_cikisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            girisEkrani s= new girisEkrani();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
        }

        private void contextMenuStripPersoneller_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStripKayitlar_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            if (ara=="kayıtlar")
            {

                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                  Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1,aralik2,"");
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

            if (ara == "faturalar")
            {

                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                Main_Grid.DataSource = db.tarifeIslem.faturalariGetir(aralik1, aralik2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            if (ara == "kayıtlar")
            {

                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                  Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1,aralik2,"");
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

            if (ara == "faturalar")
            {

                string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
                string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
                Main_Grid.DataSource = db.tarifeIslem.faturalariGetir(aralik1, aralik2);
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow secili = Main_Grid.CurrentRow;
            int islemID = Convert.ToInt16(secili.Cells["İşlem No"].Value);
            DataRow detay = db.otoparkIslem.kaydiGetir(islemID);
          string otoparkID= detay["otoparkID"].ToString();


            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
              Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1,aralik2,"and o.otoparkID="+otoparkID);
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow secili = Main_Grid.CurrentRow;
            int islemID = Convert.ToInt16(secili.Cells["İşlem No"].Value);
            DataRow detay = db.otoparkIslem.kaydiGetir(islemID);
            string ilceID = detay["ilceID"].ToString();


            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
            Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2, "and ii.ilceID=" + ilceID);
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow secili = Main_Grid.CurrentRow;
            int islemID = Convert.ToInt16(secili.Cells["İşlem No"].Value);
            DataRow detay = db.otoparkIslem.kaydiGetir(islemID);
            string SehirId = detay["SehirID"].ToString();


            string aralik1 = dtpGiris.Value.ToString("yyyy-MM-dd 00:00:00");
            string aralik2 = dtpCikis.Value.ToString("yyyy-MM-dd 23:59:59");
            Main_Grid.DataSource = db.otoparkIslem.kayitlariGetirFiltreli(aralik1, aralik2, "and i.SehirID=" + SehirId);
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }

    internal class RegEx
    {
        private string v;

        public RegEx(string v)
        {
            this.v = v;
        }
    }
}
