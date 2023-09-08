namespace DevletVergiSistemi
{
    partial class BakanlikRapor
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
            this.txt_bakanlikAdi = new System.Windows.Forms.TextBox();
            this.btn_bakanlikAdi = new System.Windows.Forms.Button();
            this.txt_daireBaskanligi = new System.Windows.Forms.TextBox();
            this.btn_daireBaskanligi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_bakanlikRaporDetay = new System.Windows.Forms.DataGridView();
            this.txt_bakanlikAd = new System.Windows.Forms.TextBox();
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek = new System.Windows.Forms.Button();
            this.txt_minCiro = new System.Windows.Forms.TextBox();
            this.btn_ciro_vergiAdi_borcTutar = new System.Windows.Forms.Button();
            this.txt_maxCiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bakanlikAdTerstenSira = new System.Windows.Forms.Button();
            this.btn_bakAdAlfSira = new System.Windows.Forms.Button();
            this.btn_bakTümü = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_bakanlikRaporDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_bakanlikAdi
            // 
            this.txt_bakanlikAdi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_bakanlikAdi.Location = new System.Drawing.Point(24, 46);
            this.txt_bakanlikAdi.Name = "txt_bakanlikAdi";
            this.txt_bakanlikAdi.Size = new System.Drawing.Size(225, 20);
            this.txt_bakanlikAdi.TabIndex = 4;
            this.txt_bakanlikAdi.Text = "Bakanlık adını giriniz...";
            // 
            // btn_bakanlikAdi
            // 
            this.btn_bakanlikAdi.BackColor = System.Drawing.Color.Maroon;
            this.btn_bakanlikAdi.ForeColor = System.Drawing.Color.White;
            this.btn_bakanlikAdi.Location = new System.Drawing.Point(24, 12);
            this.btn_bakanlikAdi.Name = "btn_bakanlikAdi";
            this.btn_bakanlikAdi.Size = new System.Drawing.Size(225, 28);
            this.btn_bakanlikAdi.TabIndex = 3;
            this.btn_bakanlikAdi.Text = "Bakanlık adına göre yapılan sorgu";
            this.btn_bakanlikAdi.UseVisualStyleBackColor = false;
            this.btn_bakanlikAdi.Click += new System.EventHandler(this.btn_bakanlikAdi_Click);
            // 
            // txt_daireBaskanligi
            // 
            this.txt_daireBaskanligi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_daireBaskanligi.Location = new System.Drawing.Point(24, 117);
            this.txt_daireBaskanligi.Name = "txt_daireBaskanligi";
            this.txt_daireBaskanligi.Size = new System.Drawing.Size(225, 20);
            this.txt_daireBaskanligi.TabIndex = 6;
            this.txt_daireBaskanligi.Text = "Daire başkanlığı giriniz...";
            // 
            // btn_daireBaskanligi
            // 
            this.btn_daireBaskanligi.BackColor = System.Drawing.Color.Maroon;
            this.btn_daireBaskanligi.ForeColor = System.Drawing.Color.White;
            this.btn_daireBaskanligi.Location = new System.Drawing.Point(24, 83);
            this.btn_daireBaskanligi.Name = "btn_daireBaskanligi";
            this.btn_daireBaskanligi.Size = new System.Drawing.Size(225, 28);
            this.btn_daireBaskanligi.TabIndex = 5;
            this.btn_daireBaskanligi.Text = "Daire başkanlığına göre arama";
            this.btn_daireBaskanligi.UseVisualStyleBackColor = false;
            this.btn_daireBaskanligi.Click += new System.EventHandler(this.btn_daireBaskanligi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_bakanlikRaporDetay);
            this.groupBox1.Location = new System.Drawing.Point(612, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 410);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bakanlık Rapor Detayı";
            // 
            // dgw_bakanlikRaporDetay
            // 
            this.dgw_bakanlikRaporDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_bakanlikRaporDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_bakanlikRaporDetay.Location = new System.Drawing.Point(3, 16);
            this.dgw_bakanlikRaporDetay.Name = "dgw_bakanlikRaporDetay";
            this.dgw_bakanlikRaporDetay.Size = new System.Drawing.Size(416, 391);
            this.dgw_bakanlikRaporDetay.TabIndex = 0;
            // 
            // txt_bakanlikAd
            // 
            this.txt_bakanlikAd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_bakanlikAd.Location = new System.Drawing.Point(24, 186);
            this.txt_bakanlikAd.Name = "txt_bakanlikAd";
            this.txt_bakanlikAd.Size = new System.Drawing.Size(225, 20);
            this.txt_bakanlikAd.TabIndex = 11;
            this.txt_bakanlikAd.Text = "Bakanlık adı giriniz...";
            // 
            // btn_bakanlikAdCirVerTütarBorcAdiVatMeslek
            // 
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.BackColor = System.Drawing.Color.Maroon;
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.ForeColor = System.Drawing.Color.White;
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.Location = new System.Drawing.Point(24, 152);
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.Name = "btn_bakanlikAdCirVerTütarBorcAdiVatMeslek";
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.Size = new System.Drawing.Size(225, 28);
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.TabIndex = 10;
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.Text = "Bakanlık Ad-Ciro-Tutar-Borç Adı-Meslek";
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.UseVisualStyleBackColor = false;
            this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek.Click += new System.EventHandler(this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek_Click);
            // 
            // txt_minCiro
            // 
            this.txt_minCiro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_minCiro.Location = new System.Drawing.Point(24, 262);
            this.txt_minCiro.Name = "txt_minCiro";
            this.txt_minCiro.Size = new System.Drawing.Size(98, 20);
            this.txt_minCiro.TabIndex = 13;
            this.txt_minCiro.Text = "Min Ciro giriniz";
            // 
            // btn_ciro_vergiAdi_borcTutar
            // 
            this.btn_ciro_vergiAdi_borcTutar.BackColor = System.Drawing.Color.Maroon;
            this.btn_ciro_vergiAdi_borcTutar.ForeColor = System.Drawing.Color.White;
            this.btn_ciro_vergiAdi_borcTutar.Location = new System.Drawing.Point(24, 228);
            this.btn_ciro_vergiAdi_borcTutar.Name = "btn_ciro_vergiAdi_borcTutar";
            this.btn_ciro_vergiAdi_borcTutar.Size = new System.Drawing.Size(225, 28);
            this.btn_ciro_vergiAdi_borcTutar.TabIndex = 12;
            this.btn_ciro_vergiAdi_borcTutar.Text = "Ciroya göre bakanlık Adı-Daire Başk.";
            this.btn_ciro_vergiAdi_borcTutar.UseVisualStyleBackColor = false;
            this.btn_ciro_vergiAdi_borcTutar.Click += new System.EventHandler(this.btn_ciro_vergiAdi_borcTutar_Click);
            // 
            // txt_maxCiro
            // 
            this.txt_maxCiro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_maxCiro.Location = new System.Drawing.Point(151, 262);
            this.txt_maxCiro.Name = "txt_maxCiro";
            this.txt_maxCiro.Size = new System.Drawing.Size(98, 20);
            this.txt_maxCiro.TabIndex = 14;
            this.txt_maxCiro.Text = "Maks ciro giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "----";
            // 
            // btn_bakanlikAdTerstenSira
            // 
            this.btn_bakanlikAdTerstenSira.BackColor = System.Drawing.Color.Maroon;
            this.btn_bakanlikAdTerstenSira.ForeColor = System.Drawing.Color.White;
            this.btn_bakanlikAdTerstenSira.Location = new System.Drawing.Point(307, 12);
            this.btn_bakanlikAdTerstenSira.Name = "btn_bakanlikAdTerstenSira";
            this.btn_bakanlikAdTerstenSira.Size = new System.Drawing.Size(102, 54);
            this.btn_bakanlikAdTerstenSira.TabIndex = 16;
            this.btn_bakanlikAdTerstenSira.Text = "Bakanlık adı tersten sıralama";
            this.btn_bakanlikAdTerstenSira.UseVisualStyleBackColor = false;
            this.btn_bakanlikAdTerstenSira.Click += new System.EventHandler(this.btn_bakanlikAdTerstenSira_Click);
            // 
            // btn_bakAdAlfSira
            // 
            this.btn_bakAdAlfSira.BackColor = System.Drawing.Color.Maroon;
            this.btn_bakAdAlfSira.ForeColor = System.Drawing.Color.White;
            this.btn_bakAdAlfSira.Location = new System.Drawing.Point(434, 12);
            this.btn_bakAdAlfSira.Name = "btn_bakAdAlfSira";
            this.btn_bakAdAlfSira.Size = new System.Drawing.Size(102, 54);
            this.btn_bakAdAlfSira.TabIndex = 17;
            this.btn_bakAdAlfSira.Text = "Bakanlık adı alfabetik sıralama";
            this.btn_bakAdAlfSira.UseVisualStyleBackColor = false;
            this.btn_bakAdAlfSira.Click += new System.EventHandler(this.btn_bakAdAlfSira_Click);
            // 
            // btn_bakTümü
            // 
            this.btn_bakTümü.BackColor = System.Drawing.Color.Maroon;
            this.btn_bakTümü.ForeColor = System.Drawing.Color.White;
            this.btn_bakTümü.Location = new System.Drawing.Point(307, 87);
            this.btn_bakTümü.Name = "btn_bakTümü";
            this.btn_bakTümü.Size = new System.Drawing.Size(225, 59);
            this.btn_bakTümü.TabIndex = 18;
            this.btn_bakTümü.Text = "Bkn.Adı-Ciro//Vergi Adı-Tip//Borç Ad-Tarih//Vat.Meslek-Tel";
            this.btn_bakTümü.UseVisualStyleBackColor = false;
            this.btn_bakTümü.Click += new System.EventHandler(this.btn_bakTümü_Click);
            // 
            // BakanlikRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.btn_bakTümü);
            this.Controls.Add(this.btn_bakAdAlfSira);
            this.Controls.Add(this.btn_bakanlikAdTerstenSira);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maxCiro);
            this.Controls.Add(this.txt_minCiro);
            this.Controls.Add(this.btn_ciro_vergiAdi_borcTutar);
            this.Controls.Add(this.txt_bakanlikAd);
            this.Controls.Add(this.btn_bakanlikAdCirVerTütarBorcAdiVatMeslek);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_daireBaskanligi);
            this.Controls.Add(this.btn_daireBaskanligi);
            this.Controls.Add(this.txt_bakanlikAdi);
            this.Controls.Add(this.btn_bakanlikAdi);
            this.Name = "BakanlikRapor";
            this.Text = "Bakanlık Rapor";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_bakanlikRaporDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_bakanlikAdi;
        private System.Windows.Forms.Button btn_bakanlikAdi;
        private System.Windows.Forms.TextBox txt_daireBaskanligi;
        private System.Windows.Forms.Button btn_daireBaskanligi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_bakanlikRaporDetay;
        private System.Windows.Forms.TextBox txt_bakanlikAd;
        private System.Windows.Forms.Button btn_bakanlikAdCirVerTütarBorcAdiVatMeslek;
        private System.Windows.Forms.TextBox txt_minCiro;
        private System.Windows.Forms.Button btn_ciro_vergiAdi_borcTutar;
        private System.Windows.Forms.TextBox txt_maxCiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bakanlikAdTerstenSira;
        private System.Windows.Forms.Button btn_bakAdAlfSira;
        private System.Windows.Forms.Button btn_bakTümü;
    }
}