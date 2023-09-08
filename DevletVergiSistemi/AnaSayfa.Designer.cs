namespace DevletVergiSistemi
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_vatandas = new DevletVergiSistemi.roundButton();
            this.rbtn_bakanliklar = new DevletVergiSistemi.roundButton();
            this.rbtn_vergiler = new DevletVergiSistemi.roundButton();
            this.rbtn_borclar = new DevletVergiSistemi.roundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(209, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "VATANDAŞLAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(695, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "BAKANLIKLAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(704, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "BORÇLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(209, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "VERGİLER";
            // 
            // rbtn_vatandas
            // 
            this.rbtn_vatandas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_vatandas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn_vatandas.BackgroundImage")));
            this.rbtn_vatandas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn_vatandas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn_vatandas.ForeColor = System.Drawing.Color.Red;
            this.rbtn_vatandas.Location = new System.Drawing.Point(60, 45);
            this.rbtn_vatandas.Name = "rbtn_vatandas";
            this.rbtn_vatandas.Size = new System.Drawing.Size(416, 164);
            this.rbtn_vatandas.TabIndex = 12;
            this.rbtn_vatandas.UseVisualStyleBackColor = false;
            this.rbtn_vatandas.Click += new System.EventHandler(this.rbtn_vatandas_Click);
            // 
            // rbtn_bakanliklar
            // 
            this.rbtn_bakanliklar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_bakanliklar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn_bakanliklar.BackgroundImage")));
            this.rbtn_bakanliklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn_bakanliklar.ForeColor = System.Drawing.Color.Red;
            this.rbtn_bakanliklar.Location = new System.Drawing.Point(568, 254);
            this.rbtn_bakanliklar.Name = "rbtn_bakanliklar";
            this.rbtn_bakanliklar.Size = new System.Drawing.Size(384, 164);
            this.rbtn_bakanliklar.TabIndex = 7;
            this.rbtn_bakanliklar.UseVisualStyleBackColor = false;
            this.rbtn_bakanliklar.Click += new System.EventHandler(this.rbtn_bakanliklar_Click);
            // 
            // rbtn_vergiler
            // 
            this.rbtn_vergiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_vergiler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn_vergiler.BackgroundImage")));
            this.rbtn_vergiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn_vergiler.ForeColor = System.Drawing.Color.Red;
            this.rbtn_vergiler.Location = new System.Drawing.Point(45, 254);
            this.rbtn_vergiler.Name = "rbtn_vergiler";
            this.rbtn_vergiler.Size = new System.Drawing.Size(415, 164);
            this.rbtn_vergiler.TabIndex = 6;
            this.rbtn_vergiler.UseVisualStyleBackColor = false;
            this.rbtn_vergiler.Click += new System.EventHandler(this.rbtn_vergiler_Click);
            // 
            // rbtn_borclar
            // 
            this.rbtn_borclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_borclar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn_borclar.BackgroundImage")));
            this.rbtn_borclar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn_borclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn_borclar.ForeColor = System.Drawing.Color.Red;
            this.rbtn_borclar.Location = new System.Drawing.Point(558, 45);
            this.rbtn_borclar.Name = "rbtn_borclar";
            this.rbtn_borclar.Size = new System.Drawing.Size(416, 164);
            this.rbtn_borclar.TabIndex = 13;
            this.rbtn_borclar.UseVisualStyleBackColor = false;
            this.rbtn_borclar.Click += new System.EventHandler(this.rbtn_borclar_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1047, 471);
            this.Controls.Add(this.rbtn_borclar);
            this.Controls.Add(this.rbtn_vatandas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_bakanliklar);
            this.Controls.Add(this.rbtn_vergiler);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private roundButton rbtn_vergiler;
        private roundButton rbtn_bakanliklar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private roundButton rbtn_vatandas;
        private roundButton rbtn_borclar;
    }
}