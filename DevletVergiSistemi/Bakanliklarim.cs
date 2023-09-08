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
    public partial class Bakanliklarim : Form
    {
        VergiSistemiEntities con = new VergiSistemiEntities();
        public Bakanliklarim()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Bakanliklar bakanlik = new Bakanliklar();

            bakanlik.bakanlikAd = txt_bakanlikAdi.Text;
            bakanlik.daireBaskanlik = txt_daireBaskanligi.Text;
            bakanlik.ciro = Convert.ToInt32(txt_ciro.Text);
            bakanlik.merkez = txt_merkez.Text;

            con.bakanlikEkle(bakanlik.bakanlikAd,bakanlik.daireBaskanlik,bakanlik.ciro,bakanlik.merkez);
            con.SaveChanges();
            dgw_Bakanliklar.DataSource = con.bakanlikListele().ToList();     
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {

            Bakanliklar bakanlik = new Bakanliklar();
            bakanlik.bakanlikId = Convert.ToInt32(txt_bakanlikId.Text);
            bakanlik.bakanlikAd = txt_bakanlikAdi.Text;
            bakanlik.daireBaskanlik = txt_daireBaskanligi.Text;
            bakanlik.ciro = Convert.ToInt32(txt_ciro.Text);
            bakanlik.merkez = txt_merkez.Text;

            con.bakanlikGüncelle(Convert.ToInt32(bakanlik.bakanlikId),bakanlik.bakanlikAd, bakanlik.daireBaskanlik, Convert.ToInt32(bakanlik.ciro), bakanlik.merkez);
            con.SaveChanges();
            dgw_Bakanliklar.DataSource = con.bakanlikListele().ToList();



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            Bakanliklar bakanlik = new Bakanliklar();
            bakanlik.bakanlikId = Convert.ToInt32(txt_bakanlikId.Text);
            con.vergiSil(bakanlik.bakanlikId);
            con.SaveChanges();
            dgw_Bakanliklar.DataSource = con.bakanlikListele().ToList();


        }

   

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_Bakanliklar.DataSource = con.bakanlikListele().ToList();
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
