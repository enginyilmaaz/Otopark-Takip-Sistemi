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
    public partial class yetkiEkrani : Form
    {
        public yetkiEkrani()
        {
            InitializeComponent();
        }

        private void btn_yetkili_ekle_Click(object sender, EventArgs e)
        {

            int modulID;
            bool parseOK = Int32.TryParse(cbModul.SelectedValue.ToString(), out modulID);
            db.personelIslemleri.yetkiEkle(tb_yetki.Text, modulID);
            MessageBox.Show("Yetki başarıyla eklendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            this.Close();
        }

        private void yetkiEkrani_Load(object sender, EventArgs e)
        {
            cbModul.DataSource = db.personelIslemleri.modulleriListele();
            cbModul.DisplayMember = "modulAdi";
            cbModul.ValueMember = "modulID";
        }
    }
}
