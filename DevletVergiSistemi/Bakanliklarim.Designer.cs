namespace DevletVergiSistemi
{
    partial class Bakanliklarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bakanliklarim));
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_Bakanliklar = new System.Windows.Forms.DataGridView();
            this.txt_merkez = new System.Windows.Forms.TextBox();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.txt_daireBaskanligi = new System.Windows.Forms.TextBox();
            this.txt_bakanlikAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bakanlikId = new System.Windows.Forms.TextBox();
            this.lbl_bakanlikId = new System.Windows.Forms.Label();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_önceki = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Bakanliklar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sil.Location = new System.Drawing.Point(246, 243);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 76);
            this.btn_sil.TabIndex = 28;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yenile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_yenile.Location = new System.Drawing.Point(130, 243);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 76);
            this.btn_yenile.TabIndex = 27;
            this.btn_yenile.Text = "YENİLE";
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Red;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kaydet.Location = new System.Drawing.Point(24, 243);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 76);
            this.btn_kaydet.TabIndex = 26;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Blue;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_listele.Location = new System.Drawing.Point(348, 243);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(88, 76);
            this.btn_listele.TabIndex = 25;
            this.btn_listele.Text = "LİSTELEME";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_Bakanliklar);
            this.groupBox1.Location = new System.Drawing.Point(456, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 337);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bakanlık Listesi";
            // 
            // dgw_Bakanliklar
            // 
            this.dgw_Bakanliklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Bakanliklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_Bakanliklar.Location = new System.Drawing.Point(3, 16);
            this.dgw_Bakanliklar.Name = "dgw_Bakanliklar";
            this.dgw_Bakanliklar.Size = new System.Drawing.Size(277, 318);
            this.dgw_Bakanliklar.TabIndex = 0;
            // 
            // txt_merkez
            // 
            this.txt_merkez.Location = new System.Drawing.Point(218, 174);
            this.txt_merkez.Name = "txt_merkez";
            this.txt_merkez.Size = new System.Drawing.Size(172, 20);
            this.txt_merkez.TabIndex = 4;
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(218, 131);
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(172, 20);
            this.txt_ciro.TabIndex = 3;
            // 
            // txt_daireBaskanligi
            // 
            this.txt_daireBaskanligi.Location = new System.Drawing.Point(218, 92);
            this.txt_daireBaskanligi.Name = "txt_daireBaskanligi";
            this.txt_daireBaskanligi.Size = new System.Drawing.Size(172, 20);
            this.txt_daireBaskanligi.TabIndex = 2;
            // 
            // txt_bakanlikAdi
            // 
            this.txt_bakanlikAdi.Location = new System.Drawing.Point(218, 55);
            this.txt_bakanlikAdi.Name = "txt_bakanlikAdi";
            this.txt_bakanlikAdi.Size = new System.Drawing.Size(172, 20);
            this.txt_bakanlikAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(41, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Merkez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ciro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Daire Başkanlığı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bakanlık Adı";
            // 
            // txt_bakanlikId
            // 
            this.txt_bakanlikId.Location = new System.Drawing.Point(218, 14);
            this.txt_bakanlikId.Name = "txt_bakanlikId";
            this.txt_bakanlikId.Size = new System.Drawing.Size(172, 20);
            this.txt_bakanlikId.TabIndex = 0;
            // 
            // lbl_bakanlikId
            // 
            this.lbl_bakanlikId.AutoSize = true;
            this.lbl_bakanlikId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bakanlikId.ForeColor = System.Drawing.Color.Blue;
            this.lbl_bakanlikId.Location = new System.Drawing.Point(41, 9);
            this.lbl_bakanlikId.Name = "lbl_bakanlikId";
            this.lbl_bakanlikId.Size = new System.Drawing.Size(112, 24);
            this.lbl_bakanlikId.TabIndex = 29;
            this.lbl_bakanlikId.Text = "Bakanlık ID";
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.BackgroundImage")));
            this.btn_sonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Location = new System.Drawing.Point(674, 396);
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
            this.btn_önceki.Location = new System.Drawing.Point(24, 391);
            this.btn_önceki.Name = "btn_önceki";
            this.btn_önceki.Size = new System.Drawing.Size(47, 38);
            this.btn_önceki.TabIndex = 58;
            this.btn_önceki.UseVisualStyleBackColor = false;
            this.btn_önceki.Click += new System.EventHandler(this.btn_önceki_Click);
            // 
            // Bakanliklarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_önceki);
            this.Controls.Add(this.txt_bakanlikId);
            this.Controls.Add(this.lbl_bakanlikId);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_merkez);
            this.Controls.Add(this.txt_ciro);
            this.Controls.Add(this.txt_daireBaskanligi);
            this.Controls.Add(this.txt_bakanlikAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bakanliklarim";
            this.Text = "Bakanliklarim";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Bakanliklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_Bakanliklar;
        private System.Windows.Forms.TextBox txt_merkez;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.TextBox txt_daireBaskanligi;
        private System.Windows.Forms.TextBox txt_bakanlikAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bakanlikId;
        private System.Windows.Forms.Label lbl_bakanlikId;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_önceki;
    }
}