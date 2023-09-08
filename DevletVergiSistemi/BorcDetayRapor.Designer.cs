namespace DevletVergiSistemi
{
    partial class BorcDetayRapor
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
            this.txt_sehirSorgu = new System.Windows.Forms.TextBox();
            this.btn_büyükBin = new System.Windows.Forms.Button();
            this.btn_ödemeDurum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_borcRapor = new System.Windows.Forms.DataGridView();
            this.btn_borcTarihSira = new System.Windows.Forms.Button();
            this.dtp_borcTarihSira = new System.Windows.Forms.DateTimePicker();
            this.dtp_baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_secilenIkiTarih = new System.Windows.Forms.Button();
            this.dtp_bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_borcRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sehirSorgu
            // 
            this.txt_sehirSorgu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_sehirSorgu.Location = new System.Drawing.Point(24, 86);
            this.txt_sehirSorgu.Name = "txt_sehirSorgu";
            this.txt_sehirSorgu.Size = new System.Drawing.Size(357, 20);
            this.txt_sehirSorgu.TabIndex = 6;
            this.txt_sehirSorgu.Text = "Durum bilgisi giriniz//ödendi-ödenmedi";
            // 
            // btn_büyükBin
            // 
            this.btn_büyükBin.BackColor = System.Drawing.Color.Maroon;
            this.btn_büyükBin.ForeColor = System.Drawing.Color.White;
            this.btn_büyükBin.Location = new System.Drawing.Point(24, 12);
            this.btn_büyükBin.Name = "btn_büyükBin";
            this.btn_büyükBin.Size = new System.Drawing.Size(357, 34);
            this.btn_büyükBin.TabIndex = 5;
            this.btn_büyükBin.Text = "Borç tutarı 1000 den fazla olanlar";
            this.btn_büyükBin.UseVisualStyleBackColor = false;
            // 
            // btn_ödemeDurum
            // 
            this.btn_ödemeDurum.BackColor = System.Drawing.Color.Maroon;
            this.btn_ödemeDurum.ForeColor = System.Drawing.Color.White;
            this.btn_ödemeDurum.Location = new System.Drawing.Point(24, 52);
            this.btn_ödemeDurum.Name = "btn_ödemeDurum";
            this.btn_ödemeDurum.Size = new System.Drawing.Size(357, 28);
            this.btn_ödemeDurum.TabIndex = 4;
            this.btn_ödemeDurum.Text = "Ödeme durumuna göre borçlar";
            this.btn_ödemeDurum.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_borcRapor);
            this.groupBox1.Location = new System.Drawing.Point(673, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 426);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borç Durumu Bilgisi";
            // 
            // dgw_borcRapor
            // 
            this.dgw_borcRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_borcRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_borcRapor.Location = new System.Drawing.Point(3, 16);
            this.dgw_borcRapor.Name = "dgw_borcRapor";
            this.dgw_borcRapor.Size = new System.Drawing.Size(280, 407);
            this.dgw_borcRapor.TabIndex = 0;
            // 
            // btn_borcTarihSira
            // 
            this.btn_borcTarihSira.BackColor = System.Drawing.Color.Maroon;
            this.btn_borcTarihSira.ForeColor = System.Drawing.Color.White;
            this.btn_borcTarihSira.Location = new System.Drawing.Point(24, 112);
            this.btn_borcTarihSira.Name = "btn_borcTarihSira";
            this.btn_borcTarihSira.Size = new System.Drawing.Size(357, 28);
            this.btn_borcTarihSira.TabIndex = 8;
            this.btn_borcTarihSira.Text = "Borç  tarihine göre sıralama";
            this.btn_borcTarihSira.UseVisualStyleBackColor = false;
            // 
            // dtp_borcTarihSira
            // 
            this.dtp_borcTarihSira.Location = new System.Drawing.Point(24, 146);
            this.dtp_borcTarihSira.Name = "dtp_borcTarihSira";
            this.dtp_borcTarihSira.Size = new System.Drawing.Size(357, 20);
            this.dtp_borcTarihSira.TabIndex = 9;
            // 
            // dtp_baslangicTarihi
            // 
            this.dtp_baslangicTarihi.Location = new System.Drawing.Point(24, 217);
            this.dtp_baslangicTarihi.Name = "dtp_baslangicTarihi";
            this.dtp_baslangicTarihi.Size = new System.Drawing.Size(162, 20);
            this.dtp_baslangicTarihi.TabIndex = 11;
            // 
            // btn_secilenIkiTarih
            // 
            this.btn_secilenIkiTarih.BackColor = System.Drawing.Color.Maroon;
            this.btn_secilenIkiTarih.ForeColor = System.Drawing.Color.White;
            this.btn_secilenIkiTarih.Location = new System.Drawing.Point(24, 172);
            this.btn_secilenIkiTarih.Name = "btn_secilenIkiTarih";
            this.btn_secilenIkiTarih.Size = new System.Drawing.Size(357, 28);
            this.btn_secilenIkiTarih.TabIndex = 10;
            this.btn_secilenIkiTarih.Text = "Seçilen iki tarih değerine göre sorgulama";
            this.btn_secilenIkiTarih.UseVisualStyleBackColor = false;
            this.btn_secilenIkiTarih.Click += new System.EventHandler(this.btn_secilenIkiTarih_Click);
            // 
            // dtp_bitisTarihi
            // 
            this.dtp_bitisTarihi.Location = new System.Drawing.Point(219, 217);
            this.dtp_bitisTarihi.Name = "dtp_bitisTarihi";
            this.dtp_bitisTarihi.Size = new System.Drawing.Size(162, 20);
            this.dtp_bitisTarihi.TabIndex = 12;
            // 
            // BorcDetayRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.dtp_bitisTarihi);
            this.Controls.Add(this.dtp_baslangicTarihi);
            this.Controls.Add(this.btn_secilenIkiTarih);
            this.Controls.Add(this.dtp_borcTarihSira);
            this.Controls.Add(this.btn_borcTarihSira);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_sehirSorgu);
            this.Controls.Add(this.btn_büyükBin);
            this.Controls.Add(this.btn_ödemeDurum);
            this.Name = "BorcDetayRapor";
            this.Text = "Borç Rapor Detayı";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_borcRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_sehirSorgu;
        private System.Windows.Forms.Button btn_büyükBin;
        private System.Windows.Forms.Button btn_ödemeDurum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_borcRapor;
        private System.Windows.Forms.Button btn_borcTarihSira;
        private System.Windows.Forms.DateTimePicker dtp_borcTarihSira;
        private System.Windows.Forms.DateTimePicker dtp_baslangicTarihi;
        private System.Windows.Forms.Button btn_secilenIkiTarih;
        private System.Windows.Forms.DateTimePicker dtp_bitisTarihi;
    }
}