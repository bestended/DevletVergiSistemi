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
    public partial class VergiRaporDetay : Form
    {
        VergiSistemiEntities con = new VergiSistemiEntities();

        public VergiRaporDetay()
        {
            InitializeComponent();
        }

        private void btn_vergiTipi_Click(object sender, EventArgs e)
        {

            dgw_vergiRaporDetay.DataSource = con.vergiTipiArama(txt_vergiTipi.Text);


        }

        private void btn_tutarUst_Click(object sender, EventArgs e)
        {
            dgw_vergiRaporDetay.DataSource = con.tutarUstüArama(Convert.ToInt32(txt_tutarUst.Text));

        }

        private void btn_faizUst_Click(object sender, EventArgs e)
        {
            dgw_vergiRaporDetay.DataSource = con.faizUstüArama(Convert.ToInt32(txt_faizUst.Text));
        }

        private void btn_secilenTutar_Click(object sender, EventArgs e)
        {

            dgw_vergiRaporDetay.DataSource = con.tutarSecilenAralik(Convert.ToInt32(txt_min.Text), Convert.ToInt32(txt_max.Text));

        }

        private void btn_vergiAdiTipi_Click(object sender, EventArgs e)
        {
            dgw_vergiRaporDetay.DataSource = con.vergiAdiTipi(txt_vergiAdi.Text,txt_vergiTipi1.Text);
        }

        private void btn_vergiAd_vergiTip_BaakAd_DaireBask_Click(object sender, EventArgs e)
        {
            dgw_vergiRaporDetay.DataSource = con.vergiBakanlik();


        }

        private void btn_vergiAd_bakanlikAd_borcAd_borcTarih_Click(object sender, EventArgs e)
        {
            dgw_vergiRaporDetay.DataSource=con.vergiBakanlikBorclar();
        }

        private void btn_vergiVatandasBorcBakanlik_Click(object sender, EventArgs e)
        {
            dgw_vergiRaporDetay.DataSource= con.vergiVatandasBorcBakanlik();
        }

        private void btn_vergiTipi_BakanlikAdi_meslek_Click(object sender, EventArgs e)
        {

            dgw_vergiRaporDetay.DataSource = con.vergiTipiBakanlikAdiMeslek(txt_vergiTipi3.Text);

        }

      

        private void btn_vergiAdiSiralama_Click(object sender, EventArgs e)
        {

            dgw_vergiRaporDetay.DataSource = con.vergiAdiSiralama();


        }

        private void btn_vergiAdiGruplama_Click(object sender, EventArgs e)
        {
            dgw_vergiRaporDetay.DataSource = con.vergiAdiGruplama();
        }

        private void btn_vergiTipiGruplama_Click(object sender, EventArgs e)
        {

            dgw_vergiRaporDetay.DataSource = con.vergiTipiGrupla();
            
        }

        private void btn_borcAralik_Click(object sender, EventArgs e)
        {
            dgw_vergiRaporDetay.DataSource = con.borcGirilenDegerAralik(Convert.ToInt32(txt_borcMin.Text),Convert.ToInt32(txt_borcMax.Text)).ToList() ;

        }
    }
}
