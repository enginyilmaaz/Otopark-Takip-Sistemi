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
    public partial class fiyatEkle : Form
    {
        
        public fiyatEkle()
        {
            InitializeComponent();
        }

        private void btn_yetkili_ekle_Click(object sender, EventArgs e)
        {




                int parkid;
            bool parseOK = Int32.TryParse(cbOtopark.SelectedValue.ToString(), out parkid);
            db.tarifeIslem.tarifeEkle(parkid,Convert.ToInt16(tbilkSaatUcreti.Text), Convert.ToInt16(tbSonrakiSaatBasiUcret.Text), Convert.ToInt16(tbGunlukUcret.Text));
            MessageBox.Show("Ücret başarıyla eklendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void uucretEkle_Load(object sender, EventArgs e)
        {
            cbOtopark.DataSource = db.tarifeIslem.tarifesiOlmayanOtoparklariGetir();
            cbOtopark.DisplayMember = "Otopark Adı";
            cbOtopark.ValueMember = "Park NO";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            }
    }
}
