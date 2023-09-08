namespace DevletVergiSistemi
{
    partial class Vergi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vergi));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vergiAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vergiTipi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Faiz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_vergi = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.txt_bakanlikId = new System.Windows.Forms.TextBox();
            this.txt_vergiNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_önceki = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_vergi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vergi Adı";
            // 
            // txt_vergiAdi
            // 
            this.txt_vergiAdi.Location = new System.Drawing.Point(220, 64);
            this.txt_vergiAdi.Name = "txt_vergiAdi";
            this.txt_vergiAdi.Size = new System.Drawing.Size(172, 20);
            this.txt_vergiAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vergi Tipi";
            // 
            // txt_vergiTipi
            // 
            this.txt_vergiTipi.Location = new System.Drawing.Point(220, 101);
            this.txt_vergiTipi.Name = "txt_vergiTipi";
            this.txt_vergiTipi.Size = new System.Drawing.Size(172, 20);
            this.txt_vergiTipi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tutar";
            // 
            // txt_Tutar
            // 
            this.txt_Tutar.Location = new System.Drawing.Point(220, 140);
            this.txt_Tutar.Name = "txt_Tutar";
            this.txt_Tutar.Size = new System.Drawing.Size(172, 20);
            this.txt_Tutar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(43, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Faiz";
            // 
            // txt_Faiz
            // 
            this.txt_Faiz.Location = new System.Drawing.Point(220, 183);
            this.txt_Faiz.Name = "txt_Faiz";
            this.txt_Faiz.Size = new System.Drawing.Size(172, 20);
            this.txt_Faiz.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(43, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bakanlık ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_vergi);
            this.groupBox1.Location = new System.Drawing.Point(458, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 355);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vergiler Listesi";
            // 
            // dgw_vergi
            // 
            this.dgw_vergi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_vergi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_vergi.Location = new System.Drawing.Point(3, 16);
            this.dgw_vergi.Name = "dgw_vergi";
            this.dgw_vergi.Size = new System.Drawing.Size(277, 336);
            this.dgw_vergi.TabIndex = 0;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sil.Location = new System.Drawing.Point(248, 305);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yenile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_yenile.Location = new System.Drawing.Point(132, 305);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 12;
            this.btn_yenile.Text = "YENİLE";
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Red;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kaydet.Location = new System.Drawing.Point(26, 305);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Blue;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_listele.Location = new System.Drawing.Point(350, 305);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(88, 23);
            this.btn_listele.TabIndex = 10;
            this.btn_listele.Text = "LİSTELEME";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // txt_bakanlikId
            // 
            this.txt_bakanlikId.Location = new System.Drawing.Point(220, 230);
            this.txt_bakanlikId.Name = "txt_bakanlikId";
            this.txt_bakanlikId.Size = new System.Drawing.Size(172, 20);
            this.txt_bakanlikId.TabIndex = 5;
            // 
            // txt_vergiNo
            // 
            this.txt_vergiNo.Location = new System.Drawing.Point(220, 25);
            this.txt_vergiNo.Name = "txt_vergiNo";
            this.txt_vergiNo.Size = new System.Drawing.Size(176, 20);
            this.txt_vergiNo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(47, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vergi No";
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.BackgroundImage")));
            this.btn_sonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Location = new System.Drawing.Point(685, 392);
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
            this.btn_önceki.Location = new System.Drawing.Point(35, 387);
            this.btn_önceki.Name = "btn_önceki";
            this.btn_önceki.Size = new System.Drawing.Size(47, 38);
            this.btn_önceki.TabIndex = 58;
            this.btn_önceki.UseVisualStyleBackColor = false;
            this.btn_önceki.Click += new System.EventHandler(this.btn_önceki_Click);
            // 
            // Vergi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_önceki);
            this.Controls.Add(this.txt_vergiNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_bakanlikId);
            this.Controls.Add(this.txt_Faiz);
            this.Controls.Add(this.txt_Tutar);
            this.Controls.Add(this.txt_vergiTipi);
            this.Controls.Add(this.txt_vergiAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vergi";
            this.Text = "Vergi";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_vergi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vergiAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vergiTipi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Faiz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_vergi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.TextBox txt_bakanlikId;
        private System.Windows.Forms.TextBox txt_vergiNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_önceki;
    }
}

