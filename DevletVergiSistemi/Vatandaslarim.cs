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
    public partial class Vatandaslarim : Form
    {
        VergiSistemiEntities con = new VergiSistemiEntities();

        public Vatandaslarim()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Vatandaslar vatandas = new Vatandaslar();
            vatandas.tc = txt_tcKimlikNo.Text;
            vatandas.meslek = txt_Meslek.Text;
            vatandas.adres = txt_adres.Text;
            vatandas.telefon = txt_telefon.Text;
            vatandas.mail = txt_mail.Text;

            con.vatandasEkle(vatandas.tc,vatandas.meslek,vatandas.adres,vatandas.telefon,vatandas.mail);
            con.SaveChanges();
            dgw_vatandaslarim.DataSource = con.vatandasListe().ToList();


        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            Vatandaslar vatandas = new Vatandaslar();
            vatandas.kisiNo = Convert.ToInt32(txt_kisiNo.Text);
            vatandas.tc = txt_tcKimlikNo.Text;
            vatandas.meslek = txt_Meslek.Text;
            vatandas.adres = txt_adres.Text;
            vatandas.telefon = txt_telefon.Text;
            vatandas.mail = txt_mail.Text;

            con.vatandasDüzenle(vatandas.kisiNo, vatandas.tc, vatandas.meslek, vatandas.adres, vatandas.telefon, vatandas.mail);
            con.SaveChanges();
            dgw_vatandaslarim.DataSource = con.vatandasListe().ToList();



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Vatandaslar vatandas = new Vatandaslar();
            vatandas.kisiNo = Convert.ToInt32(txt_kisiNo.Text);
            con.vatandasSil(vatandas.kisiNo);
            dgw_vatandaslarim.DataSource = con.vatandasListe().ToList();

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_vatandaslarim.DataSource = con.vatandasListe().ToList();
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
