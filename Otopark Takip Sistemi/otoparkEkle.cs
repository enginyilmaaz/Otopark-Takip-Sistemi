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

    public partial class otoparkEkle : Form
    {
       
        public otoparkEkle()
           
        {
            
            InitializeComponent(); 
        }

  



        private void cbSubeSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

           

           
           cbIlceID.Enabled = true;

            cbIlceID.ValueMember = "ilceID";
            cbIlceID.DisplayMember = "ilceAdi";

            int sehirid;
            bool parseOK = Int32.TryParse(cbSehir.SelectedValue.ToString(), out sehirid);

            cbIlceID.DataSource = db.otoparkIslem.ilceGetir(sehirid);

           
            


           

         



          





        }

        private void button2_Click(object sender, EventArgs e)
        {
        }


     
        private void tbsubeAdi_TextChanged(object sender, EventArgs e)
        {
            if (tbotoparkAdi.Text.Length > 3) pb_tick_otoparkAdi.Visible = true;
            else pb_tick_otoparkAdi.Visible = false;
        }

        private void mtbSubeTel_TextChanged(object sender, EventArgs e)
        {
            if (mtbKapasite.Text.Length > 1) pb_tick_arackapasitesi.Visible = true;
            else pb_tick_arackapasitesi.Visible = false;

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
            if (pb_tick_otoparkAdi.Visible && pb_tick_Adres.Visible && pb_tick_ilce.Visible && pb_tick_Sehir.Visible && pb_tick_arackapasitesi.Visible && pb_tick_otoparkTuru.Visible)
            {


                int ilceid;
                bool parseOK = Int32.TryParse(cbIlceID.SelectedValue.ToString(), out ilceid);

                bool otoparkTuru = false;
                if (cbOtoparkTuru.Text == "Açık Otopark") otoparkTuru = true;
                if (cbOtoparkTuru.Text == "Kapalı Otopark") otoparkTuru = false;

                db.otoparkIslem.otoparkEkle(tbotoparkAdi.Text, ilceid, tbAdres.Text, Convert.ToInt16(mtbKapasite.Text), otoparkTuru, Convert.ToInt16(mtbKapasite.Text));
                MessageBox.Show("Otopark başarıyla eklendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



                this.Close();



            }

            else { MessageBox.Show("Bir yada birden fazla bilgi girişi eksik yapıldı, lütfen düzeltin", "Eksik Giriş Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Error); }

       }


           catch (Exception)// 
           {
                MessageBox.Show("Bir hata oluştu, lütfen tekrar deneyin..", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);


           }



}

        private void mtbSubeTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void cbOtoparkTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOtoparkTuru.Text!= "Seçiniz...")    pb_tick_otoparkTuru.Visible = true;
            else pb_tick_otoparkTuru.Visible = false;
        }

        private void otopark_Load(object sender, EventArgs e)
        {

            cbSehir.DataSource = db.otoparkIslem.sehirGetir();
            cbSehir.ValueMember = "sehirID";
            cbSehir.DisplayMember = "sehirAdi";
            cbSehir.SelectedIndex = 0;
            cbOtoparkTuru.SelectedIndex = 0;

        }
    }
}
