namespace WindowsFormsApplication1
{
    partial class otoparkEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otoparkEkrani));
            this.Main_Grid = new System.Windows.Forms.DataGridView();
            this.lbl_HeaderINfo = new System.Windows.Forms.Label();
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.contextMenuStripPersoneller = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personelGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.cbRaporlar = new System.Windows.Forms.ComboBox();
            this.lblRapor = new System.Windows.Forms.Label();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.tb_ara = new System.Windows.Forms.TextBox();
            this.linklabel_cikisYap = new System.Windows.Forms.LinkLabel();
            this.lblFooterInfo = new System.Windows.Forms.Label();
            this.btnRapolar = new System.Windows.Forms.Button();
            this.btnFaturaListele = new System.Windows.Forms.Button();
            this.btnKayitlariListele = new System.Windows.Forms.Button();
            this.btn_islemYap = new System.Windows.Forms.Button();
            this.btnPersonelListesi = new System.Windows.Forms.Button();
            this.btnSubeDegistir = new System.Windows.Forms.Button();
            this.cmsKayitlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsmiKayitDetayi = new System.Windows.Forms.ToolStripMenuItem();
            this.gbIslemYap = new System.Windows.Forms.GroupBox();
            this.tickMusCepNo = new System.Windows.Forms.PictureBox();
            this.tickMusBilgi = new System.Windows.Forms.PictureBox();
            this.ticlkPlaka = new System.Windows.Forms.PictureBox();
            this.tickIslemTuru = new System.Windows.Forms.PictureBox();
            this.cbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.lblAracPlakasi = new System.Windows.Forms.Label();
            this.tbAracPlakasi = new System.Windows.Forms.TextBox();
            this.cb_islemTuru = new System.Windows.Forms.ComboBox();
            this.lbl_islemTuru = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.mtbMusCepNo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefon_no = new System.Windows.Forms.Label();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.tb_musteriBilgi = new System.Windows.Forms.TextBox();
            this.tickOdemeTuru = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).BeginInit();
            this.contextMenuStripPersoneller.SuspendLayout();
            this.gbAra.SuspendLayout();
            this.cmsKayitlar.SuspendLayout();
            this.gbIslemYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickMusCepNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickMusBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticlkPlaka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickIslemTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickOdemeTuru)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Grid
            // 
            this.Main_Grid.AllowDrop = true;
            this.Main_Grid.AllowUserToAddRows = false;
            this.Main_Grid.AllowUserToDeleteRows = false;
            this.Main_Grid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Main_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Main_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Main_Grid.GridColor = System.Drawing.Color.MistyRose;
            this.Main_Grid.Location = new System.Drawing.Point(25, 205);
            this.Main_Grid.MultiSelect = false;
            this.Main_Grid.Name = "Main_Grid";
            this.Main_Grid.ReadOnly = true;
            this.Main_Grid.Size = new System.Drawing.Size(959, 336);
            this.Main_Grid.TabIndex = 26;
            this.Main_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_Grid_CellContentClick);
            // 
            // lbl_HeaderINfo
            // 
            this.lbl_HeaderINfo.AutoSize = true;
            this.lbl_HeaderINfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HeaderINfo.Location = new System.Drawing.Point(143, 32);
            this.lbl_HeaderINfo.Name = "lbl_HeaderINfo";
            this.lbl_HeaderINfo.Size = new System.Drawing.Size(78, 20);
            this.lbl_HeaderINfo.TabIndex = 25;
            this.lbl_HeaderINfo.Text = " kullanıcı";
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldiniz.Location = new System.Drawing.Point(34, 32);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(112, 20);
            this.lblHosgeldiniz.TabIndex = 24;
            this.lblHosgeldiniz.Text = "Hoşgeldiniz, ";
            // 
            // contextMenuStripPersoneller
            // 
            this.contextMenuStripPersoneller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelGüncelleToolStripMenuItem,
            this.personelSilToolStripMenuItem});
            this.contextMenuStripPersoneller.Name = "contextMenuStripPersoneller";
            this.contextMenuStripPersoneller.Size = new System.Drawing.Size(169, 48);
            // 
            // personelGüncelleToolStripMenuItem
            // 
            this.personelGüncelleToolStripMenuItem.Name = "personelGüncelleToolStripMenuItem";
            this.personelGüncelleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.personelGüncelleToolStripMenuItem.Text = "Personel Güncelle";
            this.personelGüncelleToolStripMenuItem.Click += new System.EventHandler(this.personelGüncelleToolStripMenuItem_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.personelSilToolStripMenuItem.Text = "Personel Sil";
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.personelSilToolStripMenuItem_Click);
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
            this.gbAra.Location = new System.Drawing.Point(25, 139);
            this.gbAra.Name = "gbAra";
            this.gbAra.Size = new System.Drawing.Size(959, 58);
            this.gbAra.TabIndex = 45;
            this.gbAra.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(782, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = " - ";
            // 
            // dtpCikis
            // 
            this.dtpCikis.CustomFormat = "yyyy-MM-dd 23:59";
            this.dtpCikis.Enabled = false;
            this.dtpCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCikis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCikis.Location = new System.Drawing.Point(815, 19);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(115, 26);
            this.dtpCikis.TabIndex = 19;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // lblTarihAraligi
            // 
            this.lblTarihAraligi.AutoSize = true;
            this.lblTarihAraligi.Enabled = false;
            this.lblTarihAraligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihAraligi.Location = new System.Drawing.Point(531, 22);
            this.lblTarihAraligi.Name = "lblTarihAraligi";
            this.lblTarihAraligi.Size = new System.Drawing.Size(109, 20);
            this.lblTarihAraligi.TabIndex = 17;
            this.lblTarihAraligi.Text = "Tarih Aralığı:";
            // 
            // dtpGiris
            // 
            this.dtpGiris.CustomFormat = "yyyy-MM-dd 23:59";
            this.dtpGiris.Enabled = false;
            this.dtpGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGiris.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiris.Location = new System.Drawing.Point(661, 19);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(115, 26);
            this.dtpGiris.TabIndex = 16;
            this.dtpGiris.ValueChanged += new System.EventHandler(this.dtpGiris_ValueChanged);
            // 
            // cbRaporlar
            // 
            this.cbRaporlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRaporlar.FormattingEnabled = true;
            this.cbRaporlar.Items.AddRange(new object[] {
            "Seçiniz...",
            "Otopark doluluk raporu",
            "Henüz Çıkış Yapmamış Olan Araçlar",
            "Personel sayısı",
            "Son haftaya göre ciro",
            "Son aya göre ciro",
            "Son yıla göre ciro",
            "Toplam ciro",
            "Son haftaya göre giriş yapan araç sayısı",
            "Son aya göre giriş yapan araç sayısı",
            "Son yıla göre giriş yapan araç sayısı",
            "Toplam giriş yapan araç sayısı"});
            this.cbRaporlar.Location = new System.Drawing.Point(88, 19);
            this.cbRaporlar.Name = "cbRaporlar";
            this.cbRaporlar.Size = new System.Drawing.Size(402, 26);
            this.cbRaporlar.TabIndex = 15;
            this.cbRaporlar.Visible = false;
            this.cbRaporlar.SelectedIndexChanged += new System.EventHandler(this.cbRaporlar_SelectedIndexChanged);
            // 
            // lblRapor
            // 
            this.lblRapor.AutoSize = true;
            this.lblRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRapor.Location = new System.Drawing.Point(19, 22);
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
            this.lbl_ara.Location = new System.Drawing.Point(24, 22);
            this.lbl_ara.Name = "lbl_ara";
            this.lbl_ara.Size = new System.Drawing.Size(42, 20);
            this.lbl_ara.TabIndex = 13;
            this.lbl_ara.Text = "Ara:";
            // 
            // tb_ara
            // 
            this.tb_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_ara.Location = new System.Drawing.Point(72, 19);
            this.tb_ara.Name = "tb_ara";
            this.tb_ara.Size = new System.Drawing.Size(438, 26);
            this.tb_ara.TabIndex = 4;
            this.tb_ara.TextChanged += new System.EventHandler(this.tb_ara_TextChanged);
            // 
            // linklabel_cikisYap
            // 
            this.linklabel_cikisYap.AutoSize = true;
            this.linklabel_cikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklabel_cikisYap.Location = new System.Drawing.Point(863, 32);
            this.linklabel_cikisYap.Name = "linklabel_cikisYap";
            this.linklabel_cikisYap.Size = new System.Drawing.Size(111, 20);
            this.linklabel_cikisYap.TabIndex = 46;
            this.linklabel_cikisYap.TabStop = true;
            this.linklabel_cikisYap.Text = "Çıkış Yap [X]";
            this.linklabel_cikisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_cikisYap_LinkClicked);
            // 
            // lblFooterInfo
            // 
            this.lblFooterInfo.AutoSize = true;
            this.lblFooterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooterInfo.Location = new System.Drawing.Point(34, 566);
            this.lblFooterInfo.Name = "lblFooterInfo";
            this.lblFooterInfo.Size = new System.Drawing.Size(78, 20);
            this.lblFooterInfo.TabIndex = 47;
            this.lblFooterInfo.Text = " kullanıcı";
            // 
            // btnRapolar
            // 
            this.btnRapolar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRapolar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRapolar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapolar.Image = global::WindowsFormsApplication1.Properties.Resources.thin_1075_analytics_report_32;
            this.btnRapolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapolar.Location = new System.Drawing.Point(840, 73);
            this.btnRapolar.Name = "btnRapolar";
            this.btnRapolar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRapolar.Size = new System.Drawing.Size(144, 60);
            this.btnRapolar.TabIndex = 44;
            this.btnRapolar.Text = "Raporlar";
            this.btnRapolar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRapolar.UseVisualStyleBackColor = false;
            this.btnRapolar.Click += new System.EventHandler(this.btnRapolar_Click);
            // 
            // btnFaturaListele
            // 
            this.btnFaturaListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFaturaListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFaturaListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaListele.Image = global::WindowsFormsApplication1.Properties.Resources.invoice_32;
            this.btnFaturaListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturaListele.Location = new System.Drawing.Point(686, 73);
            this.btnFaturaListele.Name = "btnFaturaListele";
            this.btnFaturaListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFaturaListele.Size = new System.Drawing.Size(148, 60);
            this.btnFaturaListele.TabIndex = 43;
            this.btnFaturaListele.Text = "   Fatura\r\n   Listele";
            this.btnFaturaListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturaListele.UseVisualStyleBackColor = false;
            this.btnFaturaListele.Click += new System.EventHandler(this.btnFaturaListele_Click);
            // 
            // btnKayitlariListele
            // 
            this.btnKayitlariListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKayitlariListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKayitlariListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitlariListele.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitlariListele.Image")));
            this.btnKayitlariListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayitlariListele.Location = new System.Drawing.Point(521, 73);
            this.btnKayitlariListele.Name = "btnKayitlariListele";
            this.btnKayitlariListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnKayitlariListele.Size = new System.Drawing.Size(159, 60);
            this.btnKayitlariListele.TabIndex = 34;
            this.btnKayitlariListele.Text = "   Kayıtları   Listele";
            this.btnKayitlariListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayitlariListele.UseVisualStyleBackColor = false;
            this.btnKayitlariListele.Click += new System.EventHandler(this.btnKayitlariListele_Click);
            // 
            // btn_islemYap
            // 
            this.btn_islemYap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_islemYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_islemYap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islemYap.Image = global::WindowsFormsApplication1.Properties.Resources.web_37_32__1_;
            this.btn_islemYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_islemYap.Location = new System.Drawing.Point(374, 73);
            this.btn_islemYap.Name = "btn_islemYap";
            this.btn_islemYap.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_islemYap.Size = new System.Drawing.Size(141, 60);
            this.btn_islemYap.TabIndex = 33;
            this.btn_islemYap.Text = "  İşlem Yap";
            this.btn_islemYap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_islemYap.UseVisualStyleBackColor = false;
            this.btn_islemYap.Click += new System.EventHandler(this.btn_islemYap_Click);
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPersonelListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonelListesi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListesi.Image = global::WindowsFormsApplication1.Properties.Resources._1459296516_Untitled_2_40;
            this.btnPersonelListesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelListesi.Location = new System.Drawing.Point(206, 73);
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPersonelListesi.Size = new System.Drawing.Size(162, 60);
            this.btnPersonelListesi.TabIndex = 28;
            this.btnPersonelListesi.Text = "   Personelleri\r\n   Listele";
            this.btnPersonelListesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelListesi.UseVisualStyleBackColor = false;
            this.btnPersonelListesi.Click += new System.EventHandler(this.btnPersonelListesi_Click);
            // 
            // btnSubeDegistir
            // 
            this.btnSubeDegistir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubeDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubeDegistir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubeDegistir.Image = global::WindowsFormsApplication1.Properties.Resources.travel_agency_32;
            this.btnSubeDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubeDegistir.Location = new System.Drawing.Point(25, 73);
            this.btnSubeDegistir.Name = "btnSubeDegistir";
            this.btnSubeDegistir.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSubeDegistir.Size = new System.Drawing.Size(175, 60);
            this.btnSubeDegistir.TabIndex = 27;
            this.btnSubeDegistir.Text = "Otopark Bilgisi\n   Değiştir";
            this.btnSubeDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubeDegistir.UseVisualStyleBackColor = false;
            this.btnSubeDegistir.Click += new System.EventHandler(this.btnOtoparkGuncelle_Click);
            // 
            // cmsKayitlar
            // 
            this.cmsKayitlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsmiKayitDetayi});
            this.cmsKayitlar.Name = "contextMenuStripPersoneller";
            this.cmsKayitlar.Size = new System.Drawing.Size(137, 26);
            // 
            // cmsmiKayitDetayi
            // 
            this.cmsmiKayitDetayi.Name = "cmsmiKayitDetayi";
            this.cmsmiKayitDetayi.Size = new System.Drawing.Size(136, 22);
            this.cmsmiKayitDetayi.Text = "Kayıt Detayı";
            this.cmsmiKayitDetayi.Click += new System.EventHandler(this.cmsmiKayitDetayi_Click);
            // 
            // gbIslemYap
            // 
            this.gbIslemYap.Controls.Add(this.tickOdemeTuru);
            this.gbIslemYap.Controls.Add(this.tickMusCepNo);
            this.gbIslemYap.Controls.Add(this.tickMusBilgi);
            this.gbIslemYap.Controls.Add(this.ticlkPlaka);
            this.gbIslemYap.Controls.Add(this.tickIslemTuru);
            this.gbIslemYap.Controls.Add(this.cbOdemeTuru);
            this.gbIslemYap.Controls.Add(this.lblOdemeTuru);
            this.gbIslemYap.Controls.Add(this.lblAracPlakasi);
            this.gbIslemYap.Controls.Add(this.tbAracPlakasi);
            this.gbIslemYap.Controls.Add(this.cb_islemTuru);
            this.gbIslemYap.Controls.Add(this.lbl_islemTuru);
            this.gbIslemYap.Controls.Add(this.lblBaslik);
            this.gbIslemYap.Controls.Add(this.btnTamam);
            this.gbIslemYap.Controls.Add(this.mtbMusCepNo);
            this.gbIslemYap.Controls.Add(this.lbl_telefon_no);
            this.gbIslemYap.Controls.Add(this.lbl_ad_soyad);
            this.gbIslemYap.Controls.Add(this.tb_musteriBilgi);
            this.gbIslemYap.Location = new System.Drawing.Point(165, 205);
            this.gbIslemYap.Name = "gbIslemYap";
            this.gbIslemYap.Size = new System.Drawing.Size(731, 325);
            this.gbIslemYap.TabIndex = 50;
            this.gbIslemYap.TabStop = false;
            this.gbIslemYap.Visible = false;
            this.gbIslemYap.Enter += new System.EventHandler(this.gbIslemYap_Enter);
            // 
            // tickMusCepNo
            // 
            this.tickMusCepNo.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.tickMusCepNo.Location = new System.Drawing.Point(554, 157);
            this.tickMusCepNo.Name = "tickMusCepNo";
            this.tickMusCepNo.Size = new System.Drawing.Size(33, 26);
            this.tickMusCepNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tickMusCepNo.TabIndex = 91;
            this.tickMusCepNo.TabStop = false;
            this.tickMusCepNo.Visible = false;
            // 
            // tickMusBilgi
            // 
            this.tickMusBilgi.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.tickMusBilgi.Location = new System.Drawing.Point(554, 189);
            this.tickMusBilgi.Name = "tickMusBilgi";
            this.tickMusBilgi.Size = new System.Drawing.Size(33, 26);
            this.tickMusBilgi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tickMusBilgi.TabIndex = 90;
            this.tickMusBilgi.TabStop = false;
            this.tickMusBilgi.Visible = false;
            // 
            // ticlkPlaka
            // 
            this.ticlkPlaka.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.ticlkPlaka.Location = new System.Drawing.Point(554, 125);
            this.ticlkPlaka.Name = "ticlkPlaka";
            this.ticlkPlaka.Size = new System.Drawing.Size(33, 26);
            this.ticlkPlaka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ticlkPlaka.TabIndex = 89;
            this.ticlkPlaka.TabStop = false;
            this.ticlkPlaka.Visible = false;
            // 
            // tickIslemTuru
            // 
            this.tickIslemTuru.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.tickIslemTuru.Location = new System.Drawing.Point(554, 93);
            this.tickIslemTuru.Name = "tickIslemTuru";
            this.tickIslemTuru.Size = new System.Drawing.Size(33, 26);
            this.tickIslemTuru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tickIslemTuru.TabIndex = 88;
            this.tickIslemTuru.TabStop = false;
            this.tickIslemTuru.Visible = false;
            // 
            // cbOdemeTuru
            // 
            this.cbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdemeTuru.FormattingEnabled = true;
            this.cbOdemeTuru.Items.AddRange(new object[] {
            "Seçiniz...",
            "Nakit",
            "Kredi Kartı"});
            this.cbOdemeTuru.Location = new System.Drawing.Point(309, 221);
            this.cbOdemeTuru.Name = "cbOdemeTuru";
            this.cbOdemeTuru.Size = new System.Drawing.Size(240, 26);
            this.cbOdemeTuru.TabIndex = 87;
            this.cbOdemeTuru.Visible = false;
            this.cbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cbOdemeTuru_SelectedIndexChanged);
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTuru.Location = new System.Drawing.Point(189, 223);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(112, 20);
            this.lblOdemeTuru.TabIndex = 86;
            this.lblOdemeTuru.Text = "Ödeme Türü:";
            this.lblOdemeTuru.Visible = false;
            // 
            // lblAracPlakasi
            // 
            this.lblAracPlakasi.AutoSize = true;
            this.lblAracPlakasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracPlakasi.Location = new System.Drawing.Point(191, 127);
            this.lblAracPlakasi.Name = "lblAracPlakasi";
            this.lblAracPlakasi.Size = new System.Drawing.Size(113, 20);
            this.lblAracPlakasi.TabIndex = 84;
            this.lblAracPlakasi.Text = "Araç Plakası:";
            // 
            // tbAracPlakasi
            // 
            this.tbAracPlakasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAracPlakasi.Location = new System.Drawing.Point(308, 125);
            this.tbAracPlakasi.MaxLength = 14;
            this.tbAracPlakasi.Name = "tbAracPlakasi";
            this.tbAracPlakasi.Size = new System.Drawing.Size(240, 26);
            this.tbAracPlakasi.TabIndex = 83;
            this.tbAracPlakasi.TextChanged += new System.EventHandler(this.tbAracPlakasi_TextChanged);
            // 
            // cb_islemTuru
            // 
            this.cb_islemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_islemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_islemTuru.FormattingEnabled = true;
            this.cb_islemTuru.Items.AddRange(new object[] {
            "Seçiniz...",
            "Giriş",
            "Çıkış"});
            this.cb_islemTuru.Location = new System.Drawing.Point(308, 93);
            this.cb_islemTuru.Name = "cb_islemTuru";
            this.cb_islemTuru.Size = new System.Drawing.Size(240, 26);
            this.cb_islemTuru.TabIndex = 78;
            this.cb_islemTuru.SelectedIndexChanged += new System.EventHandler(this.cb_islemTuru_SelectedIndexChanged);
            // 
            // lbl_islemTuru
            // 
            this.lbl_islemTuru.AutoSize = true;
            this.lbl_islemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_islemTuru.Location = new System.Drawing.Point(204, 95);
            this.lbl_islemTuru.Name = "lbl_islemTuru";
            this.lbl_islemTuru.Size = new System.Drawing.Size(98, 20);
            this.lbl_islemTuru.TabIndex = 77;
            this.lbl_islemTuru.Text = "İşlem Türü:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(335, 40);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(99, 25);
            this.lblBaslik.TabIndex = 76;
            this.lblBaslik.Text = "Kayıt Ekle";
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(166, 277);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(392, 35);
            this.btnTamam.TabIndex = 52;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // mtbMusCepNo
            // 
            this.mtbMusCepNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbMusCepNo.Location = new System.Drawing.Point(309, 157);
            this.mtbMusCepNo.Mask = "000-000-0000";
            this.mtbMusCepNo.Name = "mtbMusCepNo";
            this.mtbMusCepNo.Size = new System.Drawing.Size(240, 26);
            this.mtbMusCepNo.TabIndex = 51;
            this.mtbMusCepNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbMusCepNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbMusCepNo_MaskInputRejected);
            this.mtbMusCepNo.TextChanged += new System.EventHandler(this.mtbMusCepNo_TextChanged);
            // 
            // lbl_telefon_no
            // 
            this.lbl_telefon_no.AutoSize = true;
            this.lbl_telefon_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon_no.Location = new System.Drawing.Point(164, 160);
            this.lbl_telefon_no.Name = "lbl_telefon_no";
            this.lbl_telefon_no.Size = new System.Drawing.Size(137, 20);
            this.lbl_telefon_no.TabIndex = 49;
            this.lbl_telefon_no.Text = "Müşteri Cep No:";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad_soyad.Location = new System.Drawing.Point(176, 192);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(125, 20);
            this.lbl_ad_soyad.TabIndex = 47;
            this.lbl_ad_soyad.Text = "Müşteri Bilgisi:";
            // 
            // tb_musteriBilgi
            // 
            this.tb_musteriBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_musteriBilgi.Location = new System.Drawing.Point(308, 189);
            this.tb_musteriBilgi.Name = "tb_musteriBilgi";
            this.tb_musteriBilgi.Size = new System.Drawing.Size(240, 26);
            this.tb_musteriBilgi.TabIndex = 46;
            this.tb_musteriBilgi.TextChanged += new System.EventHandler(this.tb_musteriBilgi_TextChanged);
            // 
            // tickOdemeTuru
            // 
            this.tickOdemeTuru.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.tickOdemeTuru.Location = new System.Drawing.Point(555, 221);
            this.tickOdemeTuru.Name = "tickOdemeTuru";
            this.tickOdemeTuru.Size = new System.Drawing.Size(33, 26);
            this.tickOdemeTuru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tickOdemeTuru.TabIndex = 92;
            this.tickOdemeTuru.TabStop = false;
            this.tickOdemeTuru.Visible = false;
            // 
            // otoparkEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 607);
            this.Controls.Add(this.gbIslemYap);
            this.Controls.Add(this.Main_Grid);
            this.Controls.Add(this.lblFooterInfo);
            this.Controls.Add(this.linklabel_cikisYap);
            this.Controls.Add(this.gbAra);
            this.Controls.Add(this.btnRapolar);
            this.Controls.Add(this.btnFaturaListele);
            this.Controls.Add(this.btnKayitlariListele);
            this.Controls.Add(this.btn_islemYap);
            this.Controls.Add(this.btnPersonelListesi);
            this.Controls.Add(this.btnSubeDegistir);
            this.Controls.Add(this.lbl_HeaderINfo);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Name = "otoparkEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Ekranı";
            this.Load += new System.EventHandler(this.otoparkEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).EndInit();
            this.contextMenuStripPersoneller.ResumeLayout(false);
            this.gbAra.ResumeLayout(false);
            this.gbAra.PerformLayout();
            this.cmsKayitlar.ResumeLayout(false);
            this.gbIslemYap.ResumeLayout(false);
            this.gbIslemYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickMusCepNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickMusBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticlkPlaka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickIslemTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickOdemeTuru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPersonelListesi;
        private System.Windows.Forms.Button btnSubeDegistir;
        private System.Windows.Forms.DataGridView Main_Grid;
        private System.Windows.Forms.Label lbl_HeaderINfo;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPersoneller;
        private System.Windows.Forms.ToolStripMenuItem personelGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.Button btn_islemYap;
        private System.Windows.Forms.Button btnKayitlariListele;
        private System.Windows.Forms.Button btnRapolar;
        private System.Windows.Forms.Button btnFaturaListele;
        private System.Windows.Forms.GroupBox gbAra;
        private System.Windows.Forms.ComboBox cbRaporlar;
        private System.Windows.Forms.Label lblRapor;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.TextBox tb_ara;
        private System.Windows.Forms.LinkLabel linklabel_cikisYap;
        private System.Windows.Forms.Label lblFooterInfo;
        private System.Windows.Forms.ContextMenuStrip cmsKayitlar;
        private System.Windows.Forms.ToolStripMenuItem cmsmiKayitDetayi;
        private System.Windows.Forms.GroupBox gbIslemYap;
        private System.Windows.Forms.Label lblAracPlakasi;
        private System.Windows.Forms.TextBox tbAracPlakasi;
        private System.Windows.Forms.ComboBox cb_islemTuru;
        private System.Windows.Forms.Label lbl_islemTuru;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.MaskedTextBox mtbMusCepNo;
        private System.Windows.Forms.Label lbl_telefon_no;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.TextBox tb_musteriBilgi;
        private System.Windows.Forms.ComboBox cbOdemeTuru;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.PictureBox tickMusCepNo;
        private System.Windows.Forms.PictureBox tickMusBilgi;
        private System.Windows.Forms.PictureBox ticlkPlaka;
        private System.Windows.Forms.PictureBox tickIslemTuru;
        private System.Windows.Forms.PictureBox tickOdemeTuru;
    }
}