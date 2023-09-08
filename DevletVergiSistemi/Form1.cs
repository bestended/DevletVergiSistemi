using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevletVergiSistemi
{
    public partial class Vergi : Form
    {
        VergiSistemiEntities con = new VergiSistemiEntities();
        public Vergi()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Vergiler vergi = new Vergiler();
            vergi.vergiAdi = txt_vergiAdi.Text;
            vergi.vergiTipi = txt_vergiTipi.Text;
            vergi.tutar = Convert.ToInt32(txt_Tutar.Text);
            vergi.faiz= Convert.ToInt32(txt_Faiz.Text);
            vergi.bakanlikId = Convert.ToInt32(txt_bakanlikId.Text);
            con.vergiEkle(vergi.vergiAdi, vergi.vergiTipi,vergi.tutar,vergi.faiz,vergi.bakanlikId);
            con.SaveChanges();
            dgw_vergi.DataSource = con.vergiListe().ToList();



        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            Vergiler vergi = new Vergiler();
            vergi.vergiId = Convert.ToInt32(txt_vergiNo.Text);
            vergi.vergiAdi = txt_vergiAdi.Text;
            vergi.vergiTipi = txt_vergiTipi.Text;
            vergi.tutar = Convert.ToInt32(txt_Tutar.Text);
            vergi.faiz = Convert.ToInt32(txt_Faiz.Text);
            vergi.bakanlikId = Convert.ToInt32(txt_bakanlikId.Text);
            con.vergiDüzenle(vergi.vergiId,vergi.vergiAdi, vergi.vergiTipi, vergi.tutar, vergi.faiz, vergi.bakanlikId);
            dgw_vergi.DataSource = con.vergiListe().ToList();



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Vergiler vergi = new Vergiler();
            vergi.vergiId = Convert.ToInt32(txt_vergiNo.Text);
            con.vergiSil(vergi.vergiId);
            con.SaveChanges();
            dgw_vergi.DataSource = con.vergiListe().ToList();



        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_vergi.DataSource = con.vergiListe().ToList();


        }

        private void btn_önceki_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            Raporlar raporEkrani = new Raporlar();
            raporEkrani.Show();
            this.Hide();
        }
    }
}
