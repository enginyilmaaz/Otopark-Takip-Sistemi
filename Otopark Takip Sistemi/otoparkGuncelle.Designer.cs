namespace WindowsFormsApplication1
{
    partial class otoparkGuncelle
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.lbllce = new System.Windows.Forms.Label();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.mtbParkNo = new System.Windows.Forms.MaskedTextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.mtbKapasite = new System.Windows.Forms.MaskedTextBox();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.lbl_parkAdi = new System.Windows.Forms.Label();
            this.tbotopakAdi = new System.Windows.Forms.TextBox();
            this.lbl_parkNo = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.cbKapasiteSecim = new System.Windows.Forms.ComboBox();
            this.mtbSuankiKapasite = new System.Windows.Forms.MaskedTextBox();
            this.lblSuankiKapasite = new System.Windows.Forms.Label();
            this.pbDegistirLinki = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_tick_Ilce = new System.Windows.Forms.PictureBox();
            this.pb_tick_Sehir = new System.Windows.Forms.PictureBox();
            this.pb_tick_Adres = new System.Windows.Forms.PictureBox();
            this.pb_tick_kapasite = new System.Windows.Forms.PictureBox();
            this.pb_tick_parkNo = new System.Windows.Forms.PictureBox();
            this.pb_tick_otoparkAdi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDegistirLinki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Ilce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Sehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Adres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_kapasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_parkNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_otoparkAdi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(98, 394);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(405, 33);
            this.btn_Ekle.TabIndex = 91;
            this.btn_Ekle.Text = "Güncelle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_subeEkle_Click);
            // 
            // cbIlce
            // 
            this.cbIlce.DropDownHeight = 150;
            this.cbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.IntegralHeight = false;
            this.cbIlce.Location = new System.Drawing.Point(196, 261);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(239, 26);
            this.cbIlce.TabIndex = 89;
            this.cbIlce.SelectedIndexChanged += new System.EventHandler(this.cbSubeIlce_SelectedIndexChanged);
            // 
            // lbllce
            // 
            this.lbllce.AutoSize = true;
            this.lbllce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllce.Location = new System.Drawing.Point(141, 263);
            this.lbllce.Name = "lbllce";
            this.lbllce.Size = new System.Drawing.Size(43, 20);
            this.lbllce.TabIndex = 88;
            this.lbllce.Text = "İlçe:";
            // 
            // cbSehir
            // 
            this.cbSehir.DropDownHeight = 150;
            this.cbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.IntegralHeight = false;
            this.cbSehir.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cbSehir.Location = new System.Drawing.Point(196, 229);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(239, 26);
            this.cbSehir.TabIndex = 86;
            this.cbSehir.SelectedIndexChanged += new System.EventHandler(this.cbSubeSehir_SelectedIndexChanged);
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.Location = new System.Drawing.Point(128, 231);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(56, 20);
            this.lblSehir.TabIndex = 85;
            this.lblSehir.Text = "Şehir:";
            // 
            // mtbParkNo
            // 
            this.mtbParkNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbParkNo.Location = new System.Drawing.Point(196, 104);
            this.mtbParkNo.Mask = "00000";
            this.mtbParkNo.Name = "mtbParkNo";
            this.mtbParkNo.ReadOnly = true;
            this.mtbParkNo.Size = new System.Drawing.Size(239, 24);
            this.mtbParkNo.TabIndex = 77;
            this.mtbParkNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbParkNo.ValidatingType = typeof(int);
            this.mtbParkNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbParkNo_MaskInputRejected);
            this.mtbParkNo.TextChanged += new System.EventHandler(this.mtbSubeNo_TextChanged);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(123, 293);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(61, 20);
            this.lblAdres.TabIndex = 76;
            this.lblAdres.Text = "Adres:";
            // 
            // tbAdres
            // 
            this.tbAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdres.Location = new System.Drawing.Point(196, 293);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdres.Size = new System.Drawing.Size(239, 78);
            this.tbAdres.TabIndex = 75;
            this.tbAdres.TextChanged += new System.EventHandler(this.tbSubeAdres_TextChanged);
            // 
            // mtbKapasite
            // 
            this.mtbKapasite.Enabled = false;
            this.mtbKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbKapasite.Location = new System.Drawing.Point(321, 196);
            this.mtbKapasite.Mask = "0000";
            this.mtbKapasite.Name = "mtbKapasite";
            this.mtbKapasite.Size = new System.Drawing.Size(114, 26);
            this.mtbKapasite.TabIndex = 74;
            this.mtbKapasite.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbKapasite.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbKapasite_MaskInputRejected);
            this.mtbKapasite.TextChanged += new System.EventHandler(this.mtbSubeTel_TextChanged);
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapasite.Location = new System.Drawing.Point(59, 199);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(125, 20);
            this.lblKapasite.TabIndex = 73;
            this.lblKapasite.Text = "Yeni Kapasite:";
            // 
            // lbl_parkAdi
            // 
            this.lbl_parkAdi.AutoSize = true;
            this.lbl_parkAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_parkAdi.Location = new System.Drawing.Point(75, 143);
            this.lbl_parkAdi.Name = "lbl_parkAdi";
            this.lbl_parkAdi.Size = new System.Drawing.Size(109, 20);
            this.lbl_parkAdi.TabIndex = 72;
            this.lbl_parkAdi.Text = "Otopark Adı:";
            // 
            // tbotopakAdi
            // 
            this.tbotopakAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbotopakAdi.Location = new System.Drawing.Point(196, 134);
            this.tbotopakAdi.Name = "tbotopakAdi";
            this.tbotopakAdi.Size = new System.Drawing.Size(239, 26);
            this.tbotopakAdi.TabIndex = 71;
            this.tbotopakAdi.TextChanged += new System.EventHandler(this.tbsubeAdi_TextChanged);
            // 
            // lbl_parkNo
            // 
            this.lbl_parkNo.AutoSize = true;
            this.lbl_parkNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_parkNo.Location = new System.Drawing.Point(107, 106);
            this.lbl_parkNo.Name = "lbl_parkNo";
            this.lbl_parkNo.Size = new System.Drawing.Size(77, 20);
            this.lbl_parkNo.TabIndex = 70;
            this.lbl_parkNo.Text = "Park No:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(201, 45);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(225, 31);
            this.lblBaslik.TabIndex = 92;
            this.lblBaslik.Text = "Otopark Güncelle";
            // 
            // cbKapasiteSecim
            // 
            this.cbKapasiteSecim.DropDownHeight = 150;
            this.cbKapasiteSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKapasiteSecim.Enabled = false;
            this.cbKapasiteSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKapasiteSecim.FormattingEnabled = true;
            this.cbKapasiteSecim.IntegralHeight = false;
            this.cbKapasiteSecim.Items.AddRange(new object[] {
            "Seçiniz...",
            "Arttır",
            "Azalt"});
            this.cbKapasiteSecim.Location = new System.Drawing.Point(196, 196);
            this.cbKapasiteSecim.Name = "cbKapasiteSecim";
            this.cbKapasiteSecim.Size = new System.Drawing.Size(119, 26);
            this.cbKapasiteSecim.TabIndex = 93;
            // 
            // mtbSuankiKapasite
            // 
            this.mtbSuankiKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbSuankiKapasite.Location = new System.Drawing.Point(196, 166);
            this.mtbSuankiKapasite.Mask = "00000";
            this.mtbSuankiKapasite.Name = "mtbSuankiKapasite";
            this.mtbSuankiKapasite.ReadOnly = true;
            this.mtbSuankiKapasite.Size = new System.Drawing.Size(200, 24);
            this.mtbSuankiKapasite.TabIndex = 95;
            this.mtbSuankiKapasite.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbSuankiKapasite.ValidatingType = typeof(int);
            // 
            // lblSuankiKapasite
            // 
            this.lblSuankiKapasite.AutoSize = true;
            this.lblSuankiKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuankiKapasite.Location = new System.Drawing.Point(38, 168);
            this.lblSuankiKapasite.Name = "lblSuankiKapasite";
            this.lblSuankiKapasite.Size = new System.Drawing.Size(146, 20);
            this.lblSuankiKapasite.TabIndex = 94;
            this.lblSuankiKapasite.Text = "Güncel Kapasite:";
            // 
            // pbDegistirLinki
            // 
            this.pbDegistirLinki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDegistirLinki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDegistirLinki.Image = global::WindowsFormsApplication1.Properties.Resources.quantity_01_512;
            this.pbDegistirLinki.Location = new System.Drawing.Point(402, 166);
            this.pbDegistirLinki.Name = "pbDegistirLinki";
            this.pbDegistirLinki.Size = new System.Drawing.Size(33, 24);
            this.pbDegistirLinki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDegistirLinki.TabIndex = 97;
            this.pbDegistirLinki.TabStop = false;
            this.pbDegistirLinki.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pictureBox1.Location = new System.Drawing.Point(441, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pb_tick_Ilce
            // 
            this.pb_tick_Ilce.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_Ilce.Location = new System.Drawing.Point(441, 262);
            this.pb_tick_Ilce.Name = "pb_tick_Ilce";
            this.pb_tick_Ilce.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_Ilce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_Ilce.TabIndex = 90;
            this.pb_tick_Ilce.TabStop = false;
            // 
            // pb_tick_Sehir
            // 
            this.pb_tick_Sehir.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_Sehir.Location = new System.Drawing.Point(441, 230);
            this.pb_tick_Sehir.Name = "pb_tick_Sehir";
            this.pb_tick_Sehir.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_Sehir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_Sehir.TabIndex = 87;
            this.pb_tick_Sehir.TabStop = false;
            // 
            // pb_tick_Adres
            // 
            this.pb_tick_Adres.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_Adres.Location = new System.Drawing.Point(441, 293);
            this.pb_tick_Adres.Name = "pb_tick_Adres";
            this.pb_tick_Adres.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_Adres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_Adres.TabIndex = 81;
            this.pb_tick_Adres.TabStop = false;
            this.pb_tick_Adres.Visible = false;
            // 
            // pb_tick_kapasite
            // 
            this.pb_tick_kapasite.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_kapasite.Location = new System.Drawing.Point(441, 197);
            this.pb_tick_kapasite.Name = "pb_tick_kapasite";
            this.pb_tick_kapasite.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_kapasite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_kapasite.TabIndex = 80;
            this.pb_tick_kapasite.TabStop = false;
            // 
            // pb_tick_parkNo
            // 
            this.pb_tick_parkNo.Enabled = false;
            this.pb_tick_parkNo.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_parkNo.Location = new System.Drawing.Point(441, 106);
            this.pb_tick_parkNo.Name = "pb_tick_parkNo";
            this.pb_tick_parkNo.Size = new System.Drawing.Size(33, 24);
            this.pb_tick_parkNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_parkNo.TabIndex = 79;
            this.pb_tick_parkNo.TabStop = false;
            // 
            // pb_tick_otoparkAdi
            // 
            this.pb_tick_otoparkAdi.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_otoparkAdi.Location = new System.Drawing.Point(441, 134);
            this.pb_tick_otoparkAdi.Name = "pb_tick_otoparkAdi";
            this.pb_tick_otoparkAdi.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_otoparkAdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_otoparkAdi.TabIndex = 78;
            this.pb_tick_otoparkAdi.TabStop = false;
            this.pb_tick_otoparkAdi.Visible = false;
            // 
            // otoparkGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 480);
            this.Controls.Add(this.pbDegistirLinki);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtbSuankiKapasite);
            this.Controls.Add(this.lblSuankiKapasite);
            this.Controls.Add(this.cbKapasiteSecim);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.pb_tick_Ilce);
            this.Controls.Add(this.cbIlce);
            this.Controls.Add(this.lbllce);
            this.Controls.Add(this.pb_tick_Sehir);
            this.Controls.Add(this.cbSehir);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.pb_tick_Adres);
            this.Controls.Add(this.pb_tick_kapasite);
            this.Controls.Add(this.pb_tick_parkNo);
            this.Controls.Add(this.pb_tick_otoparkAdi);
            this.Controls.Add(this.mtbParkNo);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.mtbKapasite);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.lbl_parkAdi);
            this.Controls.Add(this.tbotopakAdi);
            this.Controls.Add(this.lbl_parkNo);
            this.Name = "otoparkGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Güncelle";
            this.Load += new System.EventHandler(this.subeGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDegistirLinki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Ilce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Sehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Adres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_kapasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_parkNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_otoparkAdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.PictureBox pb_tick_Ilce;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.Label lbllce;
        private System.Windows.Forms.PictureBox pb_tick_Sehir;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.PictureBox pb_tick_Adres;
        private System.Windows.Forms.PictureBox pb_tick_kapasite;
        private System.Windows.Forms.PictureBox pb_tick_parkNo;
        private System.Windows.Forms.PictureBox pb_tick_otoparkAdi;
        private System.Windows.Forms.MaskedTextBox mtbParkNo;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.MaskedTextBox mtbKapasite;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.Label lbl_parkAdi;
        private System.Windows.Forms.TextBox tbotopakAdi;
        private System.Windows.Forms.Label lbl_parkNo;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.ComboBox cbKapasiteSecim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtbSuankiKapasite;
        private System.Windows.Forms.Label lblSuankiKapasite;
        private System.Windows.Forms.PictureBox pbDegistirLinki;
    }
}