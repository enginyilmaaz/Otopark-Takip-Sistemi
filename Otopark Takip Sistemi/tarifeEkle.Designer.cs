namespace WindowsFormsApplication1
{
    partial class fiyatEkle
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
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbl_telefon_no = new System.Windows.Forms.Label();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.tbGunlukUcret = new System.Windows.Forms.TextBox();
            this.lbl_tc_no = new System.Windows.Forms.Label();
            this.lblGunlukUcret = new System.Windows.Forms.Label();
            this.lblSonrakiSaatUcreti = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ilksaatUcreti = new System.Windows.Forms.Label();
            this.tbilkSaatUcreti = new System.Windows.Forms.TextBox();
            this.cbOtopark = new System.Windows.Forms.ComboBox();
            this.tbSonrakiSaatBasiUcret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(-91, 102);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(77, 20);
            this.lbl_cinsiyet.TabIndex = 85;
            this.lbl_cinsiyet.Text = "Cinsiyet:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(50, 269);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(448, 35);
            this.btnEkle.TabIndex = 81;
            this.btnEkle.Text = "Ücret Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btn_yetkili_ekle_Click);
            // 
            // lbl_telefon_no
            // 
            this.lbl_telefon_no.AutoSize = true;
            this.lbl_telefon_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon_no.Location = new System.Drawing.Point(-115, 182);
            this.lbl_telefon_no.Name = "lbl_telefon_no";
            this.lbl_telefon_no.Size = new System.Drawing.Size(101, 20);
            this.lbl_telefon_no.TabIndex = 79;
            this.lbl_telefon_no.Text = "Telefon No:";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad_soyad.Location = new System.Drawing.Point(-105, 140);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(91, 20);
            this.lbl_ad_soyad.TabIndex = 78;
            this.lbl_ad_soyad.Text = "Ad Soyad:";
            // 
            // tbGunlukUcret
            // 
            this.tbGunlukUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGunlukUcret.Location = new System.Drawing.Point(259, 214);
            this.tbGunlukUcret.Name = "tbGunlukUcret";
            this.tbGunlukUcret.Size = new System.Drawing.Size(239, 26);
            this.tbGunlukUcret.TabIndex = 77;
            // 
            // lbl_tc_no
            // 
            this.lbl_tc_no.AutoSize = true;
            this.lbl_tc_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc_no.Location = new System.Drawing.Point(-128, 67);
            this.lbl_tc_no.Name = "lbl_tc_no";
            this.lbl_tc_no.Size = new System.Drawing.Size(114, 20);
            this.lbl_tc_no.TabIndex = 76;
            this.lbl_tc_no.Text = "TC Kimlik No:";
            // 
            // lblGunlukUcret
            // 
            this.lblGunlukUcret.AutoSize = true;
            this.lblGunlukUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunlukUcret.Location = new System.Drawing.Point(133, 217);
            this.lblGunlukUcret.Name = "lblGunlukUcret";
            this.lblGunlukUcret.Size = new System.Drawing.Size(120, 20);
            this.lblGunlukUcret.TabIndex = 90;
            this.lblGunlukUcret.Text = "Günlük Ücret:";
            // 
            // lblSonrakiSaatUcreti
            // 
            this.lblSonrakiSaatUcreti.AutoSize = true;
            this.lblSonrakiSaatUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonrakiSaatUcreti.Location = new System.Drawing.Point(46, 179);
            this.lblSonrakiSaatUcreti.Name = "lblSonrakiSaatUcreti";
            this.lblSonrakiSaatUcreti.Size = new System.Drawing.Size(207, 20);
            this.lblSonrakiSaatUcreti.TabIndex = 89;
            this.lblSonrakiSaatUcreti.Text = "Sonraki Saat Başı Ücret:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(238, 42);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(144, 31);
            this.lblBaslik.TabIndex = 92;
            this.lblBaslik.Text = "Tarife Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(175, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Otopark:";
            // 
            // lbl_ilksaatUcreti
            // 
            this.lbl_ilksaatUcreti.AutoSize = true;
            this.lbl_ilksaatUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilksaatUcreti.Location = new System.Drawing.Point(124, 145);
            this.lbl_ilksaatUcreti.Name = "lbl_ilksaatUcreti";
            this.lbl_ilksaatUcreti.Size = new System.Drawing.Size(129, 20);
            this.lbl_ilksaatUcreti.TabIndex = 96;
            this.lbl_ilksaatUcreti.Text = "İlk Saat Ücreti:";
            // 
            // tbilkSaatUcreti
            // 
            this.tbilkSaatUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbilkSaatUcreti.Location = new System.Drawing.Point(259, 142);
            this.tbilkSaatUcreti.Name = "tbilkSaatUcreti";
            this.tbilkSaatUcreti.Size = new System.Drawing.Size(239, 26);
            this.tbilkSaatUcreti.TabIndex = 95;
            // 
            // cbOtopark
            // 
            this.cbOtopark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtopark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOtopark.FormattingEnabled = true;
            this.cbOtopark.Items.AddRange(new object[] {
            "Seçiniz...",
            "Paket",
            "Dosya"});
            this.cbOtopark.Location = new System.Drawing.Point(259, 110);
            this.cbOtopark.Name = "cbOtopark";
            this.cbOtopark.Size = new System.Drawing.Size(239, 26);
            this.cbOtopark.TabIndex = 97;
            // 
            // tbSonrakiSaatBasiUcret
            // 
            this.tbSonrakiSaatBasiUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSonrakiSaatBasiUcret.Location = new System.Drawing.Point(259, 176);
            this.tbSonrakiSaatBasiUcret.Name = "tbSonrakiSaatBasiUcret";
            this.tbSonrakiSaatBasiUcret.Size = new System.Drawing.Size(239, 26);
            this.tbSonrakiSaatBasiUcret.TabIndex = 98;
            // 
            // fiyatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 347);
            this.Controls.Add(this.tbSonrakiSaatBasiUcret);
            this.Controls.Add(this.cbOtopark);
            this.Controls.Add(this.lbl_ilksaatUcreti);
            this.Controls.Add(this.tbilkSaatUcreti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblGunlukUcret);
            this.Controls.Add(this.lblSonrakiSaatUcreti);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbl_telefon_no);
            this.Controls.Add(this.lbl_ad_soyad);
            this.Controls.Add(this.tbGunlukUcret);
            this.Controls.Add(this.lbl_tc_no);
            this.Name = "fiyatEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarife Ekle";
            this.Load += new System.EventHandler(this.uucretEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lbl_telefon_no;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.TextBox tbGunlukUcret;
        private System.Windows.Forms.Label lbl_tc_no;
        private System.Windows.Forms.Label lblGunlukUcret;
        private System.Windows.Forms.Label lblSonrakiSaatUcreti;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ilksaatUcreti;
        private System.Windows.Forms.TextBox tbilkSaatUcreti;
        private System.Windows.Forms.ComboBox cbOtopark;
        private System.Windows.Forms.TextBox tbSonrakiSaatBasiUcret;
    }
}