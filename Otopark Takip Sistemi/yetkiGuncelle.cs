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
    public partial class yetkiGuncelle : Form
    {
        int ROL_ID;
        public yetkiGuncelle(int yetkiID)
        {
            InitializeComponent();

            DataRow yetki = db.personelIslemleri.yetkiyiGetir(yetkiID);
          tb_yetki.Text = yetki["Yetki Açıklaması"].ToString();
            ROL_ID = Convert.ToInt16(yetki["Yetki No"]);
            string ekranErisimi = yetki["Ekran Erişimi"].ToString();

            cbModul.DataSource = db.personelIslemleri.modulleriListele();
            cbModul.DisplayMember = "modulAdi";
            cbModul.ValueMember = "modulID";

            cbModul.SelectedIndex = cbModul.FindStringExact(ekranErisimi);
           

        }

 
        private void yetkiGuncelle_Load(object sender, EventArgs e)
        {
        }

        private void btn_yetkili_ekle_Click(object sender, EventArgs e)
        {

            int modulID;
            bool parseOK = Int32.TryParse(cbModul.SelectedValue.ToString(), out modulID);
            db.personelIslemleri.yetkiGuncelle(tb_yetki.Text, modulID, ROL_ID);
            MessageBox.Show("Yetki başarıyla güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            this.Close();
        }
    }
}
