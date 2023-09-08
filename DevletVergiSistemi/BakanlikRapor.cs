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
    public partial class BakanlikRapor : Form
    {
        VergiSistemiEntities con = new VergiSistemiEntities();
        public BakanlikRapor()
        {
            InitializeComponent();
        }

        private void btn_bakanlikAdi_Click(object sender, EventArgs e)
        {
            dgw_bakanlikRaporDetay.DataSource = con.bakanlikAdSorgu(txt_bakanlikAdi.Text);
        }

        private void btn_daireBaskanligi_Click(object sender, EventArgs e)
        {
            dgw_bakanlikRaporDetay.DataSource = con.bakDaireBaskSorgu(txt_daireBaskanligi.Text);
        }
        
        private void btn_bakanlikAdCirVerTütarBorcAdiVatMeslek_Click(object sender, EventArgs e)
        {
            dgw_bakanlikRaporDetay.DataSource = con.bakanlikAdCirVerTütarBorcAdiVatMeslek(txt_bakanlikAd.Text);
        }

        private void btn_ciro_vergiAdi_borcTutar_Click(object sender, EventArgs e)
        {

            dgw_bakanlikRaporDetay.DataSource = con.ciroBakAdDaireBsk(Convert.ToInt32(txt_minCiro.Text), Convert.ToInt32(txt_maxCiro.Text));
          
        }

        private void btn_bakanlikAdTerstenSira_Click(object sender, EventArgs e)
        {
            dgw_bakanlikRaporDetay.DataSource = con.siralaBakanlikAdTers();
        }

        private void btn_bakAdAlfSira_Click(object sender, EventArgs e)
        {
            dgw_bakanlikRaporDetay.DataSource = con.siralaBakanlikAd();
        }

        private void btn_bakTümü_Click(object sender, EventArgs e)
        {
            dgw_bakanlikRaporDetay.DataSource = con.bakAdCiroVerAdTipBorcAdTarihVatMeslTel();
        }
    }
}
