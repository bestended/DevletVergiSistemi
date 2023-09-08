namespace DevletVergiSistemi
{
    partial class VergiRaporDetay
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
            this.txt_vergiTipi = new System.Windows.Forms.TextBox();
            this.btn_vergiTipi = new System.Windows.Forms.Button();
            this.txt_tutarUst = new System.Windows.Forms.TextBox();
            this.btn_tutarUst = new System.Windows.Forms.Button();
            this.txt_faizUst = new System.Windows.Forms.TextBox();
            this.btn_faizUst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_vergiRaporDetay = new System.Windows.Forms.DataGridView();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.btn_secilenTutar = new System.Windows.Forms.Button();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vergiTipi1 = new System.Windows.Forms.TextBox();
            this.txt_vergiAdi = new System.Windows.Forms.TextBox();
            this.btn_vergiAdiTipi = new System.Windows.Forms.Button();
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask = new System.Windows.Forms.Button();
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih = new System.Windows.Forms.Button();
            this.btn_vergiVatandasBorcBakanlik = new System.Windows.Forms.Button();
            this.txt_vergiTipi3 = new System.Windows.Forms.TextBox();
            this.btn_vergiTipi_BakanlikAdi_meslek = new System.Windows.Forms.Button();
            this.txt_borcMin = new System.Windows.Forms.TextBox();
            this.btn_borcAralik = new System.Windows.Forms.Button();
            this.txt_borcMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_vergiAdiSiralama = new System.Windows.Forms.Button();
            this.btn_vergiTipiGruplama = new System.Windows.Forms.Button();
            this.btn_vergiAdiGruplama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_vergiRaporDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vergiTipi
            // 
            this.txt_vergiTipi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_vergiTipi.Location = new System.Drawing.Point(24, 42);
            this.txt_vergiTipi.Name = "txt_vergiTipi";
            this.txt_vergiTipi.Size = new System.Drawing.Size(357, 20);
            this.txt_vergiTipi.TabIndex = 5;
            this.txt_vergiTipi.Text = "Vergi tipini giriniz...";
            // 
            // btn_vergiTipi
            // 
            this.btn_vergiTipi.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiTipi.ForeColor = System.Drawing.Color.White;
            this.btn_vergiTipi.Location = new System.Drawing.Point(24, 12);
            this.btn_vergiTipi.Name = "btn_vergiTipi";
            this.btn_vergiTipi.Size = new System.Drawing.Size(357, 24);
            this.btn_vergiTipi.TabIndex = 4;
            this.btn_vergiTipi.Text = "Vergi tipine göre//bireysel-kurumsal ";
            this.btn_vergiTipi.UseVisualStyleBackColor = false;
            this.btn_vergiTipi.Click += new System.EventHandler(this.btn_vergiTipi_Click);
            // 
            // txt_tutarUst
            // 
            this.txt_tutarUst.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_tutarUst.Location = new System.Drawing.Point(24, 100);
            this.txt_tutarUst.Name = "txt_tutarUst";
            this.txt_tutarUst.Size = new System.Drawing.Size(357, 20);
            this.txt_tutarUst.TabIndex = 7;
            this.txt_tutarUst.Text = "Tutar giriniz...";
            // 
            // btn_tutarUst
            // 
            this.btn_tutarUst.BackColor = System.Drawing.Color.Maroon;
            this.btn_tutarUst.ForeColor = System.Drawing.Color.White;
            this.btn_tutarUst.Location = new System.Drawing.Point(24, 68);
            this.btn_tutarUst.Name = "btn_tutarUst";
            this.btn_tutarUst.Size = new System.Drawing.Size(357, 26);
            this.btn_tutarUst.TabIndex = 6;
            this.btn_tutarUst.Text = "Tutarı girilen değer üstünde olanlar";
            this.btn_tutarUst.UseVisualStyleBackColor = false;
            this.btn_tutarUst.Click += new System.EventHandler(this.btn_tutarUst_Click);
            // 
            // txt_faizUst
            // 
            this.txt_faizUst.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_faizUst.Location = new System.Drawing.Point(24, 159);
            this.txt_faizUst.Name = "txt_faizUst";
            this.txt_faizUst.Size = new System.Drawing.Size(357, 20);
            this.txt_faizUst.TabIndex = 9;
            this.txt_faizUst.Text = "Faiz giriniz...";
            // 
            // btn_faizUst
            // 
            this.btn_faizUst.BackColor = System.Drawing.Color.Maroon;
            this.btn_faizUst.ForeColor = System.Drawing.Color.White;
            this.btn_faizUst.Location = new System.Drawing.Point(24, 126);
            this.btn_faizUst.Name = "btn_faizUst";
            this.btn_faizUst.Size = new System.Drawing.Size(357, 27);
            this.btn_faizUst.TabIndex = 8;
            this.btn_faizUst.Text = "Faizi girilen değer üstünde olanlar";
            this.btn_faizUst.UseVisualStyleBackColor = false;
            this.btn_faizUst.Click += new System.EventHandler(this.btn_faizUst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_vergiRaporDetay);
            this.groupBox1.Location = new System.Drawing.Point(839, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 436);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vergi Rapor Detayı";
            // 
            // dgw_vergiRaporDetay
            // 
            this.dgw_vergiRaporDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_vergiRaporDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_vergiRaporDetay.Location = new System.Drawing.Point(3, 16);
            this.dgw_vergiRaporDetay.Name = "dgw_vergiRaporDetay";
            this.dgw_vergiRaporDetay.Size = new System.Drawing.Size(351, 417);
            this.dgw_vergiRaporDetay.TabIndex = 0;
            // 
            // txt_min
            // 
            this.txt_min.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_min.Location = new System.Drawing.Point(24, 218);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(135, 20);
            this.txt_min.TabIndex = 12;
            this.txt_min.Text = "Min tutar giriniz";
            // 
            // btn_secilenTutar
            // 
            this.btn_secilenTutar.BackColor = System.Drawing.Color.Maroon;
            this.btn_secilenTutar.ForeColor = System.Drawing.Color.White;
            this.btn_secilenTutar.Location = new System.Drawing.Point(24, 185);
            this.btn_secilenTutar.Name = "btn_secilenTutar";
            this.btn_secilenTutar.Size = new System.Drawing.Size(357, 27);
            this.btn_secilenTutar.TabIndex = 11;
            this.btn_secilenTutar.Text = "Tutarı seçilen aralıkta olanlar";
            this.btn_secilenTutar.UseVisualStyleBackColor = false;
            this.btn_secilenTutar.Click += new System.EventHandler(this.btn_secilenTutar_Click);
            // 
            // txt_max
            // 
            this.txt_max.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_max.Location = new System.Drawing.Point(215, 218);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(166, 20);
            this.txt_max.TabIndex = 13;
            this.txt_max.Text = "Max tutar giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "----";
            // 
            // txt_vergiTipi1
            // 
            this.txt_vergiTipi1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_vergiTipi1.Location = new System.Drawing.Point(215, 293);
            this.txt_vergiTipi1.Name = "txt_vergiTipi1";
            this.txt_vergiTipi1.Size = new System.Drawing.Size(166, 20);
            this.txt_vergiTipi1.TabIndex = 17;
            this.txt_vergiTipi1.Text = "Vergi tipini giriniz";
            // 
            // txt_vergiAdi
            // 
            this.txt_vergiAdi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_vergiAdi.Location = new System.Drawing.Point(24, 293);
            this.txt_vergiAdi.Name = "txt_vergiAdi";
            this.txt_vergiAdi.Size = new System.Drawing.Size(135, 20);
            this.txt_vergiAdi.TabIndex = 16;
            this.txt_vergiAdi.Text = "Vergi adını giriniz";
            // 
            // btn_vergiAdiTipi
            // 
            this.btn_vergiAdiTipi.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiAdiTipi.ForeColor = System.Drawing.Color.White;
            this.btn_vergiAdiTipi.Location = new System.Drawing.Point(24, 260);
            this.btn_vergiAdiTipi.Name = "btn_vergiAdiTipi";
            this.btn_vergiAdiTipi.Size = new System.Drawing.Size(357, 27);
            this.btn_vergiAdiTipi.TabIndex = 15;
            this.btn_vergiAdiTipi.Text = "Vergi Adı-Vergi Tpine göre arama";
            this.btn_vergiAdiTipi.UseVisualStyleBackColor = false;
            this.btn_vergiAdiTipi.Click += new System.EventHandler(this.btn_vergiAdiTipi_Click);
            // 
            // btn_vergiAd_vergiTip_BaakAd_DaireBask
            // 
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.ForeColor = System.Drawing.Color.White;
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.Location = new System.Drawing.Point(24, 334);
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.Name = "btn_vergiAd_vergiTip_BaakAd_DaireBask";
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.Size = new System.Drawing.Size(357, 24);
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.TabIndex = 19;
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.Text = "Vergi adı-Vergi tipi-Bakanlık Adı-Daire Başkanlığı";
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.UseVisualStyleBackColor = false;
            this.btn_vergiAd_vergiTip_BaakAd_DaireBask.Click += new System.EventHandler(this.btn_vergiAd_vergiTip_BaakAd_DaireBask_Click);
            // 
            // btn_vergiAd_bakanlikAd_borcAd_borcTarih
            // 
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.ForeColor = System.Drawing.Color.White;
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.Location = new System.Drawing.Point(24, 373);
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.Name = "btn_vergiAd_bakanlikAd_borcAd_borcTarih";
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.Size = new System.Drawing.Size(357, 24);
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.TabIndex = 20;
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.Text = "Vergi adı-Bakanlık Adı-Borç adı-Borç tarihi";
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.UseVisualStyleBackColor = false;
            this.btn_vergiAd_bakanlikAd_borcAd_borcTarih.Click += new System.EventHandler(this.btn_vergiAd_bakanlikAd_borcAd_borcTarih_Click);
            // 
            // btn_vergiVatandasBorcBakanlik
            // 
            this.btn_vergiVatandasBorcBakanlik.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiVatandasBorcBakanlik.ForeColor = System.Drawing.Color.White;
            this.btn_vergiVatandasBorcBakanlik.Location = new System.Drawing.Point(24, 414);
            this.btn_vergiVatandasBorcBakanlik.Name = "btn_vergiVatandasBorcBakanlik";
            this.btn_vergiVatandasBorcBakanlik.Size = new System.Drawing.Size(357, 24);
            this.btn_vergiVatandasBorcBakanlik.TabIndex = 21;
            this.btn_vergiVatandasBorcBakanlik.Text = "Vergi adı-Bakanlık Adı-Borç adı-Meslek";
            this.btn_vergiVatandasBorcBakanlik.UseVisualStyleBackColor = false;
            this.btn_vergiVatandasBorcBakanlik.Click += new System.EventHandler(this.btn_vergiVatandasBorcBakanlik_Click);
            // 
            // txt_vergiTipi3
            // 
            this.txt_vergiTipi3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_vergiTipi3.Location = new System.Drawing.Point(423, 42);
            this.txt_vergiTipi3.Name = "txt_vergiTipi3";
            this.txt_vergiTipi3.Size = new System.Drawing.Size(394, 20);
            this.txt_vergiTipi3.TabIndex = 23;
            this.txt_vergiTipi3.Text = "Vergi tipini giriniz...";
            // 
            // btn_vergiTipi_BakanlikAdi_meslek
            // 
            this.btn_vergiTipi_BakanlikAdi_meslek.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiTipi_BakanlikAdi_meslek.ForeColor = System.Drawing.Color.White;
            this.btn_vergiTipi_BakanlikAdi_meslek.Location = new System.Drawing.Point(423, 12);
            this.btn_vergiTipi_BakanlikAdi_meslek.Name = "btn_vergiTipi_BakanlikAdi_meslek";
            this.btn_vergiTipi_BakanlikAdi_meslek.Size = new System.Drawing.Size(394, 24);
            this.btn_vergiTipi_BakanlikAdi_meslek.TabIndex = 22;
            this.btn_vergiTipi_BakanlikAdi_meslek.Text = "Girilen vergi tipine göre bakanlık adı-vatandas  mesleği";
            this.btn_vergiTipi_BakanlikAdi_meslek.UseVisualStyleBackColor = false;
            this.btn_vergiTipi_BakanlikAdi_meslek.Click += new System.EventHandler(this.btn_vergiTipi_BakanlikAdi_meslek_Click);
            // 
            // txt_borcMin
            // 
            this.txt_borcMin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_borcMin.Location = new System.Drawing.Point(423, 98);
            this.txt_borcMin.Name = "txt_borcMin";
            this.txt_borcMin.Size = new System.Drawing.Size(160, 20);
            this.txt_borcMin.TabIndex = 25;
            this.txt_borcMin.Text = "Min değer";
            // 
            // btn_borcAralik
            // 
            this.btn_borcAralik.BackColor = System.Drawing.Color.Maroon;
            this.btn_borcAralik.ForeColor = System.Drawing.Color.White;
            this.btn_borcAralik.Location = new System.Drawing.Point(423, 68);
            this.btn_borcAralik.Name = "btn_borcAralik";
            this.btn_borcAralik.Size = new System.Drawing.Size(394, 24);
            this.btn_borcAralik.TabIndex = 24;
            this.btn_borcAralik.Text = "Borç girilen değer aralığı";
            this.btn_borcAralik.UseVisualStyleBackColor = false;
            this.btn_borcAralik.Click += new System.EventHandler(this.btn_borcAralik_Click);
            // 
            // txt_borcMax
            // 
            this.txt_borcMax.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_borcMax.Location = new System.Drawing.Point(640, 98);
            this.txt_borcMax.Name = "txt_borcMax";
            this.txt_borcMax.Size = new System.Drawing.Size(177, 20);
            this.txt_borcMax.TabIndex = 26;
            this.txt_borcMax.Text = "Max değer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "--";
            // 
            // btn_vergiAdiSiralama
            // 
            this.btn_vergiAdiSiralama.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiAdiSiralama.ForeColor = System.Drawing.Color.White;
            this.btn_vergiAdiSiralama.Location = new System.Drawing.Point(423, 159);
            this.btn_vergiAdiSiralama.Name = "btn_vergiAdiSiralama";
            this.btn_vergiAdiSiralama.Size = new System.Drawing.Size(394, 24);
            this.btn_vergiAdiSiralama.TabIndex = 32;
            this.btn_vergiAdiSiralama.Text = "Vergi adına göre sıralama";
            this.btn_vergiAdiSiralama.UseVisualStyleBackColor = false;
            this.btn_vergiAdiSiralama.Click += new System.EventHandler(this.btn_vergiAdiSiralama_Click);
            // 
            // btn_vergiTipiGruplama
            // 
            this.btn_vergiTipiGruplama.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiTipiGruplama.ForeColor = System.Drawing.Color.White;
            this.btn_vergiTipiGruplama.Location = new System.Drawing.Point(423, 189);
            this.btn_vergiTipiGruplama.Name = "btn_vergiTipiGruplama";
            this.btn_vergiTipiGruplama.Size = new System.Drawing.Size(394, 24);
            this.btn_vergiTipiGruplama.TabIndex = 33;
            this.btn_vergiTipiGruplama.Text = "Vergi tipine göre gruplama";
            this.btn_vergiTipiGruplama.UseVisualStyleBackColor = false;
            this.btn_vergiTipiGruplama.Click += new System.EventHandler(this.btn_vergiTipiGruplama_Click);
            // 
            // btn_vergiAdiGruplama
            // 
            this.btn_vergiAdiGruplama.BackColor = System.Drawing.Color.Maroon;
            this.btn_vergiAdiGruplama.ForeColor = System.Drawing.Color.White;
            this.btn_vergiAdiGruplama.Location = new System.Drawing.Point(423, 129);
            this.btn_vergiAdiGruplama.Name = "btn_vergiAdiGruplama";
            this.btn_vergiAdiGruplama.Size = new System.Drawing.Size(394, 24);
            this.btn_vergiAdiGruplama.TabIndex = 34;
            this.btn_vergiAdiGruplama.Text = "Vergi adına göre gruplama";
            this.btn_vergiAdiGruplama.UseVisualStyleBackColor = false;
            this.btn_vergiAdiGruplama.Click += new System.EventHandler(this.btn_vergiAdiGruplama_Click);
            // 
            // VergiRaporDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.btn_vergiAdiGruplama);
            this.Controls.Add(this.btn_vergiTipiGruplama);
            this.Controls.Add(this.btn_vergiAdiSiralama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_borcMax);
            this.Controls.Add(this.txt_borcMin);
            this.Controls.Add(this.btn_borcAralik);
            this.Controls.Add(this.txt_vergiTipi3);
            this.Controls.Add(this.btn_vergiTipi_BakanlikAdi_meslek);
            this.Controls.Add(this.btn_vergiVatandasBorcBakanlik);
            this.Controls.Add(this.btn_vergiAd_bakanlikAd_borcAd_borcTarih);
            this.Controls.Add(this.btn_vergiAd_vergiTip_BaakAd_DaireBask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_vergiTipi1);
            this.Controls.Add(this.txt_vergiAdi);
            this.Controls.Add(this.btn_vergiAdiTipi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.btn_secilenTutar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_faizUst);
            this.Controls.Add(this.btn_faizUst);
            this.Controls.Add(this.txt_tutarUst);
            this.Controls.Add(this.btn_tutarUst);
            this.Controls.Add(this.txt_vergiTipi);
            this.Controls.Add(this.btn_vergiTipi);
            this.Name = "VergiRaporDetay";
            this.Text = "Vergi Rapor Detayı";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_vergiRaporDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vergiTipi;
        private System.Windows.Forms.Button btn_vergiTipi;
        private System.Windows.Forms.TextBox txt_tutarUst;
        private System.Windows.Forms.Button btn_tutarUst;
        private System.Windows.Forms.TextBox txt_faizUst;
        private System.Windows.Forms.Button btn_faizUst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_vergiRaporDetay;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Button btn_secilenTutar;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vergiTipi1;
        private System.Windows.Forms.TextBox txt_vergiAdi;
        private System.Windows.Forms.Button btn_vergiAdiTipi;
        private System.Windows.Forms.Button btn_vergiAd_vergiTip_BaakAd_DaireBask;
        private System.Windows.Forms.Button btn_vergiAd_bakanlikAd_borcAd_borcTarih;
        private System.Windows.Forms.Button btn_vergiVatandasBorcBakanlik;
        private System.Windows.Forms.TextBox txt_vergiTipi3;
        private System.Windows.Forms.Button btn_vergiTipi_BakanlikAdi_meslek;
        private System.Windows.Forms.TextBox txt_borcMin;
        private System.Windows.Forms.Button btn_borcAralik;
        private System.Windows.Forms.TextBox txt_borcMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_vergiAdiSiralama;
        private System.Windows.Forms.Button btn_vergiTipiGruplama;
        private System.Windows.Forms.Button btn_vergiAdiGruplama;
    }
}