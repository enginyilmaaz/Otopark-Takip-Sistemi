namespace WindowsFormsApplication1
{
    partial class yetkiGuncelle
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
            this.cbModul = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.btn_yetkili_ekle = new System.Windows.Forms.Button();
            this.tb_yetki = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(156, 48);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(189, 31);
            this.lblBaslik.TabIndex = 49;
            this.lblBaslik.Text = "Yetki Güncelle";
            // 
            // cbModul
            // 
            this.cbModul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbModul.FormattingEnabled = true;
            this.cbModul.Location = new System.Drawing.Point(162, 166);
            this.cbModul.Name = "cbModul";
            this.cbModul.Size = new System.Drawing.Size(311, 28);
            this.cbModul.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ekran Erişimi:";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(88, 129);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(68, 20);
            this.lbl_cinsiyet.TabIndex = 52;
            this.lbl_cinsiyet.Text = "Yetkisi:";
            // 
            // btn_yetkili_ekle
            // 
            this.btn_yetkili_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkili_ekle.Location = new System.Drawing.Point(41, 241);
            this.btn_yetkili_ekle.Name = "btn_yetkili_ekle";
            this.btn_yetkili_ekle.Size = new System.Drawing.Size(432, 32);
            this.btn_yetkili_ekle.TabIndex = 51;
            this.btn_yetkili_ekle.Text = "Güncelle";
            this.btn_yetkili_ekle.UseVisualStyleBackColor = true;
            this.btn_yetkili_ekle.Click += new System.EventHandler(this.btn_yetkili_ekle_Click);
            // 
            // tb_yetki
            // 
            this.tb_yetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yetki.Location = new System.Drawing.Point(162, 126);
            this.tb_yetki.Name = "tb_yetki";
            this.tb_yetki.Size = new System.Drawing.Size(311, 26);
            this.tb_yetki.TabIndex = 50;
            // 
            // yetkiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 324);
            this.Controls.Add(this.cbModul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.btn_yetkili_ekle);
            this.Controls.Add(this.tb_yetki);
            this.Controls.Add(this.lblBaslik);
            this.Name = "yetkiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki Güncelle";
            this.Load += new System.EventHandler(this.yetkiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.ComboBox cbModul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Button btn_yetkili_ekle;
        private System.Windows.Forms.TextBox tb_yetki;
    }
}