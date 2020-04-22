namespace WindowsFormsApplication1
{
    partial class tarifeGuncelle
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
            this.tbSonrakiSaatBasiUcret = new System.Windows.Forms.TextBox();
            this.cbOtopark = new System.Windows.Forms.ComboBox();
            this.lbl_ilksaatUcreti = new System.Windows.Forms.Label();
            this.tbilkSaatUcreti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblGunlukUcret = new System.Windows.Forms.Label();
            this.lblSonrakiSaatUcreti = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbGunlukUcret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSonrakiSaatBasiUcret
            // 
            this.tbSonrakiSaatBasiUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSonrakiSaatBasiUcret.Location = new System.Drawing.Point(264, 182);
            this.tbSonrakiSaatBasiUcret.Name = "tbSonrakiSaatBasiUcret";
            this.tbSonrakiSaatBasiUcret.Size = new System.Drawing.Size(239, 26);
            this.tbSonrakiSaatBasiUcret.TabIndex = 108;
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
            this.cbOtopark.Location = new System.Drawing.Point(264, 112);
            this.cbOtopark.Name = "cbOtopark";
            this.cbOtopark.Size = new System.Drawing.Size(239, 26);
            this.cbOtopark.TabIndex = 107;
            // 
            // lbl_ilksaatUcreti
            // 
            this.lbl_ilksaatUcreti.AutoSize = true;
            this.lbl_ilksaatUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilksaatUcreti.Location = new System.Drawing.Point(129, 148);
            this.lbl_ilksaatUcreti.Name = "lbl_ilksaatUcreti";
            this.lbl_ilksaatUcreti.Size = new System.Drawing.Size(129, 20);
            this.lbl_ilksaatUcreti.TabIndex = 106;
            this.lbl_ilksaatUcreti.Text = "İlk Saat Ücreti:";
            // 
            // tbilkSaatUcreti
            // 
            this.tbilkSaatUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbilkSaatUcreti.Location = new System.Drawing.Point(264, 145);
            this.tbilkSaatUcreti.Name = "tbilkSaatUcreti";
            this.tbilkSaatUcreti.Size = new System.Drawing.Size(239, 26);
            this.tbilkSaatUcreti.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(180, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Otopark:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(178, 37);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(218, 31);
            this.lblBaslik.TabIndex = 103;
            this.lblBaslik.Text = "Tarifeyi Güncelle";
            // 
            // lblGunlukUcret
            // 
            this.lblGunlukUcret.AutoSize = true;
            this.lblGunlukUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunlukUcret.Location = new System.Drawing.Point(138, 220);
            this.lblGunlukUcret.Name = "lblGunlukUcret";
            this.lblGunlukUcret.Size = new System.Drawing.Size(120, 20);
            this.lblGunlukUcret.TabIndex = 102;
            this.lblGunlukUcret.Text = "Günlük Ücret:";
            // 
            // lblSonrakiSaatUcreti
            // 
            this.lblSonrakiSaatUcreti.AutoSize = true;
            this.lblSonrakiSaatUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonrakiSaatUcreti.Location = new System.Drawing.Point(51, 182);
            this.lblSonrakiSaatUcreti.Name = "lblSonrakiSaatUcreti";
            this.lblSonrakiSaatUcreti.Size = new System.Drawing.Size(207, 20);
            this.lblSonrakiSaatUcreti.TabIndex = 101;
            this.lblSonrakiSaatUcreti.Text = "Sonraki Saat Başı Ücret:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(55, 272);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(448, 35);
            this.btnGuncelle.TabIndex = 100;
            this.btnGuncelle.Text = "Güncelleştir";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbGunlukUcret
            // 
            this.tbGunlukUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGunlukUcret.Location = new System.Drawing.Point(264, 217);
            this.tbGunlukUcret.Name = "tbGunlukUcret";
            this.tbGunlukUcret.Size = new System.Drawing.Size(239, 26);
            this.tbGunlukUcret.TabIndex = 99;
            // 
            // tarifeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 353);
            this.Controls.Add(this.tbSonrakiSaatBasiUcret);
            this.Controls.Add(this.cbOtopark);
            this.Controls.Add(this.lbl_ilksaatUcreti);
            this.Controls.Add(this.tbilkSaatUcreti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblGunlukUcret);
            this.Controls.Add(this.lblSonrakiSaatUcreti);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tbGunlukUcret);
            this.Name = "tarifeGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarife Güncelle";
            this.Load += new System.EventHandler(this.ucrettEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSonrakiSaatBasiUcret;
        private System.Windows.Forms.ComboBox cbOtopark;
        private System.Windows.Forms.Label lbl_ilksaatUcreti;
        private System.Windows.Forms.TextBox tbilkSaatUcreti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblGunlukUcret;
        private System.Windows.Forms.Label lblSonrakiSaatUcreti;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbGunlukUcret;
    }
}