namespace WindowsFormsApplication1
{
    partial class sistemYoneticisiEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sistemYoneticisiEkrani));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.Main_Grid = new System.Windows.Forms.DataGridView();
            this.gbAra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.cbRaporlar = new System.Windows.Forms.ComboBox();
            this.lblRapor = new System.Windows.Forms.Label();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.tb_ara = new System.Windows.Forms.TextBox();
            this.contextMenuStripOtoparklar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsOtoparkiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOtoparkiGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsYeniOtoparkEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTarifeler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tarifeGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripYetkiler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniYetkiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliYetkiyiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliYetkiyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_personelSil = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_personelGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_personelEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripPersoneller = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripKayitlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kayıtDetayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linklabel_cikisYap = new System.Windows.Forms.LinkLabel();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnFaturaListele = new System.Windows.Forms.Button();
            this.btnTarifeEkle = new System.Windows.Forms.Button();
            this.btnYetkiEkle = new System.Windows.Forms.Button();
            this.btn_yetkileriYonet = new System.Windows.Forms.Button();
            this.btnKayitlariListele = new System.Windows.Forms.Button();
            this.btnTarifeler = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnOtoparkEkle = new System.Windows.Forms.Button();
            this.btnPersonelListesi = new System.Windows.Forms.Button();
            this.btnOtoparkListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).BeginInit();
            this.gbAra.SuspendLayout();
            this.contextMenuStripOtoparklar.SuspendLayout();
            this.contextMenuStripTarifeler.SuspendLayout();
            this.contextMenuStripYetkiler.SuspendLayout();
            this.contextMenuStripPersoneller.SuspendLayout();
            this.contextMenuStripKayitlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(336, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(112, 20);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Hoşgeldiniz, ";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonel.Location = new System.Drawing.Point(454, 32);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(78, 20);
            this.lblPersonel.TabIndex = 4;
            this.lblPersonel.Text = " kullanıcı";
            // 
            // Main_Grid
            // 
            this.Main_Grid.AllowDrop = true;
            this.Main_Grid.AllowUserToAddRows = false;
            this.Main_Grid.AllowUserToDeleteRows = false;
            this.Main_Grid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Main_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Main_Grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.Main_Grid.GridColor = System.Drawing.Color.MistyRose;
            this.Main_Grid.Location = new System.Drawing.Point(29, 285);
            this.Main_Grid.MultiSelect = false;
            this.Main_Grid.Name = "Main_Grid";
            this.Main_Grid.ReadOnly = true;
            this.Main_Grid.Size = new System.Drawing.Size(937, 335);
            this.Main_Grid.TabIndex = 6;
            this.Main_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_Grid_CellContentClick);
            // 
            // gbAra
            // 
            this.gbAra.Controls.Add(this.label1);
            this.gbAra.Controls.Add(this.dtpCikis);
            this.gbAra.Controls.Add(this.lblTarihAraligi);
            this.gbAra.Controls.Add(this.dtpGiris);
            this.gbAra.Controls.Add(this.cbRaporlar);
            this.gbAra.Controls.Add(this.lblRapor);
            this.gbAra.Controls.Add(this.lbl_ara);
            this.gbAra.Controls.Add(this.tb_ara);
            this.gbAra.Location = new System.Drawing.Point(29, 221);
            this.gbAra.Name = "gbAra";
            this.gbAra.Size = new System.Drawing.Size(937, 58);
            this.gbAra.TabIndex = 13;
            this.gbAra.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(774, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = " - ";
            // 
            // dtpCikis
            // 
            this.dtpCikis.CustomFormat = "yyyy-MM-dd 23:59";
            this.dtpCikis.Enabled = false;
            this.dtpCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCikis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCikis.Location = new System.Drawing.Point(807, 19);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(115, 26);
            this.dtpCikis.TabIndex = 23;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // lblTarihAraligi
            // 
            this.lblTarihAraligi.AutoSize = true;
            this.lblTarihAraligi.Enabled = false;
            this.lblTarihAraligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihAraligi.Location = new System.Drawing.Point(523, 22);
            this.lblTarihAraligi.Name = "lblTarihAraligi";
            this.lblTarihAraligi.Size = new System.Drawing.Size(109, 20);
            this.lblTarihAraligi.TabIndex = 21;
            this.lblTarihAraligi.Text = "Tarih Aralığı:";
            // 
            // dtpGiris
            // 
            this.dtpGiris.CustomFormat = "yyyy-MM-dd 23:59";
            this.dtpGiris.Enabled = false;
            this.dtpGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGiris.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiris.Location = new System.Drawing.Point(653, 19);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(115, 26);
            this.dtpGiris.TabIndex = 20;
            this.dtpGiris.ValueChanged += new System.EventHandler(this.dtpGiris_ValueChanged);
            // 
            // cbRaporlar
            // 
            this.cbRaporlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRaporlar.FormattingEnabled = true;
            this.cbRaporlar.Items.AddRange(new object[] {
            "Seçiniz...",
            "Otoparkların doluluk raporları",
            "Otoparklara göre personel sayıları",
            "Son haftaya göre otopark bazında ciro",
            "Son aya göre otopark bazında ciro",
            "Son yıla göre otopark bazında ciro",
            "Son haftaya göre genel toplam ciro",
            "Son aya göre genel toplam ciro",
            "Son yıla göre genel toplam ciro",
            "Son haftaya göre otopark bazında giriş araç sayısı",
            "Son aya göre otopark bazında giriş araç sayısı",
            "Son yıla göre otopark bazında giriş araç sayısı",
            "Son  haftaya göre toplam giriş yapan araç sayısı",
            "Son aya göre toplam giriş yapan araç sayısı",
            "Son yıla göre toplam giriş yapan araç sayısı",
            "Toplam otopark sayısı",
            "Toplam personel sayısı",
            "Toplam ciro",
            "Toplam giriş yapan araç sayısı"});
            this.cbRaporlar.Location = new System.Drawing.Point(84, 19);
            this.cbRaporlar.Name = "cbRaporlar";
            this.cbRaporlar.Size = new System.Drawing.Size(419, 28);
            this.cbRaporlar.TabIndex = 15;
            this.cbRaporlar.Visible = false;
            this.cbRaporlar.SelectedIndexChanged += new System.EventHandler(this.cbRaporlar_SelectedIndexChanged);
            // 
            // lblRapor
            // 
            this.lblRapor.AutoSize = true;
            this.lblRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRapor.Location = new System.Drawing.Point(11, 22);
            this.lblRapor.Name = "lblRapor";
            this.lblRapor.Size = new System.Drawing.Size(63, 20);
            this.lblRapor.TabIndex = 14;
            this.lblRapor.Text = "Rapor:";
            this.lblRapor.Visible = false;
            // 
            // lbl_ara
            // 
            this.lbl_ara.AutoSize = true;
            this.lbl_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ara.Location = new System.Drawing.Point(27, 22);
            this.lbl_ara.Name = "lbl_ara";
            this.lbl_ara.Size = new System.Drawing.Size(42, 20);
            this.lbl_ara.TabIndex = 13;
            this.lbl_ara.Text = "Ara:";
            // 
            // tb_ara
            // 
            this.tb_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_ara.Location = new System.Drawing.Point(84, 19);
            this.tb_ara.Name = "tb_ara";
            this.tb_ara.Size = new System.Drawing.Size(419, 26);
            this.tb_ara.TabIndex = 4;
            this.tb_ara.TextChanged += new System.EventHandler(this.tb_ara_TextChanged);
            // 
            // contextMenuStripOtoparklar
            // 
            this.contextMenuStripOtoparklar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsOtoparkiSil,
            this.cmsOtoparkiGuncelle,
            this.cmsYeniOtoparkEkle});
            this.contextMenuStripOtoparklar.Name = "contextMenuStripYetkililer";
            this.contextMenuStripOtoparklar.Size = new System.Drawing.Size(170, 70);
            // 
            // cmsOtoparkiSil
            // 
            this.cmsOtoparkiSil.Name = "cmsOtoparkiSil";
            this.cmsOtoparkiSil.Size = new System.Drawing.Size(169, 22);
            this.cmsOtoparkiSil.Text = "Otoparkı Sil";
            this.cmsOtoparkiSil.Click += new System.EventHandler(this.cmsOtoparkiSil_Click);
            // 
            // cmsOtoparkiGuncelle
            // 
            this.cmsOtoparkiGuncelle.Name = "cmsOtoparkiGuncelle";
            this.cmsOtoparkiGuncelle.Size = new System.Drawing.Size(169, 22);
            this.cmsOtoparkiGuncelle.Text = "Otoparkı Güncelle";
            this.cmsOtoparkiGuncelle.Click += new System.EventHandler(this.cmsOtoparkiGuncelle_Click);
            // 
            // cmsYeniOtoparkEkle
            // 
            this.cmsYeniOtoparkEkle.Name = "cmsYeniOtoparkEkle";
            this.cmsYeniOtoparkEkle.Size = new System.Drawing.Size(169, 22);
            this.cmsYeniOtoparkEkle.Text = "Yeni Otopark Ekle";
            this.cmsYeniOtoparkEkle.Click += new System.EventHandler(this.cmsOtoparkEkle_Click);
            // 
            // contextMenuStripTarifeler
            // 
            this.contextMenuStripTarifeler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarifeGuncelleToolStripMenuItem,
            this.tarifeEkleToolStripMenuItem});
            this.contextMenuStripTarifeler.Name = "contextMenuStripUcretler";
            this.contextMenuStripTarifeler.Size = new System.Drawing.Size(162, 48);
            // 
            // tarifeGuncelleToolStripMenuItem
            // 
            this.tarifeGuncelleToolStripMenuItem.Name = "tarifeGuncelleToolStripMenuItem";
            this.tarifeGuncelleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tarifeGuncelleToolStripMenuItem.Text = "Tarifeyi Guncelle";
            this.tarifeGuncelleToolStripMenuItem.Click += new System.EventHandler(this.tarifeGuncelleToolStripMenuItem_Click);
            // 
            // tarifeEkleToolStripMenuItem
            // 
            this.tarifeEkleToolStripMenuItem.Name = "tarifeEkleToolStripMenuItem";
            this.tarifeEkleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tarifeEkleToolStripMenuItem.Text = "Tarife Ekle";
            this.tarifeEkleToolStripMenuItem.Click += new System.EventHandler(this.tarifeEkleToolStripMenuItem_Click);
            // 
            // contextMenuStripYetkiler
            // 
            this.contextMenuStripYetkiler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniYetkiEkleToolStripMenuItem,
            this.seçiliYetkiyiGüncelleToolStripMenuItem,
            this.seçiliYetkiyiSilToolStripMenuItem});
            this.contextMenuStripYetkiler.Name = "contextMenuStripYetkiler";
            this.contextMenuStripYetkiler.Size = new System.Drawing.Size(188, 70);
            // 
            // yeniYetkiEkleToolStripMenuItem
            // 
            this.yeniYetkiEkleToolStripMenuItem.Name = "yeniYetkiEkleToolStripMenuItem";
            this.yeniYetkiEkleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.yeniYetkiEkleToolStripMenuItem.Text = "Yeni Yetki Ekle";
            this.yeniYetkiEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniYetkiEkleToolStripMenuItem_Click);
            // 
            // seçiliYetkiyiGüncelleToolStripMenuItem
            // 
            this.seçiliYetkiyiGüncelleToolStripMenuItem.Name = "seçiliYetkiyiGüncelleToolStripMenuItem";
            this.seçiliYetkiyiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.seçiliYetkiyiGüncelleToolStripMenuItem.Text = "Seçili Yetkiyi Güncelle";
            this.seçiliYetkiyiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.seçiliYetkiyiGüncelleToolStripMenuItem_Click);
            // 
            // seçiliYetkiyiSilToolStripMenuItem
            // 
            this.seçiliYetkiyiSilToolStripMenuItem.Name = "seçiliYetkiyiSilToolStripMenuItem";
            this.seçiliYetkiyiSilToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.seçiliYetkiyiSilToolStripMenuItem.Text = "Seçili Yetkiyi Sil";
            this.seçiliYetkiyiSilToolStripMenuItem.Click += new System.EventHandler(this.seçiliYetkiyiSilToolStripMenuItem_Click);
            // 
            // cms_personelSil
            // 
            this.cms_personelSil.Name = "cms_personelSil";
            this.cms_personelSil.Size = new System.Drawing.Size(171, 22);
            this.cms_personelSil.Text = "Personeli Sil";
            this.cms_personelSil.Click += new System.EventHandler(this.cms_personelSil_Click);
            // 
            // cms_personelGuncelle
            // 
            this.cms_personelGuncelle.Name = "cms_personelGuncelle";
            this.cms_personelGuncelle.Size = new System.Drawing.Size(171, 22);
            this.cms_personelGuncelle.Text = "Personeli Güncelle";
            this.cms_personelGuncelle.Click += new System.EventHandler(this.cms_personelGuncelle_Click);
            // 
            // cms_personelEkle
            // 
            this.cms_personelEkle.Name = "cms_personelEkle";
            this.cms_personelEkle.Size = new System.Drawing.Size(171, 22);
            this.cms_personelEkle.Text = "Yeni Personel Ekle";
            this.cms_personelEkle.Click += new System.EventHandler(this.cms_personelEkle_Click);
            // 
            // contextMenuStripPersoneller
            // 
            this.contextMenuStripPersoneller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_personelSil,
            this.cms_personelGuncelle,
            this.cms_personelEkle});
            this.contextMenuStripPersoneller.Name = "contextMenuStripYetkililer";
            this.contextMenuStripPersoneller.Size = new System.Drawing.Size(172, 70);
            this.contextMenuStripPersoneller.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripPersoneller_Opening);
            // 
            // contextMenuStripKayitlar
            // 
            this.contextMenuStripKayitlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtDetayıToolStripMenuItem,
            this.sToolStripMenuItem,
            this.sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem,
            this.sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem});
            this.contextMenuStripKayitlar.Name = "contextMenuStripKayitlar";
            this.contextMenuStripKayitlar.Size = new System.Drawing.Size(290, 92);
            this.contextMenuStripKayitlar.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripKayitlar_Opening);
            // 
            // kayıtDetayıToolStripMenuItem
            // 
            this.kayıtDetayıToolStripMenuItem.Name = "kayıtDetayıToolStripMenuItem";
            this.kayıtDetayıToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.kayıtDetayıToolStripMenuItem.Text = "Kayıt Detaylarını Göster";
            this.kayıtDetayıToolStripMenuItem.Click += new System.EventHandler(this.kayıtDetayıToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.sToolStripMenuItem.Text = "Sadece Seçili Otoparkın Kayıtlarını Göster";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem
            // 
            this.sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem.Name = "sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem";
            this.sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem.Text = "Sadece Seçili İlçedeki Kayıtları Göster";
            this.sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem.Click += new System.EventHandler(this.sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem_Click);
            // 
            // sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem
            // 
            this.sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem.Name = "sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem";
            this.sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem.Text = "Sadece Seçili Şehirdeki Kayıtları Göster";
            this.sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem.Click += new System.EventHandler(this.sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem_Click);
            // 
            // linklabel_cikisYap
            // 
            this.linklabel_cikisYap.AutoSize = true;
            this.linklabel_cikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklabel_cikisYap.Location = new System.Drawing.Point(861, 32);
            this.linklabel_cikisYap.Name = "linklabel_cikisYap";
            this.linklabel_cikisYap.Size = new System.Drawing.Size(111, 20);
            this.linklabel_cikisYap.TabIndex = 44;
            this.linklabel_cikisYap.TabStop = true;
            this.linklabel_cikisYap.Text = "Çıkış Yap [X]";
            this.linklabel_cikisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_cikisYap_LinkClicked);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMusteriListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMusteriListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriListele.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriListele.Image")));
            this.btnMusteriListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriListele.Location = new System.Drawing.Point(305, 151);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMusteriListele.Size = new System.Drawing.Size(167, 64);
            this.btnMusteriListele.TabIndex = 43;
            this.btnMusteriListele.Text = "   Müşterileri\r\n   Listele";
            this.btnMusteriListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRaporlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaporlar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.Image = global::WindowsFormsApplication1.Properties.Resources.thin_1075_analytics_report_32;
            this.btnRaporlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaporlar.Location = new System.Drawing.Point(805, 151);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRaporlar.Size = new System.Drawing.Size(161, 65);
            this.btnRaporlar.TabIndex = 42;
            this.btnRaporlar.Text = "      Raporlar";
            this.btnRaporlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRapolar_Click);
            // 
            // btnFaturaListele
            // 
            this.btnFaturaListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFaturaListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFaturaListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaListele.Image = global::WindowsFormsApplication1.Properties.Resources.invoice_32;
            this.btnFaturaListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturaListele.Location = new System.Drawing.Point(654, 151);
            this.btnFaturaListele.Name = "btnFaturaListele";
            this.btnFaturaListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFaturaListele.Size = new System.Drawing.Size(145, 65);
            this.btnFaturaListele.TabIndex = 41;
            this.btnFaturaListele.Text = "   Fatura\r\n   Listele";
            this.btnFaturaListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturaListele.UseVisualStyleBackColor = false;
            this.btnFaturaListele.Click += new System.EventHandler(this.btnFaturaListele_Click);
            // 
            // btnTarifeEkle
            // 
            this.btnTarifeEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTarifeEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTarifeEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarifeEkle.Image = global::WindowsFormsApplication1.Properties.Resources.tag_add_32;
            this.btnTarifeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarifeEkle.Location = new System.Drawing.Point(793, 80);
            this.btnTarifeEkle.Name = "btnTarifeEkle";
            this.btnTarifeEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTarifeEkle.Size = new System.Drawing.Size(173, 65);
            this.btnTarifeEkle.TabIndex = 40;
            this.btnTarifeEkle.Text = "    Tarife\n    Ekle";
            this.btnTarifeEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTarifeEkle.UseVisualStyleBackColor = false;
            this.btnTarifeEkle.Click += new System.EventHandler(this.btnTarifeEkle_Click);
            // 
            // btnYetkiEkle
            // 
            this.btnYetkiEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYetkiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYetkiEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnYetkiEkle.Image")));
            this.btnYetkiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYetkiEkle.Location = new System.Drawing.Point(173, 151);
            this.btnYetkiEkle.Name = "btnYetkiEkle";
            this.btnYetkiEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnYetkiEkle.Size = new System.Drawing.Size(126, 64);
            this.btnYetkiEkle.TabIndex = 38;
            this.btnYetkiEkle.Text = "    Yetki \r\n    Ekle";
            this.btnYetkiEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYetkiEkle.UseVisualStyleBackColor = false;
            this.btnYetkiEkle.Click += new System.EventHandler(this.btnYetkiEkle_Click);
            // 
            // btn_yetkileriYonet
            // 
            this.btn_yetkileriYonet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_yetkileriYonet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_yetkileriYonet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkileriYonet.Image = ((System.Drawing.Image)(resources.GetObject("btn_yetkileriYonet.Image")));
            this.btn_yetkileriYonet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yetkileriYonet.Location = new System.Drawing.Point(29, 151);
            this.btn_yetkileriYonet.Name = "btn_yetkileriYonet";
            this.btn_yetkileriYonet.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_yetkileriYonet.Size = new System.Drawing.Size(138, 64);
            this.btn_yetkileriYonet.TabIndex = 36;
            this.btn_yetkileriYonet.Text = "    Yetkileri  \r\n    Listele  ";
            this.btn_yetkileriYonet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yetkileriYonet.UseVisualStyleBackColor = false;
            this.btn_yetkileriYonet.Click += new System.EventHandler(this.btnYetkileriListele_Click);
            // 
            // btnKayitlariListele
            // 
            this.btnKayitlariListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKayitlariListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKayitlariListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitlariListele.Image = global::WindowsFormsApplication1.Properties.Resources._1459296516_Untitled_2_40;
            this.btnKayitlariListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayitlariListele.Location = new System.Drawing.Point(478, 151);
            this.btnKayitlariListele.Name = "btnKayitlariListele";
            this.btnKayitlariListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnKayitlariListele.Size = new System.Drawing.Size(170, 65);
            this.btnKayitlariListele.TabIndex = 35;
            this.btnKayitlariListele.Text = "    Kayıtları\n       Listele";
            this.btnKayitlariListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayitlariListele.UseVisualStyleBackColor = false;
            this.btnKayitlariListele.Click += new System.EventHandler(this.btnKayitlariListele_Click);
            // 
            // btnTarifeler
            // 
            this.btnTarifeler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTarifeler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTarifeler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarifeler.Image = global::WindowsFormsApplication1.Properties.Resources._1459312700_05_Tag;
            this.btnTarifeler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarifeler.Location = new System.Drawing.Point(617, 80);
            this.btnTarifeler.Name = "btnTarifeler";
            this.btnTarifeler.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTarifeler.Size = new System.Drawing.Size(170, 65);
            this.btnTarifeler.TabIndex = 11;
            this.btnTarifeler.Text = "   Tarife\r\n    Listele";
            this.btnTarifeler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTarifeler.UseVisualStyleBackColor = false;
            this.btnTarifeler.Click += new System.EventHandler(this.btnTarifeListesi_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPersonelEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Image = global::WindowsFormsApplication1.Properties.Resources._1459297874_group_full_add;
            this.btnPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelEkle.Location = new System.Drawing.Point(478, 80);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPersonelEkle.Size = new System.Drawing.Size(133, 65);
            this.btnPersonelEkle.TabIndex = 10;
            this.btnPersonelEkle.Text = "    Personel  Ekle";
            this.btnPersonelEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnOtoparkEkle
            // 
            this.btnOtoparkEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOtoparkEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOtoparkEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtoparkEkle.Image = global::WindowsFormsApplication1.Properties.Resources.branche_add_32;
            this.btnOtoparkEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtoparkEkle.Location = new System.Drawing.Point(186, 80);
            this.btnOtoparkEkle.Name = "btnOtoparkEkle";
            this.btnOtoparkEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnOtoparkEkle.Size = new System.Drawing.Size(126, 65);
            this.btnOtoparkEkle.TabIndex = 9;
            this.btnOtoparkEkle.Text = "Otopark  Ekle";
            this.btnOtoparkEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOtoparkEkle.UseVisualStyleBackColor = false;
            this.btnOtoparkEkle.Click += new System.EventHandler(this.btnOtoparkEkle_Click);
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPersonelListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonelListesi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListesi.Image = global::WindowsFormsApplication1.Properties.Resources._1459296516_Untitled_2_40;
            this.btnPersonelListesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelListesi.Location = new System.Drawing.Point(318, 80);
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPersonelListesi.Size = new System.Drawing.Size(154, 65);
            this.btnPersonelListesi.TabIndex = 8;
            this.btnPersonelListesi.Text = "   Personelleri    Listele";
            this.btnPersonelListesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelListesi.UseVisualStyleBackColor = false;
            this.btnPersonelListesi.Click += new System.EventHandler(this.btnPersonelListesi_Click);
            // 
            // btnOtoparkListele
            // 
            this.btnOtoparkListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOtoparkListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOtoparkListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtoparkListele.Image = global::WindowsFormsApplication1.Properties.Resources.travel_agency_32;
            this.btnOtoparkListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtoparkListele.Location = new System.Drawing.Point(29, 80);
            this.btnOtoparkListele.Name = "btnOtoparkListele";
            this.btnOtoparkListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnOtoparkListele.Size = new System.Drawing.Size(151, 65);
            this.btnOtoparkListele.TabIndex = 7;
            this.btnOtoparkListele.Text = "  Otoparkları\r\n   Listele";
            this.btnOtoparkListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOtoparkListele.UseVisualStyleBackColor = false;
            this.btnOtoparkListele.Click += new System.EventHandler(this.btnOtoparkListele_Click);
            // 
            // sistemYoneticisiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 632);
            this.Controls.Add(this.linklabel_cikisYap);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnFaturaListele);
            this.Controls.Add(this.btnTarifeEkle);
            this.Controls.Add(this.btnYetkiEkle);
            this.Controls.Add(this.btn_yetkileriYonet);
            this.Controls.Add(this.btnKayitlariListele);
            this.Controls.Add(this.gbAra);
            this.Controls.Add(this.btnTarifeler);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnOtoparkEkle);
            this.Controls.Add(this.btnPersonelListesi);
            this.Controls.Add(this.btnOtoparkListele);
            this.Controls.Add(this.Main_Grid);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sistemYoneticisiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Yöneticisi Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sistemYoneticisiEkrani_FormClosing);
            this.Load += new System.EventHandler(this.SistemYoneticisiEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).EndInit();
            this.gbAra.ResumeLayout(false);
            this.gbAra.PerformLayout();
            this.contextMenuStripOtoparklar.ResumeLayout(false);
            this.contextMenuStripTarifeler.ResumeLayout(false);
            this.contextMenuStripYetkiler.ResumeLayout(false);
            this.contextMenuStripPersoneller.ResumeLayout(false);
            this.contextMenuStripKayitlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Button btnPersonelListesi;
        private System.Windows.Forms.Button btnOtoparkListele;
        private System.Windows.Forms.DataGridView Main_Grid;
        private System.Windows.Forms.Button btnOtoparkEkle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnTarifeler;
        private System.Windows.Forms.GroupBox gbAra;
        private System.Windows.Forms.TextBox tb_ara;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOtoparklar;
        private System.Windows.Forms.ToolStripMenuItem cmsOtoparkiSil;
        private System.Windows.Forms.ToolStripMenuItem cmsOtoparkiGuncelle;
        private System.Windows.Forms.ToolStripMenuItem cmsYeniOtoparkEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTarifeler;
        private System.Windows.Forms.ToolStripMenuItem tarifeGuncelleToolStripMenuItem;
        private System.Windows.Forms.Button btnKayitlariListele;
        private System.Windows.Forms.Button btn_yetkileriYonet;
        private System.Windows.Forms.Button btnYetkiEkle;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.Button btnTarifeEkle;
        private System.Windows.Forms.Button btnFaturaListele;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripYetkiler;
        private System.Windows.Forms.ToolStripMenuItem yeniYetkiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliYetkiyiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifeEkleToolStripMenuItem;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Label lblRapor;
        private System.Windows.Forms.ComboBox cbRaporlar;
        private System.Windows.Forms.ToolStripMenuItem cms_personelSil;
        private System.Windows.Forms.ToolStripMenuItem cms_personelGuncelle;
        private System.Windows.Forms.ToolStripMenuItem cms_personelEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPersoneller;
        private System.Windows.Forms.ToolStripMenuItem seçiliYetkiyiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripKayitlar;
        private System.Windows.Forms.ToolStripMenuItem kayıtDetayıToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linklabel_cikisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadeceSeçiliİlçedekiKayıtlarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadeceSeçiliŞehirdekiKayıtlarıGösterToolStripMenuItem;
    }
}