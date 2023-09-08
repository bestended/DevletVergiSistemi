namespace DevletVergiSistemi
{
    partial class Borclarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borclarim));
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_borclarim = new System.Windows.Forms.DataGridView();
            this.txt_borcTutari = new System.Windows.Forms.TextBox();
            this.txt_borcDurumu = new System.Windows.Forms.TextBox();
            this.txt_borcAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_vergiId = new System.Windows.Forms.TextBox();
            this.txt_kisiNo = new System.Windows.Forms.TextBox();
            this.txt_borcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_borcTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_önceki = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_borclarim)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sil.Location = new System.Drawing.Point(243, 297);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 81);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yenile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_yenile.Location = new System.Drawing.Point(127, 297);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 81);
            this.btn_yenile.TabIndex = 8;
            this.btn_yenile.Text = "YENİLE";
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Red;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kaydet.Location = new System.Drawing.Point(21, 297);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 81);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Blue;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_listele.Location = new System.Drawing.Point(345, 297);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(88, 81);
            this.btn_listele.TabIndex = 10;
            this.btn_listele.Text = "LİSTELEME";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_borclarim);
            this.groupBox1.Location = new System.Drawing.Point(453, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 342);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borçlar listesi";
            // 
            // dgw_borclarim
            // 
            this.dgw_borclarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_borclarim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_borclarim.Location = new System.Drawing.Point(3, 16);
            this.dgw_borclarim.Name = "dgw_borclarim";
            this.dgw_borclarim.Size = new System.Drawing.Size(277, 323);
            this.dgw_borclarim.TabIndex = 0;
            // 
            // txt_borcTutari
            // 
            this.txt_borcTutari.Location = new System.Drawing.Point(215, 129);
            this.txt_borcTutari.Name = "txt_borcTutari";
            this.txt_borcTutari.Size = new System.Drawing.Size(172, 20);
            this.txt_borcTutari.TabIndex = 3;
            // 
            // txt_borcDurumu
            // 
            this.txt_borcDurumu.Location = new System.Drawing.Point(215, 90);
            this.txt_borcDurumu.Name = "txt_borcDurumu";
            this.txt_borcDurumu.Size = new System.Drawing.Size(172, 20);
            this.txt_borcDurumu.TabIndex = 2;
            // 
            // txt_borcAdi
            // 
            this.txt_borcAdi.Location = new System.Drawing.Point(215, 53);
            this.txt_borcAdi.Name = "txt_borcAdi";
            this.txt_borcAdi.Size = new System.Drawing.Size(172, 20);
            this.txt_borcAdi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(38, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vergi ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(38, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Borç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Borç Tutarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Borç Durumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Borç Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(38, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kişi No";
            // 
            // txt_vergiId
            // 
            this.txt_vergiId.Location = new System.Drawing.Point(215, 209);
            this.txt_vergiId.Name = "txt_vergiId";
            this.txt_vergiId.Size = new System.Drawing.Size(172, 20);
            this.txt_vergiId.TabIndex = 5;
            // 
            // txt_kisiNo
            // 
            this.txt_kisiNo.Location = new System.Drawing.Point(215, 248);
            this.txt_kisiNo.Name = "txt_kisiNo";
            this.txt_kisiNo.Size = new System.Drawing.Size(172, 20);
            this.txt_kisiNo.TabIndex = 6;
            // 
            // txt_borcNo
            // 
            this.txt_borcNo.Location = new System.Drawing.Point(215, 14);
            this.txt_borcNo.Name = "txt_borcNo";
            this.txt_borcNo.Size = new System.Drawing.Size(172, 20);
            this.txt_borcNo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(38, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Borç No";
            // 
            // dtp_borcTarihi
            // 
            this.dtp_borcTarihi.Location = new System.Drawing.Point(215, 167);
            this.dtp_borcTarihi.Name = "dtp_borcTarihi";
            this.dtp_borcTarihi.Size = new System.Drawing.Size(172, 20);
            this.dtp_borcTarihi.TabIndex = 4;
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.BackgroundImage")));
            this.btn_sonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Location = new System.Drawing.Point(671, 389);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(47, 38);
            this.btn_sonraki.TabIndex = 59;
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_önceki
            // 
            this.btn_önceki.BackColor = System.Drawing.Color.Transparent;
            this.btn_önceki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_önceki.BackgroundImage")));
            this.btn_önceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_önceki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_önceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_önceki.Location = new System.Drawing.Point(21, 400);
            this.btn_önceki.Name = "btn_önceki";
            this.btn_önceki.Size = new System.Drawing.Size(47, 38);
            this.btn_önceki.TabIndex = 58;
            this.btn_önceki.UseVisualStyleBackColor = false;
            this.btn_önceki.Click += new System.EventHandler(this.btn_önceki_Click);
            // 
            // Borclarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_önceki);
            this.Controls.Add(this.dtp_borcTarihi);
            this.Controls.Add(this.txt_borcNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_kisiNo);
            this.Controls.Add(this.txt_borcTutari);
            this.Controls.Add(this.txt_vergiId);
            this.Controls.Add(this.txt_borcDurumu);
            this.Controls.Add(this.txt_borcAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Borclarim";
            this.Text = "Borclarim";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_borclarim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_borclarim;
        private System.Windows.Forms.TextBox txt_borcTutari;
        private System.Windows.Forms.TextBox txt_borcDurumu;
        private System.Windows.Forms.TextBox txt_borcAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_vergiId;
        private System.Windows.Forms.TextBox txt_kisiNo;
        private System.Windows.Forms.TextBox txt_borcNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_borcTarihi;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_önceki;
    }
}