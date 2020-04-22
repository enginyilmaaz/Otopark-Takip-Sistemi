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
    public partial class otoparkGuncelle : Form
    {
        public otoparkGuncelle(int guncellenecekParkNo)
        {
            InitializeComponent();




            cbSehir.DataSource = db.otoparkIslem.sehirGetir();
            cbSehir.ValueMember = "SehirId";
            cbSehir.DisplayMember = "SehirAdi";
            cbSehir.SelectedIndex = 0;


            DataRow otopark = db.otoparkIslem.otoparkGetir(guncellenecekParkNo);
            mtbParkNo.Text = otopark["Park NO"].ToString();
            tbotopakAdi.Text = otopark["Otopark Adı"].ToString();



            cbKapasiteSecim.SelectedIndex = 0;
            cbSehir.SelectedIndex = 0;
            cbSehir.SelectedIndex = 1;





            string sehir = otopark["Şehir"].ToString();
            cbSehir.SelectedIndex = cbSehir.FindStringExact(sehir);

            string semt = otopark["İlçe"].ToString();
            cbIlce.SelectedIndex = cbIlce.FindStringExact(semt);

            tbAdres.Text = otopark["Adres"].ToString();

            mtbSuankiKapasite.Text = otopark["Araç Kapasitesi"].ToString();



        }

        private void subeGuncelle_Load(object sender, EventArgs e)
        {


        }

        private void cbSubeSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbIlce.ValueMember = "ilceID";
            cbIlce.DisplayMember = "ilceAdi";

            int sehirid;
            bool parseOK = Int32.TryParse(cbSehir.SelectedValue.ToString(), out sehirid);

            cbIlce.DataSource = db.otoparkIslem.ilceGetir(sehirid);
        }

        private void tbsubeAdi_TextChanged(object sender, EventArgs e)
        {
            if (tbotopakAdi.Text.Length > 3) pb_tick_otoparkAdi.Visible = true;
            else pb_tick_otoparkAdi.Visible = false;
        }

        private void mtbSubeTel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mtbSubeNo_TextChanged(object sender, EventArgs e)
        {

        }



        private void cbSubeIlce_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbIlce.Text != "İlçe Seçiniz...")

            { pb_tick_Ilce.Visible = true; }

            else { pb_tick_Ilce.Visible = false; }
        }

        private void tbSubeAdres_TextChanged(object sender, EventArgs e)
        {
            if (tbAdres.Text.Length > 15) pb_tick_Adres.Visible = true;
            else pb_tick_Adres.Visible = false;
        }

        private void btn_subeEkle_Click(object sender, EventArgs e)
        {
            try
            {

                if (pb_tick_otoparkAdi.Visible && pb_tick_Adres.Visible && pb_tick_kapasite.Visible && pb_tick_Sehir.Visible && pb_tick_Ilce.Visible)
                {
                    int ilceid;
                    bool parseOK = Int32.TryParse(cbIlce.SelectedValue.ToString(), out ilceid);

                    int kapasite = 1;
                    if (cbKapasiteSecim.Enabled == false && mtbKapasite.Enabled == false)
                    {

                        kapasite = 0;
                    }
                    else
                    {
                        if (cbKapasiteSecim.Text == "Arttır") kapasite = Convert.ToInt16(mtbKapasite.Text);
                        else if (cbKapasiteSecim.Text == "Azalt") kapasite = Convert.ToInt16(mtbKapasite.Text) * -1;
                    }
                    db.otoparkIslem.otoparkGuncelle(Convert.ToInt16(mtbParkNo.Text), tbotopakAdi.Text, ilceid, tbAdres.Text, kapasite);
                        MessageBox.Show("Otopark Güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        this.Close();
                  
                }



                else { MessageBox.Show("Bir yada birden fazla bilgi girişi eksik yapıldı, lütfen düzeltin", "Eksik Giriş Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }


            catch (Exception)// 
            {
                MessageBox.Show("Bir hata oluştu, lütfen tekrar deneyin..", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }

        private void mtbKapasite_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbParkNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cbKapasiteSecim.Enabled == false && mtbKapasite.Enabled == false)
            { cbKapasiteSecim.Enabled = true; mtbKapasite.Enabled = true; }

            else { cbKapasiteSecim.Enabled = false; mtbKapasite.Enabled = false; }
        }

    }
}