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
    public partial class Borclarim : Form
    {
        VergiSistemiEntities con = new VergiSistemiEntities();
        public Borclarim()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Borclar borclar = new Borclar();
            
            borclar.borcAdi = txt_borcAdi.Text;
            borclar.borcDurumu = txt_borcDurumu.Text;
            borclar.borcTutari = Convert.ToInt32(txt_borcTutari.Text);
            borclar.borcTarihi = Convert.ToDateTime(dtp_borcTarihi.Text);
            borclar.vergiId = Convert.ToInt32(txt_vergiId.Text);
            borclar.kisiNo = Convert.ToInt32(txt_kisiNo.Text);

            con.borcEkle(borclar.borcAdi,borclar.borcDurumu, Convert.ToInt32(borclar.borcTutari), Convert.ToDateTime(borclar.borcTarihi),borclar.vergiId,borclar.kisiNo);
            con.SaveChanges();
            dgw_borclarim.DataSource = con.borcListele().ToList();

        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            Borclar borclar = new Borclar();
            borclar.borcNo = Convert.ToInt32(txt_borcNo.Text);
            borclar.borcAdi = txt_borcAdi.Text;
            borclar.borcDurumu = txt_borcDurumu.Text;
            borclar.borcTutari = Convert.ToInt32(txt_borcTutari.Text);
            borclar.borcTarihi = Convert.ToDateTime(dtp_borcTarihi.Text);
            borclar.vergiId = Convert.ToInt32(txt_vergiId.Text);
            borclar.kisiNo = Convert.ToInt32(txt_kisiNo.Text);

            con.borcGüncelle(Convert.ToInt32(borclar.borcNo), borclar.borcAdi, borclar.borcDurumu, borclar.borcTutari,
                borclar.borcTarihi, borclar.vergiId, borclar.kisiNo);
            con.SaveChanges();
            dgw_borclarim.DataSource = con.borcListele().ToList();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Borclar borclar = new Borclar();
            borclar.borcNo = Convert.ToInt32(txt_borcNo.Text);
            con.borcSil(borclar.borcNo);
            con.SaveChanges();

            dgw_borclarim.DataSource=con.borcListele().ToList();

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_borclarim.DataSource = con.borcListele().ToList();
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
