namespace WindowsFormsApplication1
{
    partial class otoparkEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otoparkEkle));
            this.lblSubeAdres = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.mtbKapasite = new System.Windows.Forms.MaskedTextBox();
            this.lblOtoparkKapasite = new System.Windows.Forms.Label();
            this.lbl_otoparkAdi = new System.Windows.Forms.Label();
            this.tbotoparkAdi = new System.Windows.Forms.TextBox();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.lblSubeSehir = new System.Windows.Forms.Label();
            this.cbIlceID = new System.Windows.Forms.ComboBox();
            this.lblSubeIlce = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.pb_tick_ilce = new System.Windows.Forms.PictureBox();
            this.pb_tick_Sehir = new System.Windows.Forms.PictureBox();
            this.pb_tick_Adres = new System.Windows.Forms.PictureBox();
            this.pb_tick_arackapasitesi = new System.Windows.Forms.PictureBox();
            this.pb_tick_otoparkAdi = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pb_tick_otoparkTuru = new System.Windows.Forms.PictureBox();
            this.lblParkturu = new System.Windows.Forms.Label();
            this.cbOtoparkTuru = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_ilce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Sehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Adres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_arackapasitesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_otoparkAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_otoparkTuru)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubeAdres
            // 
            this.lblSubeAdres.AutoSize = true;
            this.lblSubeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeAdres.Location = new System.Drawing.Point(121, 252);
            this.lblSubeAdres.Name = "lblSubeAdres";
            this.lblSubeAdres.Size = new System.Drawing.Size(61, 20);
            this.lblSubeAdres.TabIndex = 48;
            this.lblSubeAdres.Text = "Adres:";
            // 
            // tbAdres
            // 
            this.tbAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdres.Location = new System.Drawing.Point(194, 252);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdres.Size = new System.Drawing.Size(239, 78);
            this.tbAdres.TabIndex = 47;
            this.tbAdres.TextChanged += new System.EventHandler(this.tbSubeAdres_TextChanged);
            // 
            // mtbKapasite
            // 
            this.mtbKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbKapasite.Location = new System.Drawing.Point(194, 122);
            this.mtbKapasite.Mask = "0000";
            this.mtbKapasite.Name = "mtbKapasite";
            this.mtbKapasite.Size = new System.Drawing.Size(239, 26);
            this.mtbKapasite.TabIndex = 46;
            this.mtbKapasite.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbKapasite.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbSubeTel_MaskInputRejected);
            this.mtbKapasite.TextChanged += new System.EventHandler(this.mtbSubeTel_TextChanged);
            // 
            // lblOtoparkKapasite
            // 
            this.lblOtoparkKapasite.AutoSize = true;
            this.lblOtoparkKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtoparkKapasite.Location = new System.Drawing.Point(44, 125);
            this.lblOtoparkKapasite.Name = "lblOtoparkKapasite";
            this.lblOtoparkKapasite.Size = new System.Drawing.Size(144, 20);
            this.lblOtoparkKapasite.TabIndex = 45;
            this.lblOtoparkKapasite.Text = "Araç Kapasitesi: ";
            // 
            // lbl_otoparkAdi
            // 
            this.lbl_otoparkAdi.AutoSize = true;
            this.lbl_otoparkAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_otoparkAdi.Location = new System.Drawing.Point(73, 92);
            this.lbl_otoparkAdi.Name = "lbl_otoparkAdi";
            this.lbl_otoparkAdi.Size = new System.Drawing.Size(109, 20);
            this.lbl_otoparkAdi.TabIndex = 44;
            this.lbl_otoparkAdi.Text = "Otopark Adı:";
            // 
            // tbotoparkAdi
            // 
            this.tbotoparkAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbotoparkAdi.Location = new System.Drawing.Point(194, 90);
            this.tbotoparkAdi.Name = "tbotoparkAdi";
            this.tbotoparkAdi.Size = new System.Drawing.Size(239, 26);
            this.tbotoparkAdi.TabIndex = 43;
            this.tbotoparkAdi.TextChanged += new System.EventHandler(this.tbsubeAdi_TextChanged);
            // 
            // cbSehir
            // 
            this.cbSehir.DropDownHeight = 150;
            this.cbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.IntegralHeight = false;
            this.cbSehir.Location = new System.Drawing.Point(194, 187);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(239, 26);
            this.cbSehir.TabIndex = 64;
            this.cbSehir.SelectedIndexChanged += new System.EventHandler(this.cbSubeSehir_SelectedIndexChanged);
            // 
            // lblSubeSehir
            // 
            this.lblSubeSehir.AutoSize = true;
            this.lblSubeSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeSehir.Location = new System.Drawing.Point(126, 189);
            this.lblSubeSehir.Name = "lblSubeSehir";
            this.lblSubeSehir.Size = new System.Drawing.Size(56, 20);
            this.lblSubeSehir.TabIndex = 63;
            this.lblSubeSehir.Text = "Şehir:";
            // 
            // cbIlceID
            // 
            this.cbIlceID.DropDownHeight = 150;
            this.cbIlceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIlceID.FormattingEnabled = true;
            this.cbIlceID.IntegralHeight = false;
            this.cbIlceID.Location = new System.Drawing.Point(194, 220);
            this.cbIlceID.Name = "cbIlceID";
            this.cbIlceID.Size = new System.Drawing.Size(239, 26);
            this.cbIlceID.TabIndex = 67;
            // 
            // lblSubeIlce
            // 
            this.lblSubeIlce.AutoSize = true;
            this.lblSubeIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeIlce.Location = new System.Drawing.Point(134, 222);
            this.lblSubeIlce.Name = "lblSubeIlce";
            this.lblSubeIlce.Size = new System.Drawing.Size(48, 20);
            this.lblSubeIlce.TabIndex = 66;
            this.lblSubeIlce.Text = " İlçe:";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(83, 363);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(405, 33);
            this.btn_Ekle.TabIndex = 69;
            this.btn_Ekle.Text = "Otopark Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_subeEkle_Click);
            // 
            // pb_tick_ilce
            // 
            this.pb_tick_ilce.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_ilce.Location = new System.Drawing.Point(439, 221);
            this.pb_tick_ilce.Name = "pb_tick_ilce";
            this.pb_tick_ilce.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_ilce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_ilce.TabIndex = 68;
            this.pb_tick_ilce.TabStop = false;
            // 
            // pb_tick_Sehir
            // 
            this.pb_tick_Sehir.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_Sehir.Location = new System.Drawing.Point(439, 188);
            this.pb_tick_Sehir.Name = "pb_tick_Sehir";
            this.pb_tick_Sehir.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_Sehir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_Sehir.TabIndex = 65;
            this.pb_tick_Sehir.TabStop = false;
            // 
            // pb_tick_Adres
            // 
            this.pb_tick_Adres.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_Adres.Location = new System.Drawing.Point(439, 252);
            this.pb_tick_Adres.Name = "pb_tick_Adres";
            this.pb_tick_Adres.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_Adres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_Adres.TabIndex = 53;
            this.pb_tick_Adres.TabStop = false;
            this.pb_tick_Adres.Visible = false;
            // 
            // pb_tick_arackapasitesi
            // 
            this.pb_tick_arackapasitesi.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_arackapasitesi.Location = new System.Drawing.Point(439, 122);
            this.pb_tick_arackapasitesi.Name = "pb_tick_arackapasitesi";
            this.pb_tick_arackapasitesi.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_arackapasitesi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_arackapasitesi.TabIndex = 52;
            this.pb_tick_arackapasitesi.TabStop = false;
            this.pb_tick_arackapasitesi.Visible = false;
            // 
            // pb_tick_otoparkAdi
            // 
            this.pb_tick_otoparkAdi.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_otoparkAdi.Location = new System.Drawing.Point(439, 90);
            this.pb_tick_otoparkAdi.Name = "pb_tick_otoparkAdi";
            this.pb_tick_otoparkAdi.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_otoparkAdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_otoparkAdi.TabIndex = 50;
            this.pb_tick_otoparkAdi.TabStop = false;
            this.pb_tick_otoparkAdi.Visible = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(201, 32);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(232, 31);
            this.lblBaslik.TabIndex = 70;
            this.lblBaslik.Text = "Yeni Otopark Ekle";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // pb_tick_otoparkTuru
            // 
            this.pb_tick_otoparkTuru.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_otoparkTuru.Location = new System.Drawing.Point(439, 154);
            this.pb_tick_otoparkTuru.Name = "pb_tick_otoparkTuru";
            this.pb_tick_otoparkTuru.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_otoparkTuru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_otoparkTuru.TabIndex = 72;
            this.pb_tick_otoparkTuru.TabStop = false;
            this.pb_tick_otoparkTuru.Visible = false;
            // 
            // lblParkturu
            // 
            this.lblParkturu.AutoSize = true;
            this.lblParkturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParkturu.Location = new System.Drawing.Point(63, 154);
            this.lblParkturu.Name = "lblParkturu";
            this.lblParkturu.Size = new System.Drawing.Size(119, 20);
            this.lblParkturu.TabIndex = 73;
            this.lblParkturu.Text = "Otopark Türü:";
            // 
            // cbOtoparkTuru
            // 
            this.cbOtoparkTuru.DropDownHeight = 150;
            this.cbOtoparkTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtoparkTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOtoparkTuru.FormattingEnabled = true;
            this.cbOtoparkTuru.IntegralHeight = false;
            this.cbOtoparkTuru.Items.AddRange(new object[] {
            "Seçiniz...",
            "Açık Otopark",
            "Kapalı Otopark"});
            this.cbOtoparkTuru.Location = new System.Drawing.Point(194, 154);
            this.cbOtoparkTuru.Name = "cbOtoparkTuru";
            this.cbOtoparkTuru.Size = new System.Drawing.Size(239, 26);
            this.cbOtoparkTuru.TabIndex = 74;
            this.cbOtoparkTuru.SelectedIndexChanged += new System.EventHandler(this.cbOtoparkTuru_SelectedIndexChanged);
            // 
            // otoparkEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 430);
            this.Controls.Add(this.cbOtoparkTuru);
            this.Controls.Add(this.lblParkturu);
            this.Controls.Add(this.pb_tick_otoparkTuru);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.pb_tick_ilce);
            this.Controls.Add(this.cbIlceID);
            this.Controls.Add(this.lblSubeIlce);
            this.Controls.Add(this.pb_tick_Sehir);
            this.Controls.Add(this.cbSehir);
            this.Controls.Add(this.lblSubeSehir);
            this.Controls.Add(this.pb_tick_Adres);
            this.Controls.Add(this.pb_tick_arackapasitesi);
            this.Controls.Add(this.pb_tick_otoparkAdi);
            this.Controls.Add(this.lblSubeAdres);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.mtbKapasite);
            this.Controls.Add(this.lblOtoparkKapasite);
            this.Controls.Add(this.lbl_otoparkAdi);
            this.Controls.Add(this.tbotoparkAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "otoparkEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Ekle";
            this.Load += new System.EventHandler(this.otopark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_ilce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Sehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_Adres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_arackapasitesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_otoparkAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_otoparkTuru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_tick_Adres;
        private System.Windows.Forms.PictureBox pb_tick_arackapasitesi;
        private System.Windows.Forms.PictureBox pb_tick_otoparkAdi;
        private System.Windows.Forms.Label lblSubeAdres;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.MaskedTextBox mtbKapasite;
        private System.Windows.Forms.Label lblOtoparkKapasite;
        private System.Windows.Forms.Label lbl_otoparkAdi;
        private System.Windows.Forms.TextBox tbotoparkAdi;
        private System.Windows.Forms.PictureBox pb_tick_Sehir;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.Label lblSubeSehir;
        private System.Windows.Forms.PictureBox pb_tick_ilce;
        private System.Windows.Forms.ComboBox cbIlceID;
        private System.Windows.Forms.Label lblSubeIlce;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.PictureBox pb_tick_otoparkTuru;
        private System.Windows.Forms.Label lblParkturu;
        private System.Windows.Forms.ComboBox cbOtoparkTuru;
    }
}