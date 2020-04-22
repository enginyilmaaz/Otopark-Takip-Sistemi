namespace WindowsFormsApplication1
{
    partial class kayitDetay
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lbl_otopark = new System.Windows.Forms.Label();
            this.lbl_faturaDurumu = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.lbl_faturaTutari = new System.Windows.Forms.Label();
            this.lbl_islemZamani = new System.Windows.Forms.Label();
            this.tb_islemZamani = new System.Windows.Forms.TextBox();
            this.lbl_islemNo = new System.Windows.Forms.Label();
            this.tbIslemNO = new System.Windows.Forms.TextBox();
            this.tbOtopark = new System.Windows.Forms.TextBox();
            this.tbMusAdSoyad = new System.Windows.Forms.TextBox();
            this.lblMusCepNo = new System.Windows.Forms.Label();
            this.mtbMusCepNo = new System.Windows.Forms.MaskedTextBox();
            this.lblaracPlaka = new System.Windows.Forms.Label();
            this.tbAracPlaka = new System.Windows.Forms.TextBox();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.tbFaturaTutari = new System.Windows.Forms.TextBox();
            this.tbFaturaDurumu = new System.Windows.Forms.TextBox();
            this.tbislemYapanPersonelAd = new System.Windows.Forms.TextBox();
            this.lblPErsonel = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.tbKonum = new System.Windows.Forms.TextBox();
            this.tbKayitTuru = new System.Windows.Forms.TextBox();
            this.lblKayitTuru = new System.Windows.Forms.Label();
            this.tbPrsKimlikNO = new System.Windows.Forms.TextBox();
            this.lbl_prsKimlikNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(371, 35);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(160, 31);
            this.lblBaslik.TabIndex = 72;
            this.lblBaslik.Text = "Kayıt Detayı";
            // 
            // lbl_otopark
            // 
            this.lbl_otopark.AutoSize = true;
            this.lbl_otopark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_otopark.Location = new System.Drawing.Point(66, 137);
            this.lbl_otopark.Name = "lbl_otopark";
            this.lbl_otopark.Size = new System.Drawing.Size(78, 20);
            this.lbl_otopark.TabIndex = 104;
            this.lbl_otopark.Text = "Otopark:";
            // 
            // lbl_faturaDurumu
            // 
            this.lbl_faturaDurumu.AutoSize = true;
            this.lbl_faturaDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_faturaDurumu.Location = new System.Drawing.Point(479, 268);
            this.lbl_faturaDurumu.Name = "lbl_faturaDurumu";
            this.lbl_faturaDurumu.Size = new System.Drawing.Size(135, 20);
            this.lbl_faturaDurumu.TabIndex = 86;
            this.lbl_faturaDurumu.Text = "Fatura Durumu:";
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(295, 339);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(369, 35);
            this.btnTamam.TabIndex = 80;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // lbl_faturaTutari
            // 
            this.lbl_faturaTutari.AutoSize = true;
            this.lbl_faturaTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_faturaTutari.Location = new System.Drawing.Point(493, 234);
            this.lbl_faturaTutari.Name = "lbl_faturaTutari";
            this.lbl_faturaTutari.Size = new System.Drawing.Size(118, 20);
            this.lbl_faturaTutari.TabIndex = 77;
            this.lbl_faturaTutari.Text = "Fatura Tutarı:";
            // 
            // lbl_islemZamani
            // 
            this.lbl_islemZamani.AutoSize = true;
            this.lbl_islemZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_islemZamani.Location = new System.Drawing.Point(20, 233);
            this.lbl_islemZamani.Name = "lbl_islemZamani";
            this.lbl_islemZamani.Size = new System.Drawing.Size(121, 20);
            this.lbl_islemZamani.TabIndex = 75;
            this.lbl_islemZamani.Text = "İşlem Zamanı:";
            // 
            // tb_islemZamani
            // 
            this.tb_islemZamani.Enabled = false;
            this.tb_islemZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_islemZamani.Location = new System.Drawing.Point(150, 230);
            this.tb_islemZamani.Name = "tb_islemZamani";
            this.tb_islemZamani.ReadOnly = true;
            this.tb_islemZamani.Size = new System.Drawing.Size(239, 26);
            this.tb_islemZamani.TabIndex = 74;
            // 
            // lbl_islemNo
            // 
            this.lbl_islemNo.AutoSize = true;
            this.lbl_islemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_islemNo.Location = new System.Drawing.Point(60, 105);
            this.lbl_islemNo.Name = "lbl_islemNo";
            this.lbl_islemNo.Size = new System.Drawing.Size(84, 20);
            this.lbl_islemNo.TabIndex = 73;
            this.lbl_islemNo.Text = "İşlem No:";
            // 
            // tbIslemNO
            // 
            this.tbIslemNO.Enabled = false;
            this.tbIslemNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbIslemNO.Location = new System.Drawing.Point(150, 102);
            this.tbIslemNO.Name = "tbIslemNO";
            this.tbIslemNO.ReadOnly = true;
            this.tbIslemNO.Size = new System.Drawing.Size(239, 26);
            this.tbIslemNO.TabIndex = 110;
            // 
            // tbOtopark
            // 
            this.tbOtopark.Enabled = false;
            this.tbOtopark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbOtopark.Location = new System.Drawing.Point(150, 134);
            this.tbOtopark.Name = "tbOtopark";
            this.tbOtopark.ReadOnly = true;
            this.tbOtopark.Size = new System.Drawing.Size(239, 26);
            this.tbOtopark.TabIndex = 111;
            // 
            // tbMusAdSoyad
            // 
            this.tbMusAdSoyad.Enabled = false;
            this.tbMusAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMusAdSoyad.Location = new System.Drawing.Point(620, 102);
            this.tbMusAdSoyad.Name = "tbMusAdSoyad";
            this.tbMusAdSoyad.ReadOnly = true;
            this.tbMusAdSoyad.Size = new System.Drawing.Size(239, 26);
            this.tbMusAdSoyad.TabIndex = 120;
            // 
            // lblMusCepNo
            // 
            this.lblMusCepNo.AutoSize = true;
            this.lblMusCepNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusCepNo.Location = new System.Drawing.Point(477, 139);
            this.lblMusCepNo.Name = "lblMusCepNo";
            this.lblMusCepNo.Size = new System.Drawing.Size(137, 20);
            this.lblMusCepNo.TabIndex = 119;
            this.lblMusCepNo.Text = "Müşteri Cep No:";
            // 
            // mtbMusCepNo
            // 
            this.mtbMusCepNo.Enabled = false;
            this.mtbMusCepNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbMusCepNo.Location = new System.Drawing.Point(620, 136);
            this.mtbMusCepNo.Mask = "000-000-0000";
            this.mtbMusCepNo.Name = "mtbMusCepNo";
            this.mtbMusCepNo.ReadOnly = true;
            this.mtbMusCepNo.Size = new System.Drawing.Size(239, 26);
            this.mtbMusCepNo.TabIndex = 116;
            this.mtbMusCepNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblaracPlaka
            // 
            this.lblaracPlaka.AutoSize = true;
            this.lblaracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaracPlaka.Location = new System.Drawing.Point(28, 265);
            this.lblaracPlaka.Name = "lblaracPlaka";
            this.lblaracPlaka.Size = new System.Drawing.Size(113, 20);
            this.lblaracPlaka.TabIndex = 114;
            this.lblaracPlaka.Text = "Araç Plakası:";
            // 
            // tbAracPlaka
            // 
            this.tbAracPlaka.Enabled = false;
            this.tbAracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAracPlaka.Location = new System.Drawing.Point(150, 262);
            this.tbAracPlaka.Name = "tbAracPlaka";
            this.tbAracPlaka.ReadOnly = true;
            this.tbAracPlaka.Size = new System.Drawing.Size(239, 26);
            this.tbAracPlaka.TabIndex = 113;
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAdi.Location = new System.Drawing.Point(486, 108);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(125, 20);
            this.lblMusteriAdi.TabIndex = 112;
            this.lblMusteriAdi.Text = "Müşteri Bilgisi:";
            // 
            // tbFaturaTutari
            // 
            this.tbFaturaTutari.Enabled = false;
            this.tbFaturaTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFaturaTutari.Location = new System.Drawing.Point(620, 230);
            this.tbFaturaTutari.Name = "tbFaturaTutari";
            this.tbFaturaTutari.ReadOnly = true;
            this.tbFaturaTutari.Size = new System.Drawing.Size(239, 26);
            this.tbFaturaTutari.TabIndex = 122;
            // 
            // tbFaturaDurumu
            // 
            this.tbFaturaDurumu.Enabled = false;
            this.tbFaturaDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFaturaDurumu.Location = new System.Drawing.Point(620, 263);
            this.tbFaturaDurumu.Name = "tbFaturaDurumu";
            this.tbFaturaDurumu.ReadOnly = true;
            this.tbFaturaDurumu.Size = new System.Drawing.Size(239, 26);
            this.tbFaturaDurumu.TabIndex = 123;
            // 
            // tbislemYapanPersonelAd
            // 
            this.tbislemYapanPersonelAd.Enabled = false;
            this.tbislemYapanPersonelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbislemYapanPersonelAd.Location = new System.Drawing.Point(620, 168);
            this.tbislemYapanPersonelAd.Name = "tbislemYapanPersonelAd";
            this.tbislemYapanPersonelAd.ReadOnly = true;
            this.tbislemYapanPersonelAd.Size = new System.Drawing.Size(239, 26);
            this.tbislemYapanPersonelAd.TabIndex = 128;
            // 
            // lblPErsonel
            // 
            this.lblPErsonel.AutoSize = true;
            this.lblPErsonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPErsonel.Location = new System.Drawing.Point(421, 171);
            this.lblPErsonel.Name = "lblPErsonel";
            this.lblPErsonel.Size = new System.Drawing.Size(193, 20);
            this.lblPErsonel.TabIndex = 127;
            this.lblPErsonel.Text = "İşlemi Yapan Personel:";
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonum.Location = new System.Drawing.Point(72, 169);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(69, 20);
            this.lblKonum.TabIndex = 126;
            this.lblKonum.Text = "Konum:";
            // 
            // tbKonum
            // 
            this.tbKonum.Enabled = false;
            this.tbKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKonum.Location = new System.Drawing.Point(150, 166);
            this.tbKonum.Name = "tbKonum";
            this.tbKonum.ReadOnly = true;
            this.tbKonum.Size = new System.Drawing.Size(239, 26);
            this.tbKonum.TabIndex = 125;
            // 
            // tbKayitTuru
            // 
            this.tbKayitTuru.Enabled = false;
            this.tbKayitTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKayitTuru.Location = new System.Drawing.Point(150, 198);
            this.tbKayitTuru.Name = "tbKayitTuru";
            this.tbKayitTuru.ReadOnly = true;
            this.tbKayitTuru.Size = new System.Drawing.Size(239, 26);
            this.tbKayitTuru.TabIndex = 130;
            // 
            // lblKayitTuru
            // 
            this.lblKayitTuru.AutoSize = true;
            this.lblKayitTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitTuru.Location = new System.Drawing.Point(43, 201);
            this.lblKayitTuru.Name = "lblKayitTuru";
            this.lblKayitTuru.Size = new System.Drawing.Size(98, 20);
            this.lblKayitTuru.TabIndex = 129;
            this.lblKayitTuru.Text = "İşlem Türü:";
            // 
            // tbPrsKimlikNO
            // 
            this.tbPrsKimlikNO.Enabled = false;
            this.tbPrsKimlikNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPrsKimlikNO.Location = new System.Drawing.Point(620, 198);
            this.tbPrsKimlikNO.Name = "tbPrsKimlikNO";
            this.tbPrsKimlikNO.ReadOnly = true;
            this.tbPrsKimlikNO.Size = new System.Drawing.Size(239, 26);
            this.tbPrsKimlikNO.TabIndex = 132;
            // 
            // lbl_prsKimlikNo
            // 
            this.lbl_prsKimlikNo.AutoSize = true;
            this.lbl_prsKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_prsKimlikNo.Location = new System.Drawing.Point(449, 201);
            this.lbl_prsKimlikNo.Name = "lbl_prsKimlikNo";
            this.lbl_prsKimlikNo.Size = new System.Drawing.Size(162, 20);
            this.lbl_prsKimlikNo.TabIndex = 131;
            this.lbl_prsKimlikNo.Text = "Personel Kimlik No:";
            // 
            // kayitDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 402);
            this.Controls.Add(this.tbPrsKimlikNO);
            this.Controls.Add(this.lbl_prsKimlikNo);
            this.Controls.Add(this.tbKayitTuru);
            this.Controls.Add(this.lblKayitTuru);
            this.Controls.Add(this.tbislemYapanPersonelAd);
            this.Controls.Add(this.lblPErsonel);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.tbKonum);
            this.Controls.Add(this.tbFaturaDurumu);
            this.Controls.Add(this.tbFaturaTutari);
            this.Controls.Add(this.tbMusAdSoyad);
            this.Controls.Add(this.lblMusCepNo);
            this.Controls.Add(this.mtbMusCepNo);
            this.Controls.Add(this.lblaracPlaka);
            this.Controls.Add(this.tbAracPlaka);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.tbOtopark);
            this.Controls.Add(this.tbIslemNO);
            this.Controls.Add(this.lbl_otopark);
            this.Controls.Add(this.lbl_faturaDurumu);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.lbl_faturaTutari);
            this.Controls.Add(this.lbl_islemZamani);
            this.Controls.Add(this.tb_islemZamani);
            this.Controls.Add(this.lbl_islemNo);
            this.Controls.Add(this.lblBaslik);
            this.Name = "kayitDetay";
            this.Text = "Kayıt Türü:";
            this.Load += new System.EventHandler(this.kayitDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lbl_otopark;
        private System.Windows.Forms.Label lbl_faturaDurumu;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label lbl_faturaTutari;
        private System.Windows.Forms.Label lbl_islemZamani;
        private System.Windows.Forms.TextBox tb_islemZamani;
        private System.Windows.Forms.Label lbl_islemNo;
        private System.Windows.Forms.TextBox tbIslemNO;
        private System.Windows.Forms.TextBox tbOtopark;
        private System.Windows.Forms.TextBox tbMusAdSoyad;
        private System.Windows.Forms.Label lblMusCepNo;
        private System.Windows.Forms.MaskedTextBox mtbMusCepNo;
        private System.Windows.Forms.Label lblaracPlaka;
        private System.Windows.Forms.TextBox tbAracPlaka;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.TextBox tbFaturaTutari;
        private System.Windows.Forms.TextBox tbFaturaDurumu;
        private System.Windows.Forms.TextBox tbislemYapanPersonelAd;
        private System.Windows.Forms.Label lblPErsonel;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.TextBox tbKonum;
        private System.Windows.Forms.TextBox tbKayitTuru;
        private System.Windows.Forms.Label lblKayitTuru;
        private System.Windows.Forms.TextBox tbPrsKimlikNO;
        private System.Windows.Forms.Label lbl_prsKimlikNo;
    }
}